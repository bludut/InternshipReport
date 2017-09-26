using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace UART_GUI
{
    public partial class Form1 : Form
    {
        /*
         *  Global variables for Serial Port 
         * */
        string g_portName;
        int g_baudRate;
        int g_dataBits;
        Parity g_parity; 
        StopBits g_stopBits;
        SerialPort serialPort = new SerialPort();

        /*
         * Global Variables for LED
         * */
        int[] g_LED = {0,0,0,0,0,0,0,0};

        /*
         *  Constants for commands
         * */
        const int LCD_COMMAND = '#';
        const int LED_COMMAND = '*';
        const int DIP_COMMAND = '"';

        public Form1()
        {
            InitializeComponent();
         
          // Check the valid Com ports
            string[] PortNames;
            PortNames = SerialPort.GetPortNames();
            int UpperBound = PortNames.GetUpperBound(0);

            for (int i = UpperBound; i >= 0; i--)
            {
                Combo_COMPort.Items.Add(PortNames[i]);
            }

            // İnitial values for comboboxes

            Combo_COMPort.SelectedIndex = 0;
            Combo_BaudRate.SelectedIndex = 0;
            Combo_DataBits.SelectedIndex = 0;
            Combo_StopBits.SelectedIndex = 0;
            Combo_Parity.SelectedIndex = 0;
      
        }

        private void Combo_COMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_portName = Combo_COMPort.Text;
                        
        }

        private void Combo_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_baudRate = Convert.ToInt32(Combo_BaudRate.Text);
        }

        private void Combo_DataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_dataBits = Convert.ToInt32(Combo_DataBits.Text);
        }

        private void Combo_StopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Stop_Bits;
            Stop_Bits = Combo_StopBits.Text;
            switch (Stop_Bits)
            {
                case "None" :
                    g_stopBits = StopBits.None;
                    break;
                case "1":
                    g_stopBits = StopBits.One;
                    break;
                case "2":
                    g_stopBits = StopBits.Two;
                    break;
            }

        }

        private void Combo_Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
           string String_parity;
            String_parity = Combo_Parity.Text;
            switch (String_parity)
            {
                case "None":
                    g_parity = Parity.None;
                    break;
                case "Even":
                    g_parity = Parity.Even;
                    break;
                case "Odd":
                    g_parity = Parity.Odd;
                    break;
            }

        }

        private void Button_OpenClose_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = g_portName;
                serialPort.BaudRate = g_baudRate;
                serialPort.StopBits = g_stopBits;
                serialPort.DataBits = g_dataBits;
                serialPort.Parity = g_parity;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(ReceivedEventHandler);

            }

            if (Button_OpenClose.Text == "Open")
            {
                Button_OpenClose.Text = "Close";

                serialPort.Open();
                
            }
            else if (Button_OpenClose.Text == "Close")
            {
                Button_OpenClose.Text = "Open";

                serialPort.Close();

            }

            if (serialPort.IsOpen)
            {
                Label_COMPortStat.Text = Combo_COMPort.Text + " is Opened";
            }
            else
            {
                Label_COMPortStat.Text = Combo_COMPort.Text + " is Closed";
            }

        }

        private void Text_Send_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            string TextToSend;
            int NumOfBytesToSend;

            byte[] buffer = new byte[] { 0 ,0 };

            TextToSend = Text_Send.Text;
            NumOfBytesToSend = TextToSend.Length + 1;

            buffer[0] = (byte)NumOfBytesToSend;
            buffer[1] = (byte)LCD_COMMAND;

            /*
             *      Firts send NumOfBytesToSend then TextToSend
             */
            if (serialPort.IsOpen)
            {
                serialPort.Write(buffer, 0, 2);
                serialPort.Write(TextToSend);
            }
            else {
                Text_received.AppendText("Open the COM port to send data\n");
            }
            
            // end of sending


        }

//  Received Handler
        private void ReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string indata;
            indata = serialPort.ReadExisting();

            BeginInvoke(new EventHandler(delegate
            {
               try{ if (indata[0] == '#')
                {
                    int DIP_state;
                    DIP_state = (indata[1]& 0x0f) * 100 + (indata[2]& 0x0f) * 10 + (indata[3]& 0x0f);
                    Set_DIP_Switches_Status(DIP_state);
                }}catch(Exception){}

                Text_received.AppendText(indata);
                Text_received.ScrollToCaret();
                
            }));

        }


        private void Button_ReceivedClean_Click(object sender, EventArgs e)
        {
         
            Text_received.Clear();

        }

//  LED Click methods
        private void LED0_Click(object sender, EventArgs e)
        {
            if (LED0.BackColor == Color.Black)
            {
                LED0.BackColor = Color.Green;
                g_LED[0] = 1;
            }
            else if (LED0.BackColor == Color.Green)
            {
                LED0.BackColor = Color.Black;
                g_LED[0] = 0;
            }

        }

        private void LED1_Click(object sender, EventArgs e)
        {
            if (LED1.BackColor == Color.Black)
            {
                LED1.BackColor = Color.Green;
                g_LED[1] = 2;
            }
            else if (LED1.BackColor == Color.Green)
            {
                LED1.BackColor = Color.Black;
                g_LED[1] = 0;
            }
            
        }

        private void LED2_Click(object sender, EventArgs e)
        {
            if (LED2.BackColor == Color.Black)
            {
                LED2.BackColor = Color.Green;
                g_LED[2] = 4;
            }
            else if (LED2.BackColor == Color.Green)
            {
                LED2.BackColor = Color.Black;
                g_LED[2] = 0;
            }
        }

        private void LED3_Click(object sender, EventArgs e)
        {
            if (LED3.BackColor == Color.Black)
            {
                LED3.BackColor = Color.Green;
                g_LED[3] = 8;
            }
            else if (LED3.BackColor == Color.Green)
            {
                LED3.BackColor = Color.Black;
                g_LED[3] = 0;
            }

        }

        private void LED4_Click(object sender, EventArgs e)
        {
            if (LED4.BackColor == Color.Black)
            {
                LED4.BackColor = Color.Green;
                g_LED[4] = 16;
            }
            else if (LED4.BackColor == Color.Green)
            {
                LED4.BackColor = Color.Black;
                g_LED[4] = 0;
            }

        }

        private void LED5_Click(object sender, EventArgs e)
        {
            if (LED5.BackColor == Color.Black)
            {
                LED5.BackColor = Color.Green;
                g_LED[5] = 32;
            }
            else if (LED5.BackColor == Color.Green)
            {
                LED5.BackColor = Color.Black;
                g_LED[5] = 0;
            }

        }

        private void LED6_Click(object sender, EventArgs e)
        {
            if (LED6.BackColor == Color.Black)
            {
                LED6.BackColor = Color.Green;
                g_LED[6] = 64;
            }
            else if (LED6.BackColor == Color.Green)
            {
                LED6.BackColor = Color.Black;
                g_LED[6] = 0;
            }

        }

        private void LED7_Click(object sender, EventArgs e)
        {
            if (LED7.BackColor == Color.Black)
            {
                LED7.BackColor = Color.Green;
                g_LED[7] = 128;
            }
            else if (LED7.BackColor == Color.Green)
            {
                LED7.BackColor = Color.Black;
                g_LED[7] = 0;
            }

        }

//  Functions for DIP Drawing
        private void Set_DIP_Switches_Status(int DIP_Val)
        {
            Control_DIP_Bit(DIP_Val, 1, rectangle_DIP_Back0, rectangle_DIP0);
            Control_DIP_Bit(DIP_Val, 2, rectangle_DIP_Back1, rectangle_DIP1);
            Control_DIP_Bit(DIP_Val, 4, rectangle_DIP_Back2, rectangle_DIP2);
            Control_DIP_Bit(DIP_Val, 8, rectangle_DIP_Back3, rectangle_DIP3);
            Control_DIP_Bit(DIP_Val, 16, rectangle_DIP_Back4, rectangle_DIP4);
            Control_DIP_Bit(DIP_Val, 32, rectangle_DIP_Back5, rectangle_DIP5);
            Control_DIP_Bit(DIP_Val, 64, rectangle_DIP_Back6, rectangle_DIP6);
            Control_DIP_Bit(DIP_Val, 128, rectangle_DIP_Back7, rectangle_DIP7);
        }

        private void Control_DIP_Bit(int DIP_Val,int bitNum, Microsoft.VisualBasic.PowerPacks.RectangleShape Rect_back, Microsoft.VisualBasic.PowerPacks.RectangleShape Rect_small)
        {
            if ((DIP_Val & bitNum) == 0)
            {
                Set_DIP_UP(Rect_back, Rect_small);
            }
            else
            {
                Set_DIP_Down(Rect_back, Rect_small);
            }
        }

        private void Set_DIP_UP(Microsoft.VisualBasic.PowerPacks.RectangleShape Rect_back, Microsoft.VisualBasic.PowerPacks.RectangleShape Rect_small)
        {
            Rect_small.Location = Rect_back.Location;

        }
        private void Set_DIP_Down(Microsoft.VisualBasic.PowerPacks.RectangleShape Rect_back, Microsoft.VisualBasic.PowerPacks.RectangleShape Rect_small)
        {
            System.Drawing.Size Offset = new System.Drawing.Size();

            Offset.Width = 0;
            Offset.Height = Rect_back.Size.Height - Rect_small.Height;

            Rect_small.Location = Rect_back.Location + Offset;

        }

//  End of DIP Drawing funcions

        private void button_LEDWrite_Click(object sender, EventArgs e)
        {
            int LED_state;
            LED_state = g_LED.Sum();

            byte[] buffer = new byte[] { 2 , 0 , 0};

            buffer[1] = (byte)LED_COMMAND;
            buffer[2] = (byte)LED_state;

            /*
             *      Firts send NumOfBytesToSend then TextToSend
             */
            if (serialPort.IsOpen)
            {
                serialPort.Write(buffer, 0, 3);
            }
            else
            {
                Text_received.AppendText("Open the COM port to send data\n");
            }

            // end of sending

        }


    }
}
