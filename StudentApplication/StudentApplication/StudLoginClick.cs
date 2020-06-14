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

namespace StudentApplication
{
    public partial class StudLoginClick : Form
    {
        FormCollection formCollection = Application.OpenForms;
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;
        public static string rfid = null;
        public static string name = null;

        public StudLoginClick()
        {
            InitializeComponent();
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
            int a = 0;
           
            /*if(a!=0)
            {

            }
            else
            {

            }*/
            rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                rfid = rdr["RFID"].ToString();
                name = rdr["Student_Name"].ToString();
                a++;
                MessageBox.Show("asss" + a);
                
                if (rdr.HasRows)
                {
                    if (rfid == txttag1.Text)
                    {
                        //MessageBox.Show("Student logged on");
                        lblStud.Text = "Welcome dear, " + name + " ! Click here to access our library features... ";

                    }
                    /*else if(rfid != txttag1.Text)
                    {
                        MessageBox.Show("Login fail!");
                        break;
                    }*/
                }

              
                else if(!rdr.HasRows)
                 {
                     label1.Text = "login";
                     MessageBox.Show("Student logged on");
                 }
                 /*else if (rdr == null)
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


        private void StudLoginClick_Load(object sender, EventArgs e)
        {
            

            panelLogin.Location = new Point(450, 30);
            panelLogin.Visible = true;

            panelLateFee.Location = new Point(450, 30);
            panelLateFee.Visible = false;

            panelLibSchedule.Location = new Point(450, 30);
            panelLibSchedule.Visible = false;

            panelLibRules.Location = new Point(450, 30);
            panelLibRules.Visible = false;


            RFID = new SerialPort();
            RFID.PortName = "COM3";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.ReadTimeout = 100;

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

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (txttag1.Text.Length >= 12)
            {
                RFID.Close();

            }
            else
            {
                DispString = RFID.ReadExisting();
                //DispString.Substring(0, 12);
                this.Invoke(new EventHandler(DisplayText));
            }

        }
        private void DisplayText(object sender, EventArgs e)
        {
            //MessageBox.Show("bjb" + DispString);

            txttag1.AppendText(DispString);
        }

        private void lblStud_Click(object sender, EventArgs e)
        {
            StudFeatures newform = new StudFeatures();
            this.Hide();
            newform.ShowDialog();
            
           
            this.Close();

        }

        private void txtwelcome_Click(object sender, EventArgs e)
        {

        }

        private void txttag1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTagID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void About_TextChanged(object sender, EventArgs e)
        {

        }

        private void About_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void about_MouseHover_1(object sender, EventArgs e)
        {
            
           
        }

        private void btnLoginPanel_Click(object sender, EventArgs e)
        {
            panelLateFee.Visible = false;
            panelLibRules.Visible = false;
            panelLibSchedule.Visible = false;


            panelLogin.Show();

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelLibSchedule.Visible = false;
            panelLateFee.Visible = false;

            panelLibRules.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelLibRules.Visible = false;
            panelLateFee.Visible = false;

            panelLibSchedule.Show();

        }

        private void btnFeeStructure_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelLibRules.Visible = false;
            panelLibSchedule.Visible = false;

            panelLateFee.Show();

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {

        }

        private void lblStud_Click_1(object sender, EventArgs e)
        {

        }
    }
}