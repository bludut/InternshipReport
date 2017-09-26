namespace lwIP
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
            this.textBox_HostIP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ClearScreen = new System.Windows.Forms.Button();
            this.richTextBox_Received = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_SendLED = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LED3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED0 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LED7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_HostIP
            // 
            this.textBox_HostIP.Location = new System.Drawing.Point(72, 35);
            this.textBox_HostIP.Name = "textBox_HostIP";
            this.textBox_HostIP.Size = new System.Drawing.Size(100, 20);
            this.textBox_HostIP.TabIndex = 1;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(72, 74);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 20);
            this.textBox_Port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_HostIP);
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(193, 74);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Send);
            this.groupBox2.Controls.Add(this.textBox_Send);
            this.groupBox2.Location = new System.Drawing.Point(50, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LCD Send";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(275, 26);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(24, 29);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(224, 20);
            this.textBox_Send.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ClearScreen);
            this.groupBox3.Controls.Add(this.richTextBox_Received);
            this.groupBox3.Location = new System.Drawing.Point(335, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 199);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receive";
            // 
            // button_ClearScreen
            // 
            this.button_ClearScreen.Location = new System.Drawing.Point(24, 161);
            this.button_ClearScreen.Name = "button_ClearScreen";
            this.button_ClearScreen.Size = new System.Drawing.Size(75, 23);
            this.button_ClearScreen.TabIndex = 5;
            this.button_ClearScreen.Text = "Clear";
            this.button_ClearScreen.UseVisualStyleBackColor = true;
            this.button_ClearScreen.Click += new System.EventHandler(this.button_ClearScreen_Click);
            // 
            // richTextBox_Received
            // 
            this.richTextBox_Received.Location = new System.Drawing.Point(24, 19);
            this.richTextBox_Received.Name = "richTextBox_Received";
            this.richTextBox_Received.Size = new System.Drawing.Size(320, 136);
            this.richTextBox_Received.TabIndex = 0;
            this.richTextBox_Received.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_SendLED);
            this.groupBox4.Controls.Add(this.shapeContainer2);
            this.groupBox4.Location = new System.Drawing.Point(50, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 118);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED send";
            // 
            // button_SendLED
            // 
            this.button_SendLED.Location = new System.Drawing.Point(302, 56);
            this.button_SendLED.Name = "button_SendLED";
            this.button_SendLED.Size = new System.Drawing.Size(75, 23);
            this.button_SendLED.TabIndex = 1;
            this.button_SendLED.Text = "Send";
            this.button_SendLED.UseVisualStyleBackColor = true;
            this.button_SendLED.Click += new System.EventHandler(this.button_SendLED_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LED3,
            this.LED2,
            this.LED0,
            this.LED1,
            this.LED5,
            this.LED4,
            this.LED6,
            this.LED7});
            this.shapeContainer2.Size = new System.Drawing.Size(425, 99);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // LED3
            // 
            this.LED3.BackColor = System.Drawing.Color.Black;
            this.LED3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED3.Location = new System.Drawing.Point(161, 39);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(22, 23);
            this.LED3.Click += new System.EventHandler(this.oval_LED3_Click);
            // 
            // LED2
            // 
            this.LED2.BackColor = System.Drawing.Color.Black;
            this.LED2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED2.Location = new System.Drawing.Point(192, 39);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(22, 23);
            this.LED2.Click += new System.EventHandler(this.oval_LED2_Click);
            // 
            // LED0
            // 
            this.LED0.BackColor = System.Drawing.Color.Black;
            this.LED0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED0.Location = new System.Drawing.Point(254, 39);
            this.LED0.Name = "LED0";
            this.LED0.Size = new System.Drawing.Size(22, 23);
            this.LED0.Click += new System.EventHandler(this.oval_LED0_Click);
            // 
            // LED1
            // 
            this.LED1.BackColor = System.Drawing.Color.Black;
            this.LED1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED1.Location = new System.Drawing.Point(223, 39);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(22, 23);
            this.LED1.Click += new System.EventHandler(this.oval_LED1_Click);
            // 
            // LED5
            // 
            this.LED5.BackColor = System.Drawing.Color.Black;
            this.LED5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED5.Location = new System.Drawing.Point(99, 39);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(22, 23);
            this.LED5.Click += new System.EventHandler(this.oval_LED5_Click);
            // 
            // LED4
            // 
            this.LED4.BackColor = System.Drawing.Color.Black;
            this.LED4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED4.Location = new System.Drawing.Point(130, 39);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(22, 23);
            this.LED4.Click += new System.EventHandler(this.oval_LED4_Click);
            // 
            // LED6
            // 
            this.LED6.BackColor = System.Drawing.Color.Black;
            this.LED6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED6.Location = new System.Drawing.Point(68, 39);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(22, 23);
            this.LED6.Click += new System.EventHandler(this.oval_LED6_Click);
            // 
            // LED7
            // 
            this.LED7.BackColor = System.Drawing.Color.Black;
            this.LED7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.LED7.Location = new System.Drawing.Point(37, 39);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(22, 23);
            this.LED7.Click += new System.EventHandler(this.oval_LED7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_HostIP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_ClearScreen;
        private System.Windows.Forms.RichTextBox richTextBox_Received;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_SendLED;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED0;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED5;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape LED7;
    }
}

