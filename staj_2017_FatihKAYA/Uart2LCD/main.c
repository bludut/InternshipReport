/******************************************************************************
*
* Copyright (C) 2009 - 2014 Xilinx, Inc.  All rights reserved.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* Use of the Software is limited solely to applications:
* (a) running on a Xilinx device, or
* (b) that interact with a Xilinx device through a bus or interconnect.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
* XILINX  BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
* WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF
* OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*
* Except as contained in this notice, the name of the Xilinx shall not be used
* in advertising or otherwise to promote the sale, use or other dealings in
* this Software without prior written authorization from Xilinx.
*
******************************************************************************/

/*
 * helloworld.c: simple test application
 *
 * This application configures UART 16550 to baud rate 9600.
 * PS7 UART (Zynq) is not initialized by this application, since
 * bootrom/bsp configures it to baud rate 115200
 *
 * ------------------------------------------------
 * | UART TYPE   BAUD RATE                        |
 * ------------------------------------------------
 *   uartns550   9600
 *   uartlite    Configurable only in HW design
 *   ps7_uart    115200 (configured by bootrom/bsp)
 */

#include <stdio.h>
#include "xparameters.h"

#include "xuartlite.h"
#include "xuartlite_l.h"
#include "xgpio.h"
#include "xintc.h"
#include "xtmrctr.h"

#include "LCD.h"
#include "SerialConn.h"
#include "delay.h"


/*
 *	Timer and interrupt controller for delay
 */
XTmrCtr timer;
XIntc interrupt_controller;
/*
 * 	Switches
 */
XGpio	DIP_Switch;
#define DIP_ID	XPAR_AXI_GPIO_0_DEVICE_ID
#define DIP_CH 1
#define DIP_INT_ID	XPAR_INTC_0_GPIO_0_VEC_ID
#define INT_MASK XGPIO_IR_CH1_MASK


void DIP_init();
void DIPIntHandler();


#ifdef NO_UART_INT
#define UART_BASE_ADDRESS XPAR_AXI_UARTLITE_0_BASEADDR
#define BUFFER_SIZE 20
void Uart2LCD(int ,int );
#endif

int main()
{

	UART_Init(&interrupt_controller);
	print("Uart init\n");

	LCD_init();
	print("LCD init\n");

	TimerDelayInit(&timer,&interrupt_controller);
	print("Timer init.\n");

	DIP_init();
	print("DIP init \n");

	while(1){


		xil_printf("LOOPDA\n");

		delay(&timer,SEC);

		}

	xil_printf("SON");
	return 0;
}


void DIP_init(){

	XGpio_Initialize(&DIP_Switch,DIP_ID);

	XIntc_Initialize(&interrupt_controller,INTC_DEVICE_ID);
	XIntc_Connect(&interrupt_controller,DIP_INT_ID,(Xil_ExceptionHandler)DIPIntHandler,&DIP_Switch);
	XIntc_Enable(&interrupt_controller,DIP_INT_ID);
	XIntc_Start(&interrupt_controller,XIN_REAL_MODE);

	XGpio_InterruptEnable(&DIP_Switch,INT_MASK);
	XGpio_InterruptGlobalEnable(&DIP_Switch);

	Xil_ExceptionInit();	// empty
	Xil_ExceptionRegisterHandler(XIL_EXCEPTION_ID_INT,(Xil_ExceptionHandler)XIntc_InterruptHandler,&interrupt_controller);
	Xil_ExceptionEnable();	// microblaze_enable_interrupts();



}

void DIPIntHandler(void *CallbackRef){

	u8 DIP_state;
	DIP_state = XGpio_DiscreteRead(&DIP_Switch,DIP_CH);

	XUartLite_SendByte(UartLite.RegBaseAddress,'#');
	xil_printf("%03d\n",DIP_state);

	/* Clear the Interrupt */
	XGpio_InterruptClear(&DIP_Switch,INT_MASK);

}


#ifdef NO_UART_INT
void Uart2LCD(int LCD_row,int LCD_col)
{
	int BufferSize;
	int Index;
	u8 RecvBuffer[BUFFER_SIZE];

	BufferSize = XUartLite_RecvByte(UART_BASE_ADDRESS);

	for (Index = 0; Index < BufferSize ; Index++) {
		RecvBuffer[Index] = XUartLite_RecvByte(UART_BASE_ADDRESS);
	}

	LCDSetCursorPosition(LCD_row,LCD_col);
	LCDWriteString(RecvBuffer);

}
#endif
