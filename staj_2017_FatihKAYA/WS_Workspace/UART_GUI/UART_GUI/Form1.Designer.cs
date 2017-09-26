namespace UART_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.COMPortsSettings = new System.Windows.Forms.GroupBox();
            this.Button_OpenClose = new System.Windows.Forms.Button();
            this.Combo_Parity = new System.Windows.Forms.ComboBox();
            this.Combo_StopBits = new System.Windows.Forms.ComboBox();
            this.Combo_DataBits = new System.Windows.Forms.ComboBox();
            this.Combo_BaudRate = new System.Windows.Forms.ComboBox();
            this.Combo_COMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_COMPortStat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Send = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Text_received = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_ReceivedClean = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_LEDWrite = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangle_DIP2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP0 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP7 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back0 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangle_DIP_Back7 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.LED3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED0 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.COMPortsSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPortsSettings
            // 
            this.COMPortsSettings.Controls.Add(this.Button_OpenClose);
            this.COMPortsSettings.Controls.Add(this.Combo_Parity);
            this.COMPortsSettings.Controls.Add(this.Combo_StopBits);
            this.COMPortsSettings.Controls.Add(this.Combo_DataBits);
            this.COMPortsSettings.Controls.Add(this.Combo_BaudRate);
            this.COMPortsSettings.Controls.Add(this.Combo_COMPort);
            this.COMPortsSettings.Controls.Add(this.label1);
            this.COMPortsSettings.Controls.Add(this.Label_COMPortStat);
            this.COMPortsSettings.Controls.Add(this.label6);
            this.COMPortsSettings.Controls.Add(this.label4);
            this.COMPortsSettings.Controls.Add(this.label5);
            this.COMPortsSettings.Controls.Add(this.label3);
            this.COMPortsSettings.Controls.Add(this.label2);
            this.COMPortsSettings.Location = new System.Drawing.Point(32, 21);
            this.COMPortsSettings.Name = "COMPortsSettings";
            this.COMPortsSettings.Size = new System.Drawing.Size(246, 297);
            this.COMPortsSettings.TabIndex = 0;
            this.COMPortsSettings.TabStop = false;
            this.COMPortsSettings.Text = "COM Port Settings";
            // 
            // Button_OpenClose
            // 
            this.Button_OpenClose.Location = new System.Drawing.Point(103, 217);
            this.Button_OpenClose.Name = "Button_OpenClose";
            this.Button_OpenClose.Size = new System.Drawing.Size(75, 23);
            this.Button_OpenClose.TabIndex = 2;
            this.Button_OpenClose.Text = "Open";
            this.Button_OpenClose.UseVisualStyleBackColor = true;
            this.Button_OpenClose.Click += new System.EventHandler(this.Button_OpenClose_Click);
            // 
            // Combo_Parity
            // 
            this.Combo_Parity.FormattingEnabled = true;
            this.Combo_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.Combo_Parity.Location = new System.Drawing.Point(103, 180);
            this.Combo_Parity.Name = "Combo_Parity";
            this.Combo_Parity.Size = new System.Drawing.Size(121, 21);
            this.Combo_Parity.TabIndex = 1;
            this.Combo_Parity.SelectedIndexChanged += new System.EventHandler(this.Combo_Parity_SelectedIndexChanged);
            // 
            // Combo_StopBits
            // 
            this.Combo_StopBits.FormattingEnabled = true;
            this.Combo_StopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "None"});
            this.Combo_StopBits.Location = new System.Drawing.Point(103, 143);
            this.Combo_StopBits.Name = "Combo_StopBits";
            this.Combo_StopBits.Size = new System.Drawing.Size(121, 21);
            this.Combo_StopBits.TabIndex = 1;
            this.Combo_StopBits.SelectedIndexChanged += new System.EventHandler(this.Combo_StopBits_SelectedIndexChanged);
            // 
            // Combo_DataBits
            // 
            this.Combo_DataBits.FormattingEnabled = true;
            this.Combo_DataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.Combo_DataBits.Location = new System.Drawing.Point(103, 112);
            this.Combo_DataBits.Name = "Combo_DataBits";
            this.Combo_DataBits.Size = new System.Drawing.Size(121, 21);
            this.Combo_DataBits.TabIndex = 1;
            this.Combo_DataBits.SelectedIndexChanged += new System.EventHandler(this.Combo_DataBits_SelectedIndexChanged);
            // 
            // Combo_BaudRate
            // 
            this.Combo_BaudRate.FormattingEnabled = true;
            this.Combo_BaudRate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.Combo_BaudRate.Location = new System.Drawing.Point(103, 75);
            this.Combo_BaudRate.Name = "Combo_BaudRate";
            this.Combo_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.Combo_BaudRate.TabIndex = 1;
            this.Combo_BaudRate.SelectedIndexChanged += new System.EventHandler(this.Combo_BaudRate_SelectedIndexChanged);
            // 
            // Combo_COMPort
            // 
            this.Combo_COMPort.FormattingEnabled = true;
            this.Combo_COMPort.Location = new System.Drawing.Point(103, 35);
            this.Combo_COMPort.Name = "Combo_COMPort";
            this.Combo_COMPort.Size = new System.Drawing.Size(121, 21);
            this.Combo_COMPort.TabIndex = 1;
            this.Combo_COMPort.SelectedIndexChanged += new System.EventHandler(this.Combo_COMPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "COM Port ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_COMPortStat
            // 
            this.Label_COMPortStat.AutoSize = true;
            this.Label_COMPortStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_COMPortStat.Location = new System.Drawing.Point(100, 260);
            this.Label_COMPortStat.Name = "Label_COMPortStat";
            this.Label_COMPortStat.Size = new System.Drawing.Size(16, 13);
            this.Label_COMPortStat.TabIndex = 1;
            this.Label_COMPortStat.Tag = "";
            this.Label_COMPortStat.Text = "...";
            this.Label_COMPortStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Tag = "";
            this.label6.Text = "Port State : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Tag = "";
            this.label4.Text = "Parity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 1;
            this.label5.Tag = "";
            this.label5.Text = "Data Bits";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "Stop Bit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Tag = "";
            this.label2.Text = "BaudRate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text_Send
            // 
            this.Text_Send.Location = new System.Drawing.Point(245, 72);
            this.Text_Send.Name = "Text_Send";
            this.Text_Send.Size = new System.Drawing.Size(203, 20);
            this.Text_Send.TabIndex = 1;
            this.Text_Send.TextChanged += new System.EventHandler(this.Text_Send_TextChanged);
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(507, 70);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Button_Send.TabIndex = 2;
            this.Button_Send.Text = "Write";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Text_received
            // 
            this.Text_received.Location = new System.Drawing.Point(15, 24);
            this.Text_received.Name = "Text_received";
            this.Text_received.Size = new System.Drawing.Size(348, 236);
            this.Text_received.TabIndex = 3;
            this.Text_received.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_ReceivedClean);
            this.groupBox1.Controls.Add(this.Text_received);
            this.groupBox1.Location = new System.Drawing.Point(301, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 297);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Data";
            // 
            // Button_ReceivedClean
            // 
            this.Button_ReceivedClean.Location = new System.Drawing.Point(10, 266);
            this.Button_ReceivedClean.Name = "Button_ReceivedClean";
            this.Button_ReceivedClean.Size = new System.Drawing.Size(75, 23);
            this.Button_ReceivedClean.TabIndex = 3;
            this.Button_ReceivedClean.Text = "Clear";
            this.Button_ReceivedClean.UseVisualStyleBackColor = true;
            this.Button_ReceivedClean.Click += new System.EventHandler(this.Button_ReceivedClean_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_LEDWrite);
            this.groupBox2.Controls.Add(this.Button_Send);
            this.groupBox2.Controls.Add(this.Text_Send);
            this.groupBox2.Controls.Add(this.shapeContainer1);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox2.Location = new System.Drawing.Point(32, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 330);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // button_LEDWrite
            // 
            this.button_LEDWrite.Location = new System.Drawing.Point(507, 147);
            this.button_LEDWrite.Name = "button_LEDWrite";
            this.button_LEDWrite.Size = new System.Drawing.Size(75, 23);
            this.button_LEDWrite.TabIndex = 5;
            this.button_LEDWrite.Text = "Write";
            this.button_LEDWrite.UseVisualStyleBackColor = true;
            this.button_LEDWrite.Click += new System.EventHandler(this.button_LEDWrite_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangle_DIP2,
            this.rectangle_DIP0,
            this.rectangle_DIP1,
            this.rectangle_DIP3,
            this.rectangle_DIP4,
            this.rectangle_DIP5,
            this.rectangle_DIP6,
            this.rectangle_DIP7,
            this.rectangle_DIP_Back3,
            this.rectangle_DIP_Back2,
            this.rectangle_DIP_Back0,
            this.rectangle_DIP_Back1,
            this.rectangle_DIP_Back5,
            this.rectangle_DIP_Back4,
            this.rectangle_DIP_Back6,
            this.rectangle_DIP_Back7,
            this.rectangleShape1,
            this.LED3,
            this.LED2,
            this.LED0,
            this.LED1,
            this.LED4,
            this.LED5,
            this.LED6,
            this.LED7});
            this.shapeContainer1.Size = new System.Drawing.Size(652, 311);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangle_DIP2
            // 
            this.rectangle_DIP2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP2.Location = new System.Drawing.Point(397, 275);
            this.rectangle_DIP2.Name = "rectangle_DIP2";
            this.rectangle_DIP2.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP0
            // 
            this.rectangle_DIP0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP0.Location = new System.Drawing.Point(455, 275);
            this.rectangle_DIP0.Name = "rectangle_DIP0";
            this.rectangle_DIP0.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP1
            // 
            this.rectangle_DIP1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP1.Location = new System.Drawing.Point(426, 275);
            this.rectangle_DIP1.Name = "rectangle_DIP1";
            this.rectangle_DIP1.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP3
            // 
            this.rectangle_DIP3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP3.Location = new System.Drawing.Point(368, 275);
            this.rectangle_DIP3.Name = "rectangle_DIP3";
            this.rectangle_DIP3.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP4
            // 
            this.rectangle_DIP4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP4.Location = new System.Drawing.Point(339, 275);
            this.rectangle_DIP4.Name = "rectangle_DIP4";
            this.rectangle_DIP4.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP5
            // 
            this.rectangle_DIP5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP5.Location = new System.Drawing.Point(310, 275);
            this.rectangle_DIP5.Name = "rectangle_DIP5";
            this.rectangle_DIP5.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP6
            // 
            this.rectangle_DIP6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP6.Location = new System.Drawing.Point(281, 275);
            this.rectangle_DIP6.Name = "rectangle_DIP6";
            this.rectangle_DIP6.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP7
            // 
            this.rectangle_DIP7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle_DIP7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP7.Location = new System.Drawing.Point(252, 275);
            this.rectangle_DIP7.Name = "rectangle_DIP7";
            this.rectangle_DIP7.Size = new System.Drawing.Size(15, 12);
            // 
            // rectangle_DIP_Back3
            // 
            this.rectangle_DIP_Back3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back3.Location = new System.Drawing.Point(368, 244);
            this.rectangle_DIP_Back3.Name = "rectangle_DIP_Back3";
            this.rectangle_DIP_Back3.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back2
            // 
            this.rectangle_DIP_Back2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back2.Location = new System.Drawing.Point(397, 244);
            this.rectangle_DIP_Back2.Name = "rectangle_DIP_Back2";
            this.rectangle_DIP_Back2.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back0
            // 
            this.rectangle_DIP_Back0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back0.Location = new System.Drawing.Point(455, 244);
            this.rectangle_DIP_Back0.Name = "rectangle_DIP_Back0";
            this.rectangle_DIP_Back0.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back1
            // 
            this.rectangle_DIP_Back1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back1.Location = new System.Drawing.Point(426, 244);
            this.rectangle_DIP_Back1.Name = "rectangle_DIP_Back1";
            this.rectangle_DIP_Back1.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back5
            // 
            this.rectangle_DIP_Back5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back5.Location = new System.Drawing.Point(310, 244);
            this.rectangle_DIP_Back5.Name = "rectangle_DIP_Back5";
            this.rectangle_DIP_Back5.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back4
            // 
            this.rectangle_DIP_Back4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back4.Location = new System.Drawing.Point(339, 244);
            this.rectangle_DIP_Back4.Name = "rectangle_DIP_Back4";
            this.rectangle_DIP_Back4.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back6
            // 
            this.rectangle_DIP_Back6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back6.Location = new System.Drawing.Point(281, 244);
            this.rectangle_DIP_Back6.Name = "rectangle_DIP_Back6";
            this.rectangle_DIP_Back6.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangle_DIP_Back7
            // 
            this.rectangle_DIP_Back7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangle_DIP_Back7.Location = new System.Drawing.Point(252, 244);
            this.rectangle_DIP_Back7.Name = "rectangle_DIP_Back7";
            this.rectangle_DIP_Back7.Size = new System.Drawing.Size(16, 43);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(238, 235);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(249, 64);
            // 
            // LED3
            // 
            this.LED3.BackColor = System.Drawing.Color.Black;
            this.LED3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED3.Location = new System.Drawing.Point(347, 137);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(18, 19);
            this.LED3.Click += new System.EventHandler(this.LED3_Click);
            // 
            // LED2
            // 
            this.LED2.BackColor = System.Drawing.Color.Black;
            this.LED2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED2.Location = new System.Drawing.Point(372, 137);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(18, 19);
            this.LED2.Click += new System.EventHandler(this.LED2_Click);
            // 
            // LED0
            // 
            this.LED0.BackColor = System.Drawing.Color.Black;
            this.LED0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED0.FillGradientColor = System.Drawing.Color.Black;
            this.LED0.Location = new System.Drawing.Point(422, 137);
            this.LED0.Name = "LED0";
            this.LED0.Size = new System.Drawing.Size(18, 19);
            this.LED0.Click += new System.EventHandler(this.LED0_Click);
            // 
            // LED1
            // 
            this.LED1.BackColor = System.Drawing.Color.Black;
            this.LED1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED1.Location = new System.Drawing.Point(397, 137);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(18, 19);
            this.LED1.Click += new System.EventHandler(this.LED1_Click);
            // 
            // LED4
            // 
            this.LED4.BackColor = System.Drawing.Color.Black;
            this.LED4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED4.Location = new System.Drawing.Point(322, 137);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(18, 19);
            this.LED4.Click += new System.EventHandler(this.LED4_Click);
            // 
            // LED5
            // 
            this.LED5.BackColor = System.Drawing.Color.Black;
            this.LED5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED5.Location = new System.Drawing.Point(297, 137);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(18, 19);
            this.LED5.Click += new System.EventHandler(this.LED5_Click);
            // 
            // LED6
            // 
            this.LED6.BackColor = System.Drawing.Color.Black;
            this.LED6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED6.Location = new System.Drawing.Point(272, 137);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(18, 19);
            this.LED6.Click += new System.EventHandler(this.LED6_Click);
            // 
            // LED7
            // 
            this.LED7.BackColor = System.Drawing.Color.Black;
            this.LED7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED7.Location = new System.Drawing.Point(247, 137);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(18, 19);
            this.LED7.Click += new System.EventHandler(this.LED7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "LCD Write :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(96, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "LED Write : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(45, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "DIP Switches Read :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.COMPortsSettings);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "VC707 Control Panel";
            this.COMPortsSettings.ResumeLayout(false);
            this.COMPortsSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Parity;
        private System.Windows.Forms.ComboBox Combo_StopBits;
        private System.Windows.Forms.ComboBox Combo_DataBits;
        private System.Windows.Forms.ComboBox Combo_BaudRate;
        private System.Windows.Forms.ComboBox Combo_COMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Send;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Button Button_OpenClose;
        private System.Windows.Forms.Label Label_COMPortStat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox COMPortsSettings;
        private System.Windows.Forms.RichTextBox Text_received;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_ReceivedClean;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED0;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED5;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back0;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP_Back7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP0;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangle_DIP6;
        private System.Windows.Forms.Button button_LEDWrite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

