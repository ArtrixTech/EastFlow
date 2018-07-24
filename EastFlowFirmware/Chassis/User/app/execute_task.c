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

const int STARTUP_INITIALIZE_DIST=10; // Unit: mm
const int DIST_TO_DEG_RATIO=180; // Unit: degree
const int REDUCTION_GEAR_RATIO=36;

int dist_to_deg(int dist){	// Unit: mm
	
	return dist*DIST_TO_DEG_RATIO;
	
}

int bias_angle(int target_angle){return target_angle+ dist_to_deg(STARTUP_INITIALIZE_DIST);}

int target_angle;	// Final angle for sending

void execute_task(const void *argu)
{
	
		pid_param_init();
		mixed_pid_init(&m,motor_type_2006);
	
		write_led_io(LASER_IO,LED_ON);
		
		while (1){
			
			float anticipation=0;
			
			if (rc.sw1==RC_DN)anticipation=dist_to_deg(10);
			if (rc.sw1==RC_UP)anticipation=dist_to_deg(-10);
			
			//anticipation=rc.ch2/660.0f*dist_to_deg(7);

			target_angle=bias_angle(anticipation*REDUCTION_GEAR_RATIO);
			current[0]=	mixed_pid_calc(&m,moto_grip.total_angle,moto_grip.speed_rpm,target_angle);
			send_grip_moto_current(current);
			
			osDelay(5);
			
		}

}
