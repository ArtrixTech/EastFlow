#ifndef __EXECUTE_TASK_H__
#define __EXECUTE_TASK_H__

#include "can_device.h"
#include "rm_hal_lib.h"
#include "stm32f4xx_hal.h"

void execute_task(const void* argu);

void lift_moto_init(void);
void lift_moto_control(void);

void pinch_moto_init(void);
void pinch_moto_control(void);

extern int16_t lift_pinch_moto_current[2];
void send_lift_pinch_moto_current(int16_t lift_moto_current[]);

#endif
