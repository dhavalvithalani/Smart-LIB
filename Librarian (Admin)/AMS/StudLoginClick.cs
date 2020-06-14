using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AMS
{
    public partial class StudLoginClick : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;
        public static string rfid = null;
        public static string name = null;

        public StudLoginClick()
        {
            InitializeComponent();
        }

        void load()
        {
            RFID = new SerialPort();
            RFID.PortName = "COM3";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.ReadTimeout = 200;

            //RFID.WriteTimeout = 4000;
            if (RFID.IsOpen)
            {
                DispString = "";
                txttag1.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }

        private void StudLoginClick_Load(object sender, EventArgs e)
        {

            load();

        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (txttag1.Text.Length >= 12)
            {
                RFID.Close();

            }
            else
            {
                DispString = RFID.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }

        }
        private void DisplayText(object sender, EventArgs e)
        {
           // MessageBox.Show("bjb"+DispString);
            
            txttag1.AppendText(DispString);
        }

        private void lblTagID_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            switch (btnLogin.Text)
            {
                case "Submit":
                    if (txttag1.Text.Length == 0)
                    { return; }
                    if (!CheckDuplicateRFID())
                    {
                        MessageBox.Show("Already Saved");
                        txttag1.Text = "";
                        return;
                    }
                    break;
            }

            SqlConnection con = new SqlConnection(str);
            SqlDataReader rdr = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID='" + txttag1.Text + "'", con);
            cmd.Parameters.AddWithValue("@RFID", txttag1.Text);
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                rfid = rdr["RFID"].ToString();
                name = rdr["Student_Name"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    if (rfid == txttag1.Text)
                    {
                        //MessageBox.Show("Student logged on");
                        lblStud.Text = "Welcome dear, " + name + " ! Click here to access our library features... ";

                    }
                }
                   
                else
                {
                    MessageBox.Show("LOggin fail!");
                    break;
                }
               /* if(rdr!=null && rdr.HasRows)
                {
                    label1.Text = "login";
                    MessageBox.Show("Student logged on");
                }
                else if (rdr == null)
                {
                    label1.Text = "FALTU";
                    MessageBox.Show("LOggin fail!");
                }*/
            }

            rdr.Close();

            con.Close();
        }

        private bool CheckDuplicateRFID()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID='" + txttag1.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                return false;
            }
            else
            {
                rd.Close();
                return true;
            }
        }

        private void lblStud_Click(object sender, EventArgs e)
        {
            StudFeatures newform = new StudFeatures();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void txttag_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
