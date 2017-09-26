/*
 * SerialConn.h
 *
 *  Created on: 11 Eyl 2017
 *      Author: oguzsen
 */

#ifndef CUSTOMLIBS_SERIALCONN_H_
#define CUSTOMLIBS_SERIALCONN_H_

/**
 * Uartlite makros and variables
 */
#define UARTLITE_DEVICE_ID      XPAR_UARTLITE_0_DEVICE_ID
#define INTC_DEVICE_ID          XPAR_INTC_0_DEVICE_ID
#define UARTLITE_INT_IRQ_ID     XPAR_INTC_0_UARTLITE_0_VEC_ID

XUartLite UartLite;
 u8 ReceiveBuffer[50];

 /*
  * Function Prototypes
  */
 extern  int UART_Init( XIntc* Interrrupt);
 extern  int Set_UART_Interrupt( XIntc* Interrrupt );
 extern  void RecvHandler(XUartLite *InstancePtr);
 extern  void CommandControl();


#endif /* CUSTOMLIBS_SERIALCONN_H_ */
