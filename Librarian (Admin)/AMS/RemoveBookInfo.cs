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
    public partial class RemoveBookInfo : Form
    {

        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        int checkRadio = -1;
        private SerialPort RFID;
        private string DispString;

        public RemoveBookInfo()
        {
            InitializeComponent();
        }

        private void RemoveBookInfo_Load(object sender, EventArgs e)
        {
            lblScanID.Hide();
            txtBookTagID.Hide();
            lblRn.Hide();
            txtBookName.Hide();
            label2.Hide();
            lbltxtBk.Hide();
        }

        private void RBBooktag_CheckedChanged(object sender, EventArgs e)
        {
            lblScanID.Show();
            txtBookTagID.Show();
            lblRn.Hide();
            txtBookName.Hide();
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
                txtBookTagID.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtBookTagID.Text.Length >= 12)
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
            txtBookTagID.AppendText(DispString);
        }

        private void RBBookName_CheckedChanged(object sender, EventArgs e)
        {
            lblScanID.Hide();
            txtBookTagID.Hide();
            lblRn.Show();
            txtBookName.Show();
            checkRadio = 2;
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("inside btn click");
            int removePossible = -1;
            string name = null;

            if (checkRadio == 1)
            {
                SqlConnection con = new SqlConnection(str);
                SqlDataReader rdr = null;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_Booksdet where Book_RFID='" + txtBookTagID.Text + "'", con);
                cmd.Parameters.AddWithValue("@Book_RFID", txtBookTagID.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string rfid = rdr["Book_RFID"].ToString();
                    name = rdr["Book_Name"].ToString();
                    if (rdr != null && rdr.HasRows)
                    {
                        if (rfid == txtBookTagID.Text)
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
                    label2.Hide();
                    lbltxtBk.Text = "Book '" + name + "' is permanently deleted from Patkar Library's data! ";
                    lbltxtBk.Show();

                    SqlCommand cmd1 = new SqlCommand("delete from tbl_Booksdet WHERE Book_RFID = '" + txtBookTagID.Text + "' ", con);
                    cmd1.ExecuteNonQuery();
                }

                else
                {
                   lbltxtBk.Hide();
                   label2.Text = "This book doesn't exist in Patkar Library's data!";
                   label2.Show();
                }

                con.Close();

            }

            if (checkRadio == 2)
            {
                //MessageBox.Show("2nd radio clicked");
                SqlConnection con = new SqlConnection(str);
                SqlDataReader rdr = null;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_Booksdet where Book_Name = '" + txtBookName.Text + "' ", con);
                cmd.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                   // string rollno = rdr["RollNo"].ToString();
                    name = rdr["Book_Name"].ToString();
                    if (rdr != null && rdr.HasRows)
                    {
                        if (name == txtBookName.Text)
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
                    label2.Hide();
                    lbltxtBk.Text = "Book record for '" + name + "' is permanently deleted from Patkar Library's data! ";
                    lbltxtBk.Show();
                    SqlCommand cmd1 = new SqlCommand("delete from tbl_Booksdet where Book_Name = '" + txtBookName.Text + "' ", con);
                    cmd1.ExecuteNonQuery();

                }
               
                else
                {
                    //MessageBox.Show("sxc");
                    //lbltxtBk.Location = new Point(715,925);
                    //MessageBox.Show("sxc after");
                    lbltxtBk.Hide();
                    label2.Text = "This book doesn't exist in Patkar Library's data!";
                    label2.Show();
                }

                con.Close();
            }


        
    }
    }
}
