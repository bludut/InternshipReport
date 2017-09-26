/*
 * LED.h
 *
 *  Created on: 21 Eyl 2017
 *      Author: oguzsen
 */

#ifndef SRC_LED_H_
#define SRC_LED_H_

XGpio gpioLED;

#define GPIO_LED_ID XPAR_GPIO_0_DEVICE_ID
#define LED_CH 2

// Function Prototypes
extern void LED_Init();
extern void LED_Write( u32  data);




#endif /* SRC_LED_H_ */
