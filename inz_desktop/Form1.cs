using System;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Thread ReadSerialDataThread;
        public string inData;

        struct encoder 
        {
            public int counter;
            public bool isPressed;
            public bool isUpdated;
        }

        struct potentiometer
        {
            public int value;
            public int prevValue;
            public bool isChanged;
        }

        struct button
        {
            public char myChar;
            public char state;
        };

        potentiometer[] potentiometers = {new potentiometer(),
                                          new potentiometer()
                                        /*new potentiometer()*/};
        button buttons = new button();
        encoder[] encoders = {new encoder(),
                              new encoder()};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadConfig();
            Disconnect_btn.Enabled = false;
            Save_btn.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void loadConfig()
        {
            PortName_cb.Text = ConfigurationManager.AppSettings["name"];
            BaudRate_cb.Text = ConfigurationManager.AppSettings["baudRate"];
            Parity_cb.Text = ConfigurationManager.AppSettings["comparity"];
            DataBits_cb.Text = ConfigurationManager.AppSettings["dataBits"];
            StopBits_cb.Text = ConfigurationManager.AppSettings["stopBits"];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Disconnect_btn.Enabled = false;
            Connect_btn.Enabled = false;
            Edit_btn.Enabled = false;
            Save_btn.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void PortName_cb_DropDown(object sender, EventArgs e)
        {
            string[] comports = SerialPort.GetPortNames();
            foreach (var comport in comports)
            {
                PortName_cb.Items.Add(comport);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("name");
                config.AppSettings.Settings.Remove("baudRate");
                config.AppSettings.Settings.Remove("comparity");
                config.AppSettings.Settings.Remove("dataBits");
                config.AppSettings.Settings.Remove("stopBits");

                config.AppSettings.Settings.Add("name", PortName_cb.Text);
                config.AppSettings.Settings.Add("baudRate", BaudRate_cb.Text);
                config.AppSettings.Settings.Add("comparity", Parity_cb.Text);
                config.AppSettings.Settings.Add("dataBits", DataBits_cb.Text);
                config.AppSettings.Settings.Add("stopBits", StopBits_cb.Text);

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                Connect_btn.Enabled = true;
                Edit_btn.Enabled = true;
                Save_btn.Enabled = true;
                groupBox1.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = PortName_cb.Text;
            serialPort1.BaudRate = int.Parse(BaudRate_cb.Text);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Parity_cb.Text);
            serialPort1.DataBits = int.Parse(DataBits_cb.Text);
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBits_cb.Text);

            serialPort1.Open();

            if(serialPort1.IsOpen)
            {
                ReadSerialData();
                Connect_btn.Enabled = false;
                Disconnect_btn.Enabled = true; ;
            }
        }

        private void ReadSerialData()
        {
            try
            {
                ReadSerialDataThread = new Thread(ReadSerial);
                ReadSerialDataThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void ReadSerial()
        {
            while(serialPort1.IsOpen)
            {
                inData = serialPort1.ReadExisting();
                if (inData != string.Empty)
                {
                    ShowRealData(inData);
                }
                Thread.Sleep(100);
            }
        }

        public delegate void ShowSerialDataDelegate(string r);

        private void ShowRealData(string s)
        {
            if (richTextBox1.InvokeRequired)
            {
                ShowSerialDataDelegate SSDD = ShowRealData;
                Invoke(SSDD, s);
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine + s);
                richTextBox1.ScrollToCaret();
                if (s.Length != 0)
                {
                    if (s.Substring(0, 5) == "<EN1:")
                    {
                        encoders[0].isUpdated = true;
                        encoders[0].counter = int.Parse(s.Substring(8, 3));
                        Encoder2Input.Text = Convert.ToString(encoders[0].counter);
                        Encoder2Bar.Value = encoders[0].counter;
                        Encoder2Bar.Update();
                        encoders[0].isUpdated = false;
                    }
                    if (s.Substring(0, 5) == "<EN0:")
                    {
                        encoders[1].isUpdated = true;
                        encoders[1].counter = int.Parse(s.Substring(8, 3));
                        EncoderInput.Text = Convert.ToString(encoders[1].counter);
                        Encoder1Bar.Value = encoders[1].counter;
                        Encoder1Bar.Update();
                        encoders[1].isUpdated = false;
                    }
                    if (s.Substring(0, 6) == "<POT0:")
                    {
                        potentiometers[0].isChanged = true;
                        potentiometers[0].value = int.Parse(s.Substring(8, 4));
                        Pot0Data.Text = Convert.ToString(potentiometers[0].value);
                        Potentiometer1Bar.Value = potentiometers[0].value;
                        Potentiometer1Bar.Update();
                        potentiometers[0].isChanged = false;
                    }
                    if (s.Substring(0, 6) == "<POT1:")
                    {
                        potentiometers[1].isChanged = true;
                        potentiometers[1].value = int.Parse(s.Substring(8, 4));
                        Pot1Data.Text = Convert.ToString(potentiometers[1].value);
                        Potentiometer2Bar.Value = potentiometers[1].value;
                        Potentiometer2Bar.Update();
                        potentiometers[1].isChanged = false;
                    }
                    if (s.Substring(0, 4) == "<KB:")
                    {
                        buttons.state = s[4];
                        switch (buttons.state)
                        {
                            case '1':
                                button1.BackColor = Color.Green;
                            break;

                            case '2':
                                button2.BackColor = Color.Green;
                            break;

                            case '3':
                                button3.BackColor = Color.Green;
                            break;

                            case 'A':
                                buttonA.BackColor = Color.Green;
                            break;

                            case '4':
                                button4.BackColor = Color.Green;
                            break;

                            case '5':
                                button5.BackColor = Color.Green;
                            break;

                            case '6':
                                button6.BackColor = Color.Green;
                            break;

                            case 'B':
                                buttonB.BackColor = Color.Green;
                            break;

                            case '7':
                                button7.BackColor = Color.Green;
                            break;

                            case '8':
                                button8.BackColor = Color.Green;
                            break;

                            case '9':
                                button9.BackColor = Color.Green;
                            break;

                            case 'C':
                                buttonC.BackColor = Color.Green;
                            break;

                            case '*':
                                buttonStar.BackColor = Color.Green;
                            break;

                            case '0':
                                button0.BackColor = Color.Green;
                            break;

                            case '#':
                                buttonHash.BackColor = Color.Green;
                            break;

                            case 'D':
                                buttonD.BackColor = Color.Green;
                            break;

                            default:
                                button1.BackColor = Color.Gray;
                                button2.BackColor = Color.Gray;
                                button3.BackColor = Color.Gray;
                                buttonA.BackColor = Color.Gray;
                                button4.BackColor = Color.Gray;
                                button5.BackColor = Color.Gray;
                                button6.BackColor = Color.Gray;
                                buttonB.BackColor = Color.Gray;
                                button7.BackColor = Color.Gray;
                                button8.BackColor = Color.Gray;
                                button9.BackColor = Color.Gray;
                                buttonC.BackColor = Color.Gray;
                                buttonStar.BackColor = Color.Gray;
                                button0.BackColor = Color.Gray;
                                buttonHash.BackColor = Color.Gray;
                                buttonD.BackColor = Color.Gray;
                            break;
                        }
                        KBin.Text = Convert.ToString(buttons.state);
                    }
                    if (s.Substring(0, 6) == "<KE0:Y")
                    {
                        encoders[0].isPressed = true;
                        En0btn.Text = "1";
                    }
                    else if(s.Substring(0, 6) == "<KE0: ")
                    {
                        encoders[0].isPressed = false;
                        En0btn.Text = "0";
                    }
                    if (s.Substring(0, 6) == "<KE1:Y")
                    {
                        encoders[1].isPressed = true;
                        En1btn.Text = "1";
                    }
                    else if (s.Substring(0, 6) == "<KE1: ")
                    {
                        encoders[1].isPressed = false;
                        En1btn.Text = "0";
                    }
                }
            }
        }

        private void Disconnect_btn_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Connect_btn.Enabled = true;
            Disconnect_btn.Enabled = false;
        }
    }
}
