#include "execute_task.h"
#include "can_device.h"
#include "uart_device.h"
#include "cmsis_os.h"
#include "calibrate.h"
#include "pid.h"
#include "mixed_pid.h"
#include "sys.h"


mixed_pid m;
int16_t current[4] = {0};

void execute_task(const void *argu)
{
	
		pid_param_init();
		mixed_pid_init(&m,motor_type_2006);
		
		while (1){
			
			float anticipation=0;
			
			if (rc.sw1==RC_DN)anticipation=360*1;
			if (rc.sw1==RC_UP)anticipation=-360*1;

			
			
			current[0]=	mixed_pid_calc(&m,pitch_motor.total_angle,pitch_motor.speed_rpm,anticipation*36);
			send_chassis_moto_current(current);
			
			
		}

}
