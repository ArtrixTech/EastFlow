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

// Unit: mm
const int STARTUP_INITIALIZE_DIST=5; 
const int MAX_DIST=10;
const int MIN_DIST=0;

// Unit: mm -> degree
const int DIST_TO_DEG_RATIO=180; 
const int REDUCTION_GEAR_RATIO=36;

// Unit: Input=mm | Output=degree(this angle is for the outer axis)
int dist_to_deg(int dist){return dist*DIST_TO_DEG_RATIO;}

int bias_angle(int target_angle){
	// Distance limitation
  int angle=target_angle+dist_to_deg(STARTUP_INITIALIZE_DIST)*REDUCTION_GEAR_RATIO;
	if (angle>dist_to_deg(MAX_DIST)*REDUCTION_GEAR_RATIO)return dist_to_deg(MAX_DIST)*REDUCTION_GEAR_RATIO;
	else if (angle<dist_to_deg(MIN_DIST)*REDUCTION_GEAR_RATIO)return dist_to_deg(MIN_DIST)*REDUCTION_GEAR_RATIO;
	else return angle;
}

int target_angle;	// Final angle for sending

void execute_task(const void *argu)
{
	
		pid_param_init();
		mixed_pid_init(&m,motor_type_2006);

		write_led_io(LASER_IO,LED_ON);
			
		while (1){
			
			float anticipation=0;

			if (rc.sw1==RC_DN)anticipation=dist_to_deg(-4999);
			if (rc.sw1==RC_UP)anticipation=dist_to_deg(99999);

			// ONLY FOR DEBUG
			// anticipation = rc.ch2 / 660.0f * dist_to_deg(7);

			target_angle=bias_angle(anticipation*REDUCTION_GEAR_RATIO);
			current[0]=	mixed_pid_calc(&m,moto_grip.total_angle,moto_grip.speed_rpm,target_angle);
			send_grip_moto_current(current);
			osDelay(5);
		
		}

}
