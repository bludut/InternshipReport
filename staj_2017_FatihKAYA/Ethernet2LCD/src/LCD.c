
#include "xgpio.h"
#include "xuartlite.h"
#include "xparameters.h"
#include "LCD.h"

/*
 * LCD_delay function for LCD
 */

void LCD_delay(uint32_t delay){
	while(delay--);
}

/*
 * 	LCD settings
 */
void LCD_init(){

	XGpio_Initialize(&g_sLCD,GPIO_LCD_ID);
	XGpio_SetDataDirection(&g_sLCD,GPIO_LCD_CH,0x00);	// all pins are output


/*
 * 		LCD initialization Routine
 */

	// wait for 15 ms after power on
	LCD_delay(15*LCD_MILISECOND);

	//
	LCDSend4BitCmd(0x03,LCD_INSTRUCTION_IN);
	LCD_delay(5 * LCD_MILISECOND);

	LCDSend4BitCmd(0x03,LCD_INSTRUCTION_IN);
	LCD_delay(150*LCD_MILISECOND);

	LCDSend4BitCmd(0x03,LCD_INSTRUCTION_IN);
	LCD_delay(150* LCD_MICROSECOND);

	LCDSend4BitCmd(0x02,LCD_INSTRUCTION_IN);
	LCD_delay(40* LCD_MICROSECOND);


/*
 * 		LCD Configurations
 */
	// Function set command 0x28
	LCDSendInstruction(LCD_CMD_SET_FUNCTION|LCD_SET_2_LINE_DISPLAY|LCD_SET_4BIT_INTERFACE|LCD_SET_5X7_DOTS);	// 4 bit interface - 2 line display - 5x7 dots

	// Display off 0x08
	LCDSendInstruction(LCD_CMD_DISPLAY_ON_OFF|LCD_SET_DISPLAY_OFF|LCD_SET_CURSOR_OFF|LCD_SET_BLINK_OFF);

	// Entry mode set	0x06
	LCDSendInstruction(LCD_CMD_ENTRY_MODE_SET|LCD_SET_CURSOR_INCREASE|LCD_SET_DISPLAY_NOT_SHIFTED); // cursor move direction increase - display not shifted

	//Display on	0x0c
	LCDSendInstruction(LCD_CMD_DISPLAY_ON_OFF | LCD_SET_DISPLAY_ON |LCD_SET_CURSOR_OFF|LCD_SET_BLINK_OFF);

	// Clear screen	0x01
	LCDSendInstruction(LCD_CMD_CLEAR_DISPLAY);
	LCD_delay(1640*LCD_MICROSECOND);
}

/*
 * Sends 4 bit command to LCD.
 * param cmd : 		4bit command to send
 * param RS_State : decides whether this is a instruction or data
 * 					for data RS_State must be 1
 * 					for instruction RS_State must be 0
 */
void LCDSend4BitCmd(int cmd, int RS_State){

	reverse(cmd,&cmd);

	XGpio_DiscreteWrite(&g_sLCD,GPIO_LCD_CH,RS_State);
	LCD_delay(LCD_MICROSECOND);
	XGpio_DiscreteWrite(&g_sLCD,GPIO_LCD_CH,LCD_EN|RS_State|(cmd & LCD_DATA_BITS));			//set EN high
	LCD_delay(LCD_MICROSECOND);			// wait
	XGpio_DiscreteWrite(&g_sLCD,GPIO_LCD_CH,RS_State|cmd);		// set EN low
	LCD_delay(100*LCD_MICROSECOND);			// wait

}

/*
 * 	Send instruction to lcd with making RS pin LOW
 */
void LCDSendInstruction(int instruction){
	int HighNibble = instruction >> 4;
	int LowNibble = instruction & 0x0f;

	// send high nibble of instruction
	LCDSend4BitCmd(HighNibble,LCD_INSTRUCTION_IN);
	// send low nibble of instruction
	LCDSend4BitCmd(LowNibble,LCD_INSTRUCTION_IN);

}

/*
 * 	Send data to lcd with making RS pin HIGH
 */
void LCDSendData(int Data){

	int HighNibble = Data >> 4;
	int LowNibble = Data & 0x0f;


	// send high nibble of Data
	LCDSend4BitCmd(HighNibble,LCD_DATA_IN);
	// send low nibble of Data
	LCDSend4BitCmd(LowNibble,LCD_DATA_IN);
}



/*
 * 	Sets the position of the cursor of the lcd
 * 	param line	: Number of the row which can be 1 or 2 for 16x2 LCD display
 * 	param Col	: Number of the column which can take 1-15 for 16x2 LCD display
 */
void LCDSetCursorPosition(int line, int Col)
{
	if(line>2) line = 2;
	if(Col>15) Col = 15 ;

	if(line == 1) line=0x00;
	else if(line == 2) line=0x40;

	LCDSendInstruction(LCD_CMD_SET_DD_RAM_ADDRES|(line+Col));

}


/*
 * 	Writes a character to lcd
 */
void LCDWriteChar(int data){

	LCDSendData(data);

}

/* *  Writes string to the lcd.Cursor position must be set before calling this function
 *  param data : pointer to hold the string addres
 */
void LCDWriteString(u8 *data){

	int count = 0;
	while(data[count] != '\0'){
		LCDWriteChar(data[count]);
		count++;
	}

}


/*
 * Creates a custom character
 * param  address 	: address of the CGRAM. It can take a value 0-7
 * param  data		: pointer for custom character data.It must be an array with length of 8 and
 * 						with 5 bit values.
 *
 */
void LCDCreateCharacter(int address, int *data){

	address = address & 0x07;

	LCDSendInstruction(LCD_CMD_SET_CG_RAM_ADDRESS | address*8);
	int i=0;
	for(i=0;i<8;i++){
		LCDSendData(data[i]);
	}

}

/*
 * 	Scrolls the text on the screen toward left
 * 	Use with LCD_delay for better view
 */
void LCDScrollLeft(){
	LCDSendInstruction(LCD_CMD_SHIFT|LCD_SET_DISPLAY_SHIFT|LCD_SET_LEFT_SHIFT);
}

/*
 * 	Scrolls the text on the screen toward right
 * 	Use with LCD_delay for better view
 */
void LCDScrollRight(){
	LCDSendInstruction(LCD_CMD_SHIFT|LCD_SET_DISPLAY_SHIFT|LCD_SET_RIGHT_SHIFT);
}

/*
 *  Set the cursore mode
 *
 *  param display_on_off : if 1 display is on, if 0 display is off
 *  param cursor_on_off : if 1 cursor is on, if 0 cursor is off
 *  param blink_on_off : if 1 blink is on, if 0 blink is off
 *
 */
void LCDSetDisplayMode(int display_on_off,int cursor_on_off,int blink_on_off  ){

	display_on_off = display_on_off << 2;
	display_on_off &=LCD_SET_DISPLAY_ON;

	cursor_on_off = cursor_on_off << 1;
	cursor_on_off &=LCD_SET_CURSOR_ON;

	blink_on_off &= LCD_SET_BLINK_ON;

	LCDSendInstruction(LCD_CMD_DISPLAY_ON_OFF | display_on_off | cursor_on_off | blink_on_off);
}
/*
 * 	Clear the lcd Sreen
 */
void LCDClearScreen(){

	LCDSendInstruction(LCD_CMD_CLEAR_DISPLAY);
	LCD_delay(LCD_MILISECOND*2);
}


/*
 * 	RESERVE DATA AND INSTRUCTION TO HANDLE
 */

void reverse(int data, int *dataNew){

	int bits[4];

	bits[0] = (data & 0x01) << 6;
	bits[1] = (data & 0x02) << 4;
	bits[2] = (data & 0x04) << 2;
	bits[3] = (data & 0x08) ;

	*dataNew = bits[0] | bits[1] | bits[2] | bits[3] ;
}


