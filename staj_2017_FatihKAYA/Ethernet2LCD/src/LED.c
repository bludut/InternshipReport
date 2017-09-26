#include "xgpio.h"
#include "xparameters.h"
#include "LED.h"



void LED_Init(){

	XGpio_Initialize(&gpioLED,GPIO_LED_ID);

}

void LED_Write( u32  data){

	XGpio_DiscreteWrite(&gpioLED,LED_CH,data);

}
