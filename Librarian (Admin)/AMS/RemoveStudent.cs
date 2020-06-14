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
    public partial class RemoveStudent : Form


    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        int checkRadio = -1;
        private SerialPort RFID;
        private string DispString;

        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RBtag_CheckedChanged(object sender, EventArgs e)
        {
            
            lblScanID.Show();
            txtTagID.Show();
            lblRn.Hide();
            txtRn.Hide();
            checkRadio = 1;
           

            RFID = new SerialPort();
            RFID.PortName = "COM3";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.ReadTimeout = 100;
            if (RFID.IsOpen)
            {
                DispString = "";
                txtTagID.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }

        private void RBrn_CheckedChanged(object sender, EventArgs e)
        {
            
            lblScanID.Hide();
            txtTagID.Hide();
            lblRn.Show();
            txtRn.Show();
            checkRadio = 2;
          
        }


        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            lblScanID.Hide();
            txtTagID.Hide();
            lblRn.Hide();
            txtRn.Hide();
            lbltxt.Hide();
            label2.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            
            //MessageBox.Show("inside btn click");
            int removePossible = -1;
            string name = null;

            if(checkRadio == 1)
            {
            SqlConnection con = new SqlConnection(str);
                SqlDataReader rdr = null;
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID='" + txtTagID.Text + "'", con);
            cmd.Parameters.AddWithValue("@RFID", txtTagID.Text);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string rfid = rdr["RFID"].ToString();
                name = rdr["Student_Name"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    if (rfid == txtTagID.Text)
                    {
                            removePossible = 1;

                    }
                     else {
                            removePossible = 0;
                            //MessageBox.Show("dcdcdc"+removePossible);
                            
                        }
                }

               
            }
                rdr.Close();

                if(removePossible == 1)
                {
                    SqlCommand cmd1 = new SqlCommand("delete from tbl_Studentdet WHERE RFID = '" + txtTagID.Text + "' ", con);
                    cmd1.ExecuteNonQuery();
                    
                    label2.Hide();
                    lbltxt.Text = "Student record for '" + name + "' is permanently deleted from Patkar Library's data! ";
                    lbltxt.Show();

                }

                else
                {
                    lbltxt.Hide();
                    label2.Text = "This Tag ID doesn't exist!";
                    label2.Show();
                }

                con.Close();

            }

            if(checkRadio == 2)
            {
                //MessageBox.Show("2nd radio clicked");
                SqlConnection con = new SqlConnection(str);
                SqlDataReader rdr = null;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RollNo = " + Convert.ToInt32(txtRn.Text) + " ", con);
                cmd.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRn.Text));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string rollno = rdr["RollNo"].ToString();
                    name = rdr["Student_Name"].ToString();
                    if (rdr != null && rdr.HasRows)
                    {
                        if (rollno == txtRn.Text)
                        {
                            removePossible = 1;
                           
                        }
                        else
                        {
                            removePossible = 0;
                           
                        }
                    }


                }
                rdr.Close();

                if(removePossible == 1)
                {
                   
                    SqlCommand cmd1 = new SqlCommand("delete from tbl_Studentdet where RollNo = " + Convert.ToInt32(txtRn.Text) + " ", con);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("delete from tbl_StuBookdet WHERE Roll_No = " + Convert.ToInt32(txtRn.Text) + " ", con);
                    cmd2.ExecuteNonQuery();

                    label2.Hide();
                    lbltxt.Text = "Student record for '" + name + "' is permanently deleted from Patkar Library's data! ";
                    lbltxt.Show();
                }

                else
                {
                    lbltxt.Hide();
                    label2.Text = "This RollNo doesn't exist!";
                    label2.Show();
                    
                }

                con.Close();
            }
            
            
        }

        private void txtTagID_TextChanged(object sender, EventArgs e)
        {

        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtTagID.Text.Length >= 12)
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
            txtTagID.AppendText(DispString);
        }

        private void lblRn_Click(object sender, EventArgs e)
        {

        }

        private void lblScanID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }


     
}
