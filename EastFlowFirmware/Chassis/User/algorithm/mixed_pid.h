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
#include "pid_param.h"


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
