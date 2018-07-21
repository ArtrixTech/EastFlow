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

const float CH_MAX=660.0f;

	int a=0;

void execute_task(const void* argu)
{
 
/*  //测试电机初始化	
   test_moto_init();

   while(1)
  {
   //测试电机控制程序
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
	
	//int16_t current[4]={0};
	
		
	//pid_t pid_pitch_motor    = { 0 };
	
//	 pid_init(&pid_pitch_motor, 12000, 0, 12, 0, 50);
	
	 set_pwm_group_param(PWM_GROUP1,20000);
	  start_pwm_output(PWM_IO1);
		
	
	
	 while(1)
  {
		//current[0]=pid_calc(&pid_pitch_motor, pitch_motor.speed_rpm, (int)(rc.ch2/CH_MAX*15000));;
			
		
		  start_pwm_output(PWM_IO1);
		if (rc.sw1 ==1)		
		{set_pwm_param(PWM_IO1,(int)(rc.ch2/CH_MAX*1500)+1500);a=1;}
		if (rc.sw1 ==2)		
		{	set_pwm_param(PWM_IO1,1500);a=2;}
	//send_chassis_moto_current(current);
	}
	osDelay(5);
}
