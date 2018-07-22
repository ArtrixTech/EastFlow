#include "execute_task.h"
#include "can_device.h"
#include "uart_device.h"
#include "cmsis_os.h"
#include "calibrate.h"
#include "pid.h"
#include "sys.h"

//uint8_t test_key_value;
extern uint8_t test_servo;

//uint16_t servo_angle = 1000;

const float CH_MAX = 660.0f;

mixed_pid m;

void execute_task(const void *argu)
{
	
		pid_param_init();
		int16_t current[4] = {0};

		mixed_pid_init(&m,motor_type_2006);
	
		
	while (1)
	{
		current[0]=	mixed_calc(&m,pitch_motor.total_angle,pitch_motor.speed_rpm,(rc.ch2/CH_MAX*90*36*8));
		send_chassis_moto_current(current);
	}
	osDelay(5);
}
