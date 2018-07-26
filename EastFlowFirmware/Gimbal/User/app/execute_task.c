#include "calibrate.h"
#include "can_device.h"
#include "cmsis_os.h"
#include "execute_task.h"
#include "pid.h"
#include "sys.h"
#include "uart_device.h"

void execute_task(const void* argu)
{
	  //电调 bug
    osDelay(3000);
	
    lift_moto_init();
    pinch_moto_init();
    while (1) {
        lift_moto_control();
        pinch_moto_control();
        send_lift_pinch_moto_current(lift_pinch_moto_current);    // 使用 send_gimbal_moto_current()
        osDelay(5);
    }
}
