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
			current[0]=	mixed_pid_calc(&m,pitch_motor.total_angle,pitch_motor.speed_rpm,(rc.ch2/RC_MAX_VALUE*90*36*32));
			send_chassis_moto_current(current);
		}

}
