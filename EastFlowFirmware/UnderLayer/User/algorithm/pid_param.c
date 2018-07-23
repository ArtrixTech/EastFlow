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
 
 
#include "pid_param.h"

pid_param pid_param_2006;
pid_param pid_param_3508;

void pid_param_init(){								// Must do this function before using all the PID related functions!
	
	// -- 2006 Motor initialize
	
	pid_param_2006.is_single_spd=false;
	
	pid_param_2006.loc_kp=4;
	pid_param_2006.loc_ki=0.1;
	pid_param_2006.loc_kd=0;
	
	pid_param_2006.spd_kp=15;
	pid_param_2006.spd_ki=1.5;
	pid_param_2006.spd_kd=0;

	pid_param_2006.loc_output_max=10000;
	pid_param_2006.spd_output_max=7000;
	
	// -- 3508 Motor initialize
	
	pid_param_3508.is_single_spd=false;
	
	pid_param_3508.loc_kp=2.0f;
	pid_param_3508.loc_ki=0.1;
	pid_param_3508.loc_kd=50.0f;
	
	pid_param_3508.spd_kp=1.0f;
	pid_param_3508.spd_ki=0.0f;
	pid_param_3508.spd_kd=1.0f;

	pid_param_3508.loc_output_max=8700;
	pid_param_3508.spd_output_max=10000;

}

// Speed + Location PID Control part
void pid_param_register(pid_t *pid_loc,pid_t *pid_spd,motor_type type){
	
	switch (type)
	{
		case (motor_type_2006):{
			pid_param param=pid_param_2006;
			pid_init(pid_loc,param.loc_output_max,param.loc_ki,param.loc_kp,param.loc_ki,param.loc_kd);
			pid_init(pid_spd,param.spd_output_max,param.spd_ki,param.spd_kp,param.spd_ki,param.spd_kd);
		}break;
		case (motor_type_3508):{
			pid_param param=pid_param_3508;
			pid_init(pid_loc,param.loc_output_max,param.loc_ki,param.loc_kp,param.loc_ki,param.loc_kd);
			pid_init(pid_spd,param.spd_output_max,param.spd_ki,param.spd_kp,param.spd_ki,param.spd_kd);
		}break;
	}
	
}

// Single Speed PID Control part
void pid_param_register_single_spd(pid_t *pid_spd,motor_type type){
	
	switch (type)
	{
		case (motor_type_2006):{
			pid_param param=pid_param_2006;
			pid_init(pid_spd,param.spd_output_max,param.spd_ki,param.spd_kp,param.spd_ki,param.spd_kd);
		}break;
		case (motor_type_3508):{
			pid_param param=pid_param_3508;
			pid_init(pid_spd,param.spd_output_max,param.spd_ki,param.spd_kp,param.spd_ki,param.spd_kd);
		}break;
	}
	
}
