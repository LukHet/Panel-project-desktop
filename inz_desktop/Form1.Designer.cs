namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PortName_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopBits_cb = new System.Windows.Forms.ComboBox();
            this.DataBits_cb = new System.Windows.Forms.ComboBox();
            this.Parity_cb = new System.Windows.Forms.ComboBox();
            this.BaudRate_cb = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.EncoderInput = new System.Windows.Forms.Label();
            this.Encoder2Input = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pot0Data = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Pot1Data = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.KBin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.En0btn = new System.Windows.Forms.Label();
            this.En1btn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Encoder2Bar = new System.Windows.Forms.ProgressBar();
            this.Encoder1Bar = new System.Windows.Forms.ProgressBar();
            this.Potentiometer1Bar = new System.Windows.Forms.ProgressBar();
            this.Potentiometer2Bar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonHash = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortName_cb
            // 
            this.PortName_cb.FormattingEnabled = true;
            this.PortName_cb.Location = new System.Drawing.Point(73, 28);
            this.PortName_cb.Name = "PortName_cb";
            this.PortName_cb.Size = new System.Drawing.Size(121, 21);
            this.PortName_cb.TabIndex = 0;
            this.PortName_cb.DropDown += new System.EventHandler(this.PortName_cb_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopBits_cb);
            this.groupBox1.Controls.Add(this.DataBits_cb);
            this.groupBox1.Controls.Add(this.Parity_cb);
            this.groupBox1.Controls.Add(this.BaudRate_cb);
            this.groupBox1.Controls.Add(this.PortName_cb);
            this.groupBox1.Location = new System.Drawing.Point(41, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stop bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StopBits_cb
            // 
            this.StopBits_cb.FormattingEnabled = true;
            this.StopBits_cb.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBits_cb.Location = new System.Drawing.Point(73, 136);
            this.StopBits_cb.Name = "StopBits_cb";
            this.StopBits_cb.Size = new System.Drawing.Size(121, 21);
            this.StopBits_cb.TabIndex = 4;
            // 
            // DataBits_cb
            // 
            this.DataBits_cb.FormattingEnabled = true;
            this.DataBits_cb.Items.AddRange(new object[] {
            "8",
            "7"});
            this.DataBits_cb.Location = new System.Drawing.Point(73, 109);
            this.DataBits_cb.Name = "DataBits_cb";
            this.DataBits_cb.Size = new System.Drawing.Size(121, 21);
            this.DataBits_cb.TabIndex = 3;
            // 
            // Parity_cb
            // 
            this.Parity_cb.FormattingEnabled = true;
            this.Parity_cb.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Parity_cb.Location = new System.Drawing.Point(73, 82);
            this.Parity_cb.Name = "Parity_cb";
            this.Parity_cb.Size = new System.Drawing.Size(121, 21);
            this.Parity_cb.TabIndex = 2;
            // 
            // BaudRate_cb
            // 
            this.BaudRate_cb.FormattingEnabled = true;
            this.BaudRate_cb.Items.AddRange(new object[] {
            "9600",
            "14400",
            "57600",
            "115200"});
            this.BaudRate_cb.Location = new System.Drawing.Point(73, 55);
            this.BaudRate_cb.Name = "BaudRate_cb";
            this.BaudRate_cb.Size = new System.Drawing.Size(121, 21);
            this.BaudRate_cb.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(293, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(170, 263);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(41, 262);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_btn.TabIndex = 7;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(166, 262);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(41, 301);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_btn.TabIndex = 9;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Disconnect_btn
            // 
            this.Disconnect_btn.Location = new System.Drawing.Point(166, 301);
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_btn.TabIndex = 10;
            this.Disconnect_btn.Text = "Disconnect";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 57600;
            this.serialPort1.PortName = "COM5";
            // 
            // EncoderInput
            // 
            this.EncoderInput.AutoSize = true;
            this.EncoderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncoderInput.Location = new System.Drawing.Point(627, 47);
            this.EncoderInput.Name = "EncoderInput";
            this.EncoderInput.Size = new System.Drawing.Size(60, 25);
            this.EncoderInput.TabIndex = 11;
            this.EncoderInput.Text = "0000";
            // 
            // Encoder2Input
            // 
            this.Encoder2Input.AutoSize = true;
            this.Encoder2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Encoder2Input.Location = new System.Drawing.Point(848, 48);
            this.Encoder2Input.Name = "Encoder2Input";
            this.Encoder2Input.Size = new System.Drawing.Size(60, 25);
            this.Encoder2Input.TabIndex = 12;
            this.Encoder2Input.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(726, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Encoder 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(505, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Encoder 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(531, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pot 1:";
            // 
            // Pot0Data
            // 
            this.Pot0Data.AutoSize = true;
            this.Pot0Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pot0Data.Location = new System.Drawing.Point(596, 193);
            this.Pot0Data.Name = "Pot0Data";
            this.Pot0Data.Size = new System.Drawing.Size(60, 25);
            this.Pot0Data.TabIndex = 15;
            this.Pot0Data.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(765, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pot 2:";
            // 
            // Pot1Data
            // 
            this.Pot1Data.AutoSize = true;
            this.Pot1Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pot1Data.Location = new System.Drawing.Point(828, 193);
            this.Pot1Data.Name = "Pot1Data";
            this.Pot1Data.Size = new System.Drawing.Size(60, 25);
            this.Pot1Data.TabIndex = 18;
            this.Pot1Data.Text = "0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(627, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Keyboard:";
            // 
            // KBin
            // 
            this.KBin.AutoSize = true;
            this.KBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KBin.Location = new System.Drawing.Point(743, 272);
            this.KBin.Name = "KBin";
            this.KBin.Size = new System.Drawing.Size(26, 25);
            this.KBin.TabIndex = 20;
            this.KBin.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(753, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Button:";
            // 
            // En0btn
            // 
            this.En0btn.AutoSize = true;
            this.En0btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.En0btn.Location = new System.Drawing.Point(639, 72);
            this.En0btn.Name = "En0btn";
            this.En0btn.Size = new System.Drawing.Size(24, 25);
            this.En0btn.TabIndex = 23;
            this.En0btn.Text = "0";
            // 
            // En1btn
            // 
            this.En1btn.AutoSize = true;
            this.En1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.En1btn.Location = new System.Drawing.Point(864, 72);
            this.En1btn.Name = "En1btn";
            this.En1btn.Size = new System.Drawing.Size(24, 25);
            this.En1btn.TabIndex = 24;
            this.En1btn.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(289, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Terminal";
            // 
            // Encoder2Bar
            // 
            this.Encoder2Bar.Location = new System.Drawing.Point(731, 130);
            this.Encoder2Bar.Maximum = 1000;
            this.Encoder2Bar.Name = "Encoder2Bar";
            this.Encoder2Bar.Size = new System.Drawing.Size(177, 23);
            this.Encoder2Bar.TabIndex = 26;
            this.Encoder2Bar.Value = 500;
            // 
            // Encoder1Bar
            // 
            this.Encoder1Bar.Location = new System.Drawing.Point(510, 130);
            this.Encoder1Bar.Maximum = 1000;
            this.Encoder1Bar.Name = "Encoder1Bar";
            this.Encoder1Bar.Size = new System.Drawing.Size(177, 23);
            this.Encoder1Bar.TabIndex = 27;
            this.Encoder1Bar.Value = 500;
            // 
            // Potentiometer1Bar
            // 
            this.Potentiometer1Bar.Location = new System.Drawing.Point(510, 229);
            this.Potentiometer1Bar.Maximum = 3000;
            this.Potentiometer1Bar.Name = "Potentiometer1Bar";
            this.Potentiometer1Bar.Size = new System.Drawing.Size(177, 23);
            this.Potentiometer1Bar.TabIndex = 28;
            // 
            // Potentiometer2Bar
            // 
            this.Potentiometer2Bar.Location = new System.Drawing.Point(731, 229);
            this.Potentiometer2Bar.Maximum = 3000;
            this.Potentiometer2Bar.Name = "Potentiometer2Bar";
            this.Potentiometer2Bar.Size = new System.Drawing.Size(177, 23);
            this.Potentiometer2Bar.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(635, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(669, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 33;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(703, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 34;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonA.Enabled = false;
            this.buttonA.Location = new System.Drawing.Point(737, 311);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(28, 28);
            this.buttonA.TabIndex = 35;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonB.Enabled = false;
            this.buttonB.Location = new System.Drawing.Point(737, 345);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(28, 28);
            this.buttonB.TabIndex = 39;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(703, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 28);
            this.button6.TabIndex = 38;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(669, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 37;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(635, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 36;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GrayText;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(703, 379);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 28);
            this.button9.TabIndex = 42;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GrayText;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(669, 379);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 28);
            this.button8.TabIndex = 41;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GrayText;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(635, 379);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 40;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonD.Enabled = false;
            this.buttonD.Location = new System.Drawing.Point(737, 413);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(28, 28);
            this.buttonD.TabIndex = 47;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            // 
            // buttonHash
            // 
            this.buttonHash.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonHash.Enabled = false;
            this.buttonHash.Location = new System.Drawing.Point(703, 413);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(28, 28);
            this.buttonHash.TabIndex = 46;
            this.buttonHash.Text = "#";
            this.buttonHash.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GrayText;
            this.button0.Enabled = false;
            this.button0.Location = new System.Drawing.Point(669, 413);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(28, 28);
            this.button0.TabIndex = 45;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            // 
            // buttonStar
            // 
            this.buttonStar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonStar.Enabled = false;
            this.buttonStar.Location = new System.Drawing.Point(635, 413);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(28, 28);
            this.buttonStar.TabIndex = 44;
            this.buttonStar.Text = "*";
            this.buttonStar.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonC.Enabled = false;
            this.buttonC.Location = new System.Drawing.Point(737, 379);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(28, 28);
            this.buttonC.TabIndex = 48;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(541, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Button:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 464);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Potentiometer2Bar);
            this.Controls.Add(this.Potentiometer1Bar);
            this.Controls.Add(this.Encoder1Bar);
            this.Controls.Add(this.Encoder2Bar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.En1btn);
            this.Controls.Add(this.En0btn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.KBin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Pot1Data);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pot0Data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Encoder2Input);
            this.Controls.Add(this.EncoderInput);
            this.Controls.Add(this.Disconnect_btn);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "PROGRAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortName_cb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StopBits_cb;
        private System.Windows.Forms.ComboBox DataBits_cb;
        private System.Windows.Forms.ComboBox Parity_cb;
        private System.Windows.Forms.ComboBox BaudRate_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button Disconnect_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label EncoderInput;
        private System.Windows.Forms.Label Encoder2Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Pot0Data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Pot1Data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label KBin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label En0btn;
        private System.Windows.Forms.Label En1btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar Encoder2Bar;
        private System.Windows.Forms.ProgressBar Encoder1Bar;
        private System.Windows.Forms.ProgressBar Potentiometer1Bar;
        private System.Windows.Forms.ProgressBar Potentiometer2Bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label label11;
    }
}

