using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class return1 : Form
    {
        private SerialPort RFID3;
        private string DispString3;
        private SerialPort RFID4;
        private string DispString4;


        public return1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void RFID_DataReceived3(object sender, SerialDataReceivedEventArgs e)
        {

            if (textBox1.Text.Length >= 12)
            {
                MessageBox.Show(" COM 3 Length>=12");
                RFID3.Close();

            }
            else
            {
                DispString3 = RFID3.ReadExisting();
                MessageBox.Show(" COM 3 Read existing");
                this.Invoke(new EventHandler(DisplayText3));
            }


        }

        private void DisplayText3(object sender, EventArgs e)
        {
            textBox1.AppendText(DispString3);
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void RFID_DataReceived4(object sender, SerialDataReceivedEventArgs e)
        {

            if (textBox2.Text.Length >= 12)
            {
                MessageBox.Show(" COM 4 Length>=12");
                RFID4.Close();

            }
            else
            {
                DispString4 = RFID4.ReadExisting();
                MessageBox.Show(" COM 4 Read existing");
                this.Invoke(new EventHandler(DisplayText4));
            }

        }

        private void DisplayText4(object sender, EventArgs e)
        {
            textBox2.AppendText(DispString4);
        }

        private void return1_Load(object sender, EventArgs e)
        {
            RFID3 = new SerialPort();
            RFID3.PortName = "COM3";
            RFID3.BaudRate = 9600;
            RFID3.DataBits = 8;
            RFID3.Parity = Parity.None;
            RFID3.StopBits = StopBits.One;
            RFID3.Open();
            RFID3.ReadTimeout = 200;
            if (RFID3.IsOpen)
            {
                MessageBox.Show("RFID 3 Open");
                DispString3 = "";
                textBox1.Text = "";
            }
            else
            {
                RFID3.Close();
            }
            RFID3.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived3);

            RFID4 = new SerialPort();
            RFID4.PortName = "COM4";
            RFID4.BaudRate = 9600;
            RFID4.DataBits = 8;
            RFID4.Parity = Parity.None;
            RFID4.StopBits = StopBits.One;
            RFID4.Open();
            RFID4.ReadTimeout = 200;
            if (RFID4.IsOpen)
            {
                MessageBox.Show("RFID 4 Open");
                DispString4 = "";
                textBox2.Text = "";
            }
            else
            {
                RFID4.Close();
            }
            RFID4.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived4);
        }
    }
}
