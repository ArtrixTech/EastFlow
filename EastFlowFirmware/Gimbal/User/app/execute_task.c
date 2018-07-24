#include "calibrate.h"
#include "can_device.h"
#include "cmsis_os.h"
#include "execute_task.h"
#include "pid.h"
#include "sys.h"
#include "uart_device.h"

void execute_task(const void* argu)
{
    lift_moto_init();
    pinch_moto_init();
    while (1) {
        lift_moto_control();
        pinch_moto_control();
        send_lift_moto_current(lift_moto_current);
        send_pinch_moto_current(pinch_moto_current);
        osDelay(5);
    }
}
