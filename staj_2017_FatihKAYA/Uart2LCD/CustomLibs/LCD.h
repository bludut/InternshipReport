/*
 * LCD.h
 *
 *  Created on: 11 Eyl 2017
 *      Author: oguzsen
 */

#ifndef _LCD_H_
#define _LCD_H_


/*
 * 	LCD
 */

#define GPIO_LCD_ID XPAR_AXI_GPIO_1_DEVICE_ID
#define GPIO_LCD_CH 1
XGpio	g_sLCD;


/*
 * 	LCD pins
 */

#define LCD_DATA_BITS	0b01111000
#define LCD_RW	0b00000100
#define LCD_RS	0b00000010
#define LCD_EN	0b00000001

/*
 * 	LCD DATA or INSTRUCTION send
 */
#define LCD_DATA_IN	LCD_RS
#define LCD_INSTRUCTION_IN	0

#define LCD_READ LCD_RW
#define LCD_WRITE 0

// LCD Command Makros
#define LCD_CMD_CLEAR_DISPLAY 		0x01
#define LCD_CMD_RETURN_HOME 		0x02
#define LCD_CMD_ENTRY_MODE_SET 		0x04
#define LCD_CMD_DISPLAY_ON_OFF		0x08
#define LCD_CMD_SHIFT				0x10
#define LCD_CMD_SET_FUNCTION		0x20
#define LCD_CMD_SET_CG_RAM_ADDRESS 	0x40
#define LCD_CMD_SET_DD_RAM_ADDRES  	0x80

//Flags for diplay entry mode
#define LCD_SET_CURSOR_INCREASE		0x02
#define LCD_SET_CURSOR_DECREASE		0
#define LCD_SET_DISPLAY_SHIFTED		0x01
#define LCD_SET_DISPLAY_NOT_SHIFTED 0

//Flags for display on/off control
#define LCD_SET_DISPLAY_ON			0x04
#define LCD_SET_DISPLAY_OFF			0
#define LCD_SET_CURSOR_ON			0x02
#define LCD_SET_CURSOR_OFF			0
#define LCD_SET_BLINK_ON			0x01
#define LCD_SET_BLINK_OFF			0

//Flag for display/ cursor shift
#define LCD_SET_DISPLAY_SHIFT		0x08
#define LCD_SET_CURSOR_MOVE			0
#define LCD_SET_RIGHT_SHIFT			0x04
#define LCD_SET_LEFT_SHIFT			0

//Flags for function set
#define LCD_SET_8BIT_INTERFACE		0x10
#define LCD_SET_4BIT_INTERFACE		0
#define LCD_SET_2_LINE_DISPLAY		0x08
#define LCD_SET_1_LINE_DISLAY		0
#define LCD_SET_5X10_DOTS			0x04
#define LCD_SET_5X7_DOTS			0

/*
 * MAKROS for delay function
 */
#define LCD_MILISECOND (100000000/8000)
#define LCD_MICROSECOND (100000000/8000000)

/*
 * 	Function Prototypes
 */
extern void LCD_init();
extern void LCDSend4BitCmd(int cmd, int RS_State);
extern void LCDSendInstruction(int instruction);
extern void LCDSendData(int data);
extern void LCDWriteChar(int data);
extern void LCDWriteString(u8 *data);
extern void LCDSetCursorPosition(int line, int Col);
extern void LCDCreateCharacter(int address, int *data);
extern void LCDScrollLeft();
extern void LCDScrollRight();
extern void LCDSetDisplayMode(int display_on_off,int cursor_on_off,int blink_on_off);
extern void reverse(int data, int *dataNew);
extern void LCD_delay(uint32_t delay);

#endif /* CUSTOMLIBS_LCD_H_ */
