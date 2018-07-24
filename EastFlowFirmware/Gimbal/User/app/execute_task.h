#ifndef __EXECUTE_TASK_H__
#define __EXECUTE_TASK_H__

#include "can_device.h"
#include "rm_hal_lib.h"
#include "stm32f4xx_hal.h"

void execute_task(const void* argu);

/* lift moto */
extern int16_t lift_moto_current[1];

void lift_moto_init(void);
void lift_moto_control(void);

void send_lift_moto_current(int16_t lift_moto_current[]);
/* lift moto */

/* pinch moto */
extern int16_t pinch_moto_current[1];

void pinch_moto_init(void);
void pinch_moto_control(void);

void send_pinch_moto_current(int16_t pinch_moto_current[]);

/* pinch moto */

#endif
