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

int a = 0;

void execute_task(const void *argu)
{

	/*	
   test_moto_init();

   while(1)
  {
  
    test_moto_control();
		
		if(rc.sw2 == 3)
			{
		   test_servo=1;
			}
   
		else
		  {
			(test_servo =0);
		  }
			
   } osDelay(5);
  */

	int16_t current[4] = {0};
	pid_t pid_pitch_motor_spd = {0};
	pid_t pid_pitch_motor_loc = {0};
		
	pid_init(&pid_pitch_motor_loc, 18000, 20, 2.2, 0, 10);
  pid_init(&pid_pitch_motor_spd, 20000, 20, 5, 0, 0);

	//set_pwm_group_param(PWM_GROUP1,20000);
	// start_pwm_output(PWM_IO1);

	while (1)
	{
		int spd=pid_calc(&pid_pitch_motor_loc, pitch_motor.total_angle, (int)(rc.ch2/CH_MAX*15000));

		current[0]=pid_calc(&pid_pitch_motor_spd, pitch_motor.speed_rpm, spd);

/*
		start_pwm_output(PWM_IO1);
		if (rc.sw1 == 1)
		{
			set_pwm_param(PWM_IO1, (int)(rc.ch2 / CH_MAX * 1500) + 1500);
			a = 1;
		}
		if (rc.sw1 == 2)
		{
			set_pwm_param(PWM_IO1, 1500);
			a = 2;
		}
		*/
		send_chassis_moto_current(current);
	}
	osDelay(5);
}
