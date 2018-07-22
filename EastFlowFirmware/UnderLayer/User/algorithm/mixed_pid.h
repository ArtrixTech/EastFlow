/****************************************************************************
 *  Copyright (C) 2018 Artrix Technologies CO,.LTD.
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of 
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program. If not, see <http://www.gnu.org/licenses/>.
 ***************************************************************************/

/**
  *********************** (C) COPYRIGHT 2018 ArtrixTech **********************
  * @update
  * @history
  * Version     Date              Author           Modification
  * V1.0.0      July-22-2018      Artrix
  * @verbatim
  *********************** (C) COPYRIGHT 2018 ArtrixTech **********************
  */ 
 

#ifndef __mixed_pid_H__
#define __mixed_pid_H__

#include "stm32f4xx_hal.h"
#include "stdbool.h"
#include "pid.h"

typedef struct{
	
	bool is_single_spd;
	
	float loc_kp;
	float loc_ki;
	float loc_kd;
	
	float spd_kp;
	float spd_ki;
	float spd_kd;
	
	float single_spd_kp;
	float single_spd_ki;
	float single_spd_kd;
	
	float spd_output_max;
	float loc_output_max;
		
}pid_param;

typedef enum
{
 motor_type_2006,
 motor_type_3508
}motor_type;

extern pid_param pid_param_2006;
extern pid_param pid_param_3508;

/**
  * @brief     PID inner_built params initialization
  */
void pid_param_init(void);

/**
  * @brief     PID parameter quick register
  * @param[in] pid_loc: PID struct of location
  * @param[in] pid_spd: PID struct of speed
  * @param[in] param_type: PID parameter type -> 3508 or 2006
  */
void pid_param_register(pid_t *pid_loc,pid_t *pid_spd,motor_type type);

/**
  * @brief     PID parameter quick register (Only Single speed ring control)
  * @param[in] pid_spd: PID struct of speed
  * @param[in] param_type: PID parameter type -> 3508 or 2006
  */
void pid_param_register_single_spd(pid_t *pid_spd,motor_type type);

// -- Mixed PID module --

typedef struct{
	pid_t speed_pid;
	pid_t location_pid;
}mixed_pid;

/**
  * @brief     Mixed PID initialization
  * @param[in] *pid: Pointer of target mixex_pid object
  * @param[in] type: Motor type
  */
void mixed_pid_init(mixed_pid *pid,motor_type type);

/**
  * @brief     Mixed PID calculation
  * @param[in] input_loc: Location input
  * @param[in] input_spd: Speed input
  * @param[in] anticipation: Target location
  */
float mixed_pid_calc(mixed_pid *pid,float input_loc,float input_spd,float anticipation);

// -- Mixed PID module --

#endif
