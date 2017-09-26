/*
 * delay.c
 *
 *  Created on: 11 Eyl 2017
 *      Author: oguzsen
 */
#include "xuartlite.h"
#include "xtmrctr.h"
#include "xintc.h"
#include "xgpio.h"
#include "xparameters.h"
#include "delay.h"


int  delay_flag=1;

void delay(XTmrCtr* Timer,int32_t delay_time)
{
	XTmrCtr_SetResetValue(Timer,Timer_ch,delay_time);
	XTmrCtr_Start(Timer,Timer_ch);
	while(delay_flag);
	XTmrCtr_Stop(Timer,Timer_ch);
	delay_flag = 1;

}

int Set_Timer_INT(XTmrCtr* Timer,XIntc* Interrrupt ){

	XIntc_Initialize(Interrrupt,Int_ID);
	print("Interrupt Initialized\n");

	XIntc_Connect(Interrrupt,Timer_INT_ID,(void *)XTmrCtr_InterruptHandler,Timer); // &timer is callback for the interrupt.
	print("Interrupt timer connection is ready\n");

	XIntc_Start(Interrrupt,XIN_REAL_MODE);
	print("Interrupt mode is set to real mode\n");

	XIntc_Enable(Interrrupt, Timer_INT_ID);
	print("Interrupt is enabled\n");

	Xil_ExceptionInit();	// empty!!!????

	Xil_ExceptionRegisterHandler(XIL_EXCEPTION_ID_INT,(void *)XIntc_InterruptHandler,Interrrupt);

	Xil_ExceptionEnable();

	print("Timer interrupt options are set.\n");
	return XST_SUCCESS;
}

void TimerDelayInit(XTmrCtr* Timer,XIntc* Interrrupt)
{

	/*
	 * 	timer and interrupt settings
	 */
	XTmrCtr_Initialize(Timer,Timer_ID);

	Set_Timer_INT( Timer, Interrrupt );

	XTmrCtr_SetHandler(Timer,(void *)Timer_IntHandler,Timer);

	XTmrCtr_SetOptions(Timer,Timer_ch,XTC_INT_MODE_OPTION |XTC_DOWN_COUNT_OPTION | XTC_AUTO_RELOAD_OPTION);

	XTmrCtr_SetResetValue(Timer,Timer_ch,0);


}

void Timer_IntHandler(void *CallBackRef)
{
	//XTmrCtr *TmrctrPTR = (XTmrCtr *)CallBackRef;
	delay_flag = 0;



}

