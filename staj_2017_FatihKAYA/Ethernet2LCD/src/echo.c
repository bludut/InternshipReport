/******************************************************************************
*
* Copyright (C) 2016 Xilinx, Inc.  All rights reserved.
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

#include <stdio.h>
#include <string.h>

#include "lwip/sockets.h"
#include "netif/xadapter.h"
#include "lwipopts.h"
#include "xil_printf.h"
#include "FreeRTOS.h"
#include "task.h"

#include "xgpio.h"
#include "LCD.h"
#include "LED.h"

#define THREAD_STACKSIZE 1024


u16_t echo_port = 7;


void performCommand(char* Command)
{

#define LCD_COMMAND '#'
#define LED_COMMAND '+'



	u8 temp[100];
	int i = 0;

	while(Command[i] != '$' )
	{
	temp[i] = Command[i];
	i++;
	}
	temp[i] = '\0';

	switch (temp[0]) {
		case LCD_COMMAND:
			LCDClearScreen();
			LCDSetCursorPosition(1,0);
			LCDWriteString(temp+1);
			xil_printf(" %s is written into the LCD Display\n",temp+1);
			break;
		case LED_COMMAND:
			LED_Write(temp[1]);
			xil_printf("%d is send to LED\n",temp[1]);
			break;
	}
}

void PeripheralsInit()
{
	LCD_init();
	LED_Init();

}

void print_echo_app_header()
{
    xil_printf("%20s %6d %s\r\n", "echo server",
                        echo_port,
                        "$ telnet <board_ip> 7");

}

/* thread spawned for each connection */
void process_echo_request(void *p)
{
	int sd = (int)p;
	int RECV_BUF_SIZE = 50;
	char recv_buf[RECV_BUF_SIZE];
	int n, nwrote;

	while (1) {

		/* read a max of RECV_BUF_SIZE bytes from socket */
		if ((n = read(sd, recv_buf, RECV_BUF_SIZE)) < 0) {
			xil_printf("%s: error reading from socket %d, closing socket\r\n", __FUNCTION__, sd);
			break;
		}

		/* break if the recved message = "quit" */
		if (!strncmp(recv_buf, "quit", 4))
			break;

		/* break if client closed connection */
		if (n <= 0)
			break;
		/*
		 * User Commands
		 */


		performCommand(recv_buf);


		/* handle request */
		if ((nwrote = write(sd, recv_buf, n)) < 0) {
			xil_printf("%s: ERROR responding to client echo request. received = %d, written = %d\r\n",
					__FUNCTION__, n, nwrote);
			xil_printf("Closing socket %d\r\n", sd);
			break;
		}

	}

	/* close connection */
	close(sd);
	vTaskDelete(NULL);
}

void echo_application_thread()
{
	int sock, new_sd;
	struct sockaddr_in address, remote;
	int size;

	if ((sock = lwip_socket(AF_INET, SOCK_STREAM, 0)) < 0)
		return;

	address.sin_family = AF_INET;
	address.sin_port = htons(echo_port);
	address.sin_addr.s_addr = INADDR_ANY;

	if (lwip_bind(sock, (struct sockaddr *)&address, sizeof (address)) < 0)
		return;

	lwip_listen(sock, 0);

	size = sizeof(remote);

	xil_printf("Waiting for the connection\n");
	while (1) {

		if ((new_sd = lwip_accept(sock, (struct sockaddr *)&remote, (socklen_t *)&size)) > 0) {
			xil_printf("Connection Succeeded\n");
			sys_thread_new("echos", process_echo_request,
				(void*)new_sd,
				THREAD_STACKSIZE,
				DEFAULT_THREAD_PRIO);
		}

	}
}


