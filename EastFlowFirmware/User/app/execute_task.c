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



void execute_task(const void* argu)
{
   //���Ե����ʼ��	
   test_moto_init();

   while(1)
  {
   //���Ե�����Ƴ���
    test_moto_control();
		
		if(rc.sw2 == 3)
			{
		   test_servo=1;
			}
   
		else
		  {
			(test_servo =0);
		  }
			
    osDelay(5);
  }
}
