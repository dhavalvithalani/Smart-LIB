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
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace AMS
{
    public partial class AddStudent : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;
      
        private string demo;
        private string Gender;
        MemoryStream ms = null;
        byte[] photo_aray;

        //DataClassesDataContext db = new DataClassesDataContext();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeRFID();

        }

        private void InitializeRFID()
        {
            RFID = new SerialPort();
            RFID.PortName = "COM3";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;

            //RFID.ReadBufferSize = 16;
            RFID.Open();
           // RFID.DiscardInBuffer();
            //RFID.DiscardOutBuffer();
            RFID.ReadTimeout = 200;
            if (RFID.IsOpen)
            {
                DispString = "";
                demo = "";
                //txttag.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            if (txttag.Text.Length >= 12)
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
            txttag.AppendText(DispString);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            switch (btnsubmit.Text)
            {
                case "Submit":
                    if (txttag.Text.Length == 0 || txtrollno.Text.Length == 0 || txtstudname.Text.Length == 0)
                    { return; }
                    if (!CheckDuplicateRFID())
                    {
                        MessageBox.Show("Already Saved");
                        txttag.Text = "";
                        return;
                    }
                    break;
            }
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_Studentdet(RFID,Student_Name,RollNo,Gender,Contact_No,Year_Of_Admsn,Pic) values (@RFID,@Student_Name,@RollNo,@Gender,@Contact_No,@Year_Of_Admsn,@Pic)", con);
            cmd.Parameters.AddWithValue("@RFID", txttag.Text);
            cmd.Parameters.AddWithValue("@Student_Name", txtstudname.Text);
            cmd.Parameters.AddWithValue("@RollNo", txtrollno.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Contact_No", txtcontact.Text);
            cmd.Parameters.AddWithValue("@Year_Of_Admsn", comboclass.SelectedItem.ToString());
            
            if (pictureBox1.Image != null)
            { 
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@Pic", photo_aray);
            }

            cmd.ExecuteNonQuery();
            MessageBox.Show("Student added successfully!");
            
            con.Close();


            /* if (ValidateChildren(ValidationConstraints.Enabled))
             {
                 MessageBox.Show(txttag.Text, "Demo App - Message!");
             }*/


            


        }

        private bool CheckDuplicateRFID()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID='" + txttag.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Student already exist !!");
                rd.Close();
                return false;
            }
            else
            {
                rd.Close();
                return true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "female";
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);  
                
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txttag.Text = "";
            txtstudname.Text = "";
            txtrollno.Text = "";
            txtcontact.Text = "";
            comboclass.SelectedItem = null;
            pictureBox1.Image = null;
            male.Checked = false;
            female.Checked = false;
            InitializeRFID();
        }

        private void txttag_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttag.Text))
            {
                e.Cancel = true;
                txttag.Focus();
                errorProvider1.SetError(txttag, "Tag ID should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txttag, "");
            }
        }

        private void txtstudname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtstudname.Text))
            {
                e.Cancel = true;
                txttag.Focus();
                errorProvider2.SetError(txtstudname, "Tag ID should not be left blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtstudname, "");
            }
        }

        private void txtcontact_Validating(object sender, CancelEventArgs e)
        {

            string phonePattern = @"^?[7-9]\d{9}0\$";
            bool isPhoneValid = Regex.IsMatch(txtcontact.Text, phonePattern);

            if (string.IsNullOrWhiteSpace(txtstudname.Text))
            {
                e.Cancel = true;
                txtcontact.Focus();
                errorProvider3.SetError(txtcontact, "Contact number should not be left blank");
            }

            if (!isPhoneValid)
            {
                errorProvider4.SetError(txtcontact, "Contact number invalid");
            }

            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtcontact, "");
                errorProvider4.SetError(txtcontact, "");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboclass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtrollno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstudname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txttag_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pic_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        /*private void male_CheckedChanged_1(object sender, EventArgs e)
        {

        }*/

        private void txtcontact_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}