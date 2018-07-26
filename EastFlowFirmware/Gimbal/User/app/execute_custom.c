#include "can_device.h"
#include "execute_task.h"
#include "pid.h"
#include "sys.h"
#include "uart_device.h"

/* lift moto */
int16_t lift_moto_speed;
float lift_moto_angle;
int16_t lift_moto_current[1];

pid_t pid_lift_speed;
pid_t pid_lift_angle;

void lift_moto_init()
{
    pid_init(&pid_lift_speed, 10000, 0, 5, 0, 0);
    pid_init(&pid_lift_angle, 7000, 0, 100, 0, 0);
}

void lift_moto_control()
{
    if (rc.kb.bit.Z || rc.sw1 == RC_DN)
        lift_moto_angle = 0;
    else if (rc.kb.bit.X || rc.sw1 == RC_MI)
        lift_moto_angle = 240;
    else if (rc.kb.bit.C || rc.sw1 == RC_UP)
        lift_moto_angle = 480;
    else if (rc.kb.bit.V)
        lift_moto_angle = 960;

    lift_moto_speed = pid_calc(&pid_lift_angle,moto_lift.total_angle / 19.2, lift_moto_angle);
    lift_moto_current[0] = pid_calc(&pid_lift_speed, moto_lift.speed_rpm, lift_moto_speed);
}

void send_lift_moto_current(int16_t lift_moto_current[])
{
    static uint8_t data[8];

    data[0] = 0;
    data[1] = 0;
    data[2] = 0;
    data[3] = 0;
    data[4] = 0;
    data[5] = 0;
    data[6] = lift_moto_current[0] >> 8;
    data[7] = lift_moto_current[0];
    write_can(USER_CAN1, CAN_GIMBAL_ID, data);
}

/* lift moto */

/* pinch moto 

int16_t pinch_moto_speed;
float pinch_moto_angle;
int16_t pinch_moto_current[1];

pid_t pid_pinch_speed;
pid_t pid_pinch_angle;

void pinch_moto_init()
{
    pid_init(&pid_pinch_speed, 7000, 0, 10, 0, 0); // change this to adjust to 2006
    pid_init(&pid_pinch_angle, 7000, 0, 5, 0, 0);
}

void pinch_moto_control()
{
    if (rc.kb.bit.Q) {
        pinch_moto_angle = 60;
    } else if (rc.kb.bit.E) {
        pinch_moto_angle = 90;
    }

    if (rc.kb.bit.A) {
        pinch_moto_angle -= 30;
    } else if (rc.kb.bit.D) {
        pinch_moto_angle += 30;
    }

    pinch_moto_speed = pid_calc(&pid_pinch_speed, moto_trigger.total_angle / 36, pinch_moto_angle);
    pinch_moto_current[0] = pid_calc(&pid_pinch_angle, moto_trigger.speed_rpm, pinch_moto_speed);
}

void send_pinch_moto_current(int16_t pinch_moto_current[])
{
    static uint8_t data[8];

    data[0] = 0;
    data[1] = 0;
    data[2] = pinch_moto_current[0] >> 8;
    data[3] = pinch_moto_current[0];
    data[4] = 0;
    data[5] = 0;
    data[6] = 0;
    data[7] = 0;
    write_can(USER_CAN1, CAN_CHASSIS_ID, data);
}
*/
/* pinch moto */
