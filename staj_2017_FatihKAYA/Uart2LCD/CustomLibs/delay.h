/*
 * delay.h
 *
 *  Created on: 11 Eyl 2017
 *      Author: oguzsen
 */

#ifndef CUSTOMLIBS_DELAY_H_
#define CUSTOMLIBS_DELAY_H_


/*
 *  Timer
 */
#define Timer_ID XPAR_AXI_TIMER_0_DEVICE_ID
#define Timer_ch 1
#define Timer_INT_ID XPAR_INTC_0_TMRCTR_0_VEC_ID

/*
 * Makros for delay times
 */
#define SEC	(XPAR_TMRCTR_0_CLOCK_FREQ_HZ - 2)
#define MILISEC (XPAR_TMRCTR_0_CLOCK_FREQ_HZ/1000 - 2)
#define MICROSEC (XPAR_TMRCTR_0_CLOCK_FREQ_HZ/1000000 - 2)

/*
 * 	Interrupt
 */
#define Int_ID XPAR_INTC_0_DEVICE_ID



/*
 * 	Function prototypes
 */
extern void Timer_IntHandler(void *CallBackRef);
extern void TimerDelayInit(XTmrCtr* Timer, XIntc* Interrrupt);
extern int Set_Timer_INT(XTmrCtr* Timer, XIntc* Interrrupt );
extern void delay(XTmrCtr* Timer, int32_t delay_time);





#endif /* CUSTOMLIBS_DELAY_H_ */
