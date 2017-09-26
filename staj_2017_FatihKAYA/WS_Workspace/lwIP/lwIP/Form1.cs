using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace lwIP
{
    public partial class Form1 : Form
    {
       
      /*
      * Global Variables for LED
      * */
       int[] g_LED = { 0, 0, 0, 0, 0, 0, 0, 0 };
        /*
         *  Constants for Commands
         * */
        const char LCD_COMMAND = '#';
        const char LED_COMMAND = '+';


        TcpClient clientSocket;
        public Form1()
        {
       
            InitializeComponent();
            textBox_HostIP.Text = "192.168.1.10";
            textBox_Port.Text = "7";
            ////////////////////////////////////////////////
           

          
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            string IPAdd;
            string PortNum;

            IPAdd = textBox_HostIP.Text;
            PortNum = textBox_Port.Text;
            ////////////////////////////////////////////////

            if (button_Connect.Text == "Connect")
            {
                button_Connect.Text = "Disconnect";
             
                try
                {
                    clientSocket = new TcpClient();
                    clientSocket.Connect(IPAddress.Parse(IPAdd), int.Parse(PortNum));
                }
                catch (SocketException exp)
                {
                    richTextBox_Received.AppendText(Convert.ToString(exp));
                }
            }
            else if (button_Connect.Text == "Disconnect")
            {
                button_Connect.Text = "Connect";
                clientSocket.Close();

            }

    

        }

   
        private void button_Send_Click(object sender, EventArgs e)
        {

         
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = { };

                outStream = Encoding.ASCII.GetBytes(LCD_COMMAND + textBox_Send.Text + '$');
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[(int)clientSocket.ReceiveBufferSize];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returnData = Encoding.ASCII.GetString(inStream);
                richTextBox_Received.AppendText(returnData);
  

        }

        private void button_ClearScreen_Click(object sender, EventArgs e)
        {
            richTextBox_Received.Clear();

        }

//  LED Click methods
        private void oval_LED0_Click(object sender, EventArgs e)
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

        private void oval_LED1_Click(object sender, EventArgs e)
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

        private void oval_LED2_Click(object sender, EventArgs e)
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

        private void oval_LED3_Click(object sender, EventArgs e)
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

        private void oval_LED4_Click(object sender, EventArgs e)
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

        private void oval_LED5_Click(object sender, EventArgs e)
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

        private void oval_LED6_Click(object sender, EventArgs e)
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

        private void oval_LED7_Click(object sender, EventArgs e)
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

        private void button_SendLED_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream ={0,0,0 };
            int LEDState;
            LEDState = g_LED.Sum() ;

            /*
             */
            outStream[0] = Convert.ToByte(LED_COMMAND);
            outStream[1] = Convert.ToByte(LEDState);
            outStream[2] = Convert.ToByte('$');

            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[(int)clientSocket.ReceiveBufferSize];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);

            
            string returnData = Encoding.ASCII.GetString(inStream);

            richTextBox_Received.AppendText(returnData[0] + Convert.ToString(inStream[1]) + returnData[2]);

        }
    
    
    
    
    
    
    }
}
