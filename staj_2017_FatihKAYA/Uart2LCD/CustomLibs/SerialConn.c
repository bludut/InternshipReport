/*
 * SerialConn.c
 *
 *  Created on: 11 Eyl 2017
 *      Author: oguzsen
 */

#include "xparameters.h"

#include "xuartlite.h"
#include "xuartlite_i.h"
#include "xil_io.h"
#include "xintc.h"
#include "xil_exception.h"
#include "xgpio.h"

#include "SerialConn.h"
#include "LCD.h"

 int UART_Init( XIntc* Interrrupt){
	    ReceiveBuffer[0] = '\0';
		int Status;
		/*
		 * Initialize the UartLite driver so that it's ready to use.
		 */
		Status = XUartLite_Initialize(&UartLite, UARTLITE_DEVICE_ID);
		if (Status != XST_SUCCESS) {
			return XST_FAILURE;
		}

		/*
		 * Perform a self-test to ensure that the hardware was built correctly.
		 */
		Status = XUartLite_SelfTest(&UartLite);
		if (Status != XST_SUCCESS) {
			return XST_FAILURE;
		}

		/*
		 * Connect the UartLite to the interrupt subsystem such that interrupts can
		 * occur. This function is application specific.
		 */
		Status = Set_UART_Interrupt(Interrrupt );
		if (Status != XST_SUCCESS) {
			return XST_FAILURE;
		}

		/*
		 * Enable the interrupt of the UartLite so that interrupts will occur.
		 */
		XUartLite_EnableInterrupt(&UartLite);


		return XST_SUCCESS;
 }

 int Set_UART_Interrupt(XIntc* Interrrupt ){
		int Status;

		/*
		 * Initialize the interrupt controller driver so that it is ready to
		 * use.
		 */
		Status = XIntc_Initialize(Interrrupt, INTC_DEVICE_ID);
		if (Status != XST_SUCCESS) {
			return XST_FAILURE;
		}


		/*
		 * Connect a device driver handler that will be called when an interrupt
		 * for the device occurs, the device driver handler performs the
		 * specific interrupt processing for the device.
		 */
		Status = XIntc_Connect(Interrrupt, UARTLITE_INT_IRQ_ID,
				   (XInterruptHandler)RecvHandler,
				   &UartLite);
		if (Status != XST_SUCCESS) {
			return XST_FAILURE;
		}

		/*
		 * Start the interrupt controller such that interrupts are enabled for
		 * all devices that cause interrupts, specific real mode so that
		 * the UartLite can cause interrupts through the interrupt controller.
		 */
		Status = XIntc_Start(Interrrupt, XIN_REAL_MODE);
		if (Status != XST_SUCCESS) {
			return XST_FAILURE;
		}

		/*
		 * Enable the interrupt for the UartLite device.
		 */
		XIntc_Enable(Interrrupt, UARTLITE_INT_IRQ_ID);

		/*
		 * Initialize the exception table.
		 */
		Xil_ExceptionInit();

		/*
		 * Register the interrupt controller handler with the exception table.
		 */
		Xil_ExceptionRegisterHandler(XIL_EXCEPTION_ID_INT,
				 (Xil_ExceptionHandler)XIntc_InterruptHandler,
				 Interrrupt);

		/*
		 * Enable exceptions.
		 */
		Xil_ExceptionEnable();

		return XST_SUCCESS;
 }



 /*
  *
  */
 void RecvHandler(XUartLite *InstancePtr)
 {
	 u32 IsrStatus;

	 	Xil_AssertVoid(InstancePtr != NULL);

	 	/*
	 	 * Read the status register to determine which, could be both
	 	 * interrupt is active
	 	 */
	 	IsrStatus = XUartLite_ReadReg(InstancePtr->RegBaseAddress,
	 					XUL_STATUS_REG_OFFSET);

	 	if ((IsrStatus & (XUL_SR_RX_FIFO_FULL |
	 		XUL_SR_RX_FIFO_VALID_DATA)) != 0) {
	 		int index = 0;
	 		int BufferSize;
	 		BufferSize = XUartLite_RecvByte(InstancePtr->RegBaseAddress);

	 		for(index = 0; index < BufferSize; index++){

	 			ReceiveBuffer[index] = XUartLite_RecvByte(InstancePtr->RegBaseAddress);
	 		}
	 	}

	 	if (((IsrStatus & XUL_SR_TX_FIFO_EMPTY) != 0) &&
	 		(InstancePtr->SendBuffer.RequestedBytes > 0)) {
	 		// there is no need to set a interrupt function for sending
	 	}


	 	/*
	 	 * 	Perform the command
	 	 */
		CommandControl();

 }


#define LED_ID XPAR_GPIO_1_DEVICE_ID
#define LED_CH	2

 /*
  *  Comamnd Control
  */
 void CommandControl(){

	 XGpio gpio_LED;

	 switch(ReceiveBuffer[0]){
	 case '*' :
		 	 XGpio_Initialize(&gpio_LED,LED_ID);
		 	 XGpio_DiscreteWrite(&gpio_LED,LED_CH,ReceiveBuffer[1]);

		 break;
	 case '#':
	 	 	 LCDSetCursorPosition(1,0);
	 	 	 LCDWriteString(ReceiveBuffer+1);
	 break;


	 }
 }


