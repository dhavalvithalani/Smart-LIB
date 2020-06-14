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
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace AMS
{
    public partial class StudFeatures : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;

        public StudFeatures()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudFeatures_Load(object sender, EventArgs e)
        {

            //display student pic
            SqlConnection con = new SqlConnection(str);
            MemoryStream ms;
            byte[] photo_aray = new byte[0];

            SqlDataAdapter adapter = new SqlDataAdapter("select Pic from tbl_Studentdet where RFID = '"+StudLoginClick.rfid+"'", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            adapter.Fill(ds,"tbl_Studentdet");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pictureBox1.Image = null;
                if (ds.Tables[0].Rows[0]["Pic"] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[0]["Pic"];
                    ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
           // else
             //  MessageBox.Show("No Records");


            // TODO: This line of code loads data into the 'aMSDataSet2.tbl_StuBookdet' table. You can move, or remove it, as needed.
            this.tbl_StuBookdetTableAdapter.Fill(this.aMSDataSet2.tbl_StuBookdet);
            panel1.Location = new Point(266, 141);
            panel1.Visible = false;

            panel2.Location = new Point(598, 138);
            panel2.Visible = true;

            panelRenew.Location = new Point(266, 141);
            panelRenew.Visible = false;

            panelReturn.Location = new Point(266, 141);
            panelReturn.Visible = false;
            
            /*lblRn.Hide();
            txtRn.Hide();
            lblBookName.Hide();
            txtBookName.Hide();
            btnMiddle.Hide();
            lblHideSeek.Hide();
            lblBookID.Hide();
            txtBookID.Hide();*/
            btnSubmit.Hide();
            lblRenew.Hide();
            lblReturn.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            panelRenew.Visible = false;
            panel2.Location = new Point(49,141);
            panel1.Show();
            lblHideSeek.Hide();
            lblBookID.Hide();
            txtBookID.Hide();
            lblRenew.Hide();

            string StuRn = null;
            string StuRfid = null;
            SqlConnection con1 = new SqlConnection(str);
            SqlDataReader rdr = null;
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID = '" + StudLoginClick.rfid + "'", con1);
            cmd.Parameters.AddWithValue("@RFID", StudLoginClick.rfid);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                StuRn = rdr["RollNo"].ToString();
                StuRfid = rdr["RFID"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    txtRn.Text = StuRn;
                    //MessageBox.Show("roll no print hona chaiye");
                }

            }

            con1.Close();

            
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelReturn.Visible = false;
            panel2.Location = new Point(49, 141);
            panelRenew.Show();
            lblSuccess.Hide();
            lblRenew.Hide();
            lblReturn.Hide();

            string StuRn = null;
            string StuRfid = null;
            SqlConnection con1 = new SqlConnection(str);
            SqlDataReader rdr = null;
            con1.Open();


            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID = '" + StudLoginClick.rfid + "'", con1);
            cmd.Parameters.AddWithValue("@RFID", StudLoginClick.rfid);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                StuRn = rdr["RollNo"].ToString();
                StuRfid = rdr["RFID"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    txtRenewRn.Text = StuRn;
                    //MessageBox.Show("roll no print hona chaiye");
                }

            }

            con1.Close();

            FillCombo1();

            

        }

        void FillCombo1()

        {
            string fetchRn = null;
            string fetchBookName = null;
            SqlConnection con1 = new SqlConnection(str);
            SqlDataReader rdr = null;
            con1.Open();
            SqlCommand cmdFill = new SqlCommand("select * from tbl_StuBookdet where Roll_No = '" + txtRenewRn.Text + "'", con1);
            cmdFill.Parameters.AddWithValue("@Roll_No", txtRenewRn.Text);
            rdr = cmdFill.ExecuteReader();
            while (rdr.Read())
            {
                fetchRn = rdr["Roll_No"].ToString();
                fetchBookName = rdr["Book_name"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    comboRenew.Items.Add(fetchBookName);
                }

            }

        }

        private void btnRenewSubmit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelRenew.Visible = false;
            panel2.Location = new Point(49, 141);
            panelReturn.Show();
            lblSuccess.Hide();
            lblRenew.Hide();
            lblReturn.Hide();


            string StuRn = null;
            string StuRfid = null;
            SqlConnection con1 = new SqlConnection(str);
            SqlDataReader rdr = null;
            con1.Open();


            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID = '" + StudLoginClick.rfid + "'", con1);
            cmd.Parameters.AddWithValue("@RFID", StudLoginClick.rfid);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                StuRn = rdr["RollNo"].ToString();
                StuRfid = rdr["RFID"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    txtReturnRn.Text = StuRn;
                    //MessageBox.Show("roll no print hona chaiye");
                }

            }

            con1.Close();

            FillCombo2();

            RFID = new SerialPort();
            RFID.PortName = "COM3";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.ReadTimeout = 200;
            if (RFID.IsOpen)
            {
                DispString = "";
                txtBookID.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived2);


        }

        void FillCombo2()

        {
            string fetchRn = null;
            string fetchBookName = null;
            SqlConnection con1 = new SqlConnection(str);
            SqlDataReader rdr = null;
            con1.Open();
            SqlCommand cmdFill = new SqlCommand("select * from tbl_StuBookdet where Roll_No = '" + txtReturnRn.Text + "'", con1);
            cmdFill.Parameters.AddWithValue("@Roll_No", txtReturnRn.Text);
            rdr = cmdFill.ExecuteReader();
            while (rdr.Read())
            {
                fetchRn = rdr["Roll_No"].ToString();
                fetchBookName = rdr["Book_name"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    comboReturn.Items.Add(fetchBookName);
                }

            }

        }


        private void RFID_DataReceived2(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtReturnBookID.Text.Length >= 12)
            {
                RFID.Close();

            }
            else
            {
                DispString = RFID.ReadExisting();
                this.Invoke(new EventHandler(DisplayText2));
            }

        }
        private void DisplayText2(object sender, EventArgs e)
        {
            txtReturnBookID.AppendText(DispString);
        }


        private void btnMiddle_Click(object sender, EventArgs e)
        {
            lblRenew.Hide();
            lblReturn.Hide();
            int bookPresent = 0;

            SqlConnection con = new SqlConnection(str);

            SqlDataReader rdr1 = null;
            con.Open();
            SqlCommand cmd5 = new SqlCommand("select * from tbl_StuBookdet where Roll_No=" + Convert.ToInt32(txtRn.Text)+" ", con);
            cmd5.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtRn.Text));
            rdr1 = cmd5.ExecuteReader();
            while (rdr1.Read())
            {
                string checkBook = rdr1["Book_Name"].ToString();
                string checkRn = rdr1["Roll_No"].ToString();
                if (rdr1 != null && rdr1.HasRows)
                {
                    if (checkBook == txtBookName.Text)
                    {
                      
                        bookPresent = 1;
                        MessageBox.Show("book present");

                    }
                }

                else if (rdr1 == null)
                {
                    bookPresent = 0;
                    MessageBox.Show("book not present");
                }

            }
            rdr1.Close();
            con.Close();

            if(bookPresent == 0)
            {
                SqlDataReader rdr = null;
                con.Open();
                SqlCommand cmd3 = new SqlCommand("select * from tbl_Booksdet where Book_Name='" + txtBookName.Text + "'", con);
                cmd3.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
                rdr = cmd3.ExecuteReader();
                while (rdr.Read())
                {
                    string bookName = rdr["Book_Name"].ToString();
                    string shelf = rdr["Shelf_No"].ToString();
                    if (rdr != null && rdr.HasRows)
                    {
                        if (bookName == txtBookName.Text)
                        {
                            //MessageBox.Show("inside reader");

                            lblHideSeek.Text = "Dear Student, your book '" + bookName + "', is kept in shelf " + shelf + "! Please collect it from there and scan your book to issue it..";
                            lblHideSeek.Show();
                            lblBookID.Show();
                            txtBookID.Show();
                            btnSubmit.Show();
                        }
                    }

                    else if (rdr == null)
                    {
                        lblHideSeek.Text = "Dear Student, your book '" + bookName + "' is not found in our library! You can try again by entering the correct book name or contact the libranian!";
                        lblHideSeek.Show();
                    }

                }

                RFID = new SerialPort();
                RFID.PortName = "COM3";
                RFID.BaudRate = 9600;
                RFID.DataBits = 8;
                RFID.Parity = Parity.None;
                RFID.StopBits = StopBits.One;
                RFID.Open();
                RFID.ReadTimeout = 200;
                if (RFID.IsOpen)
                {
                    DispString = "";
                    txtBookID.Text = "";
                }
                else
                {
                    RFID.Close();
                }
                RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived1);


            }

            if(bookPresent == 1)
            {
                lblHideSeek.Text = "Dear Student, you have already borrowed '" + txtBookName.Text + "' book. You cannot issue more than 1 copy of same book!";
                lblHideSeek.Show();
            }



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int flag = 0;  
            SqlConnection con = new SqlConnection(str);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select * from tbl_Studentdet where RollNo = "+Convert.ToInt32(txtRn.Text)+" ", con);
            cmd1.Parameters.AddWithValue("@RollNo", txtRn.Text);
            //cmd.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
            //cmd.ExecuteNonQuery();

            SqlDataReader rdr = null;
            string StuRfid = null;
            string phoneno = null;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                StuRfid = rdr["RFID"].ToString();
                phoneno = rdr["Contact_No"].ToString();
                //MessageBox.Show("Stu RFId fetched");

            }
            rdr.Close();

            SqlCommand cmd4 = new SqlCommand("select * from tbl_Booksdet where Book_RFID = '" + txtBookID.Text + "' ", con);
            cmd4.Parameters.AddWithValue("@Book_RFID", txtBookID.Text);
           
            SqlDataReader rdr2 = null;
            string bkRfid = null;
            string bkName = null;
             rdr2 = cmd4.ExecuteReader();
            while (rdr2.Read())
            {
                bkRfid = rdr2["Book_RFID"].ToString();
                bkName = rdr2["Book_Name"].ToString();
                
                //MessageBox.Show("Book RFId fetched");

                if (rdr2 != null && rdr2.HasRows)
                {
                    if ( (bkName == txtBookName.Text) )
                    {
                        flag = 1;
                        //MessageBox.Show("Match found");
                    }
                }

                else if (rdr2 == null)
                {
                    flag = 0;
                    //MessageBox.Show("Match not found");
                }
                

            }
            rdr2.Close();

     
            string bookRfid = null;
            string bookName = null;
            string rollNo = null;
            string issueDate = null;
            string returnDate = null;
            int msgSend = 0;

            if (flag == 1)
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_StuBookdet(Stu_RFID,Roll_No,Book_Name,Book_RFID,Issue_date,Return_date) values (@Stu_RFID,@Roll_No,@Book_Name,@Book_RFID,@Issue_date,@Return_date)", con);
                cmd.Parameters.AddWithValue("@Stu_RFID", StuRfid);
                cmd.Parameters.AddWithValue("@Roll_No", txtRn.Text);
                cmd.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@Book_RFID", txtBookID.Text);
                cmd.Parameters.AddWithValue("@Issue_date", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@Return_date", DateTime.Now.AddDays(7).ToString("dd-MM-yyyy"));
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("select * from tbl_StuBookdet where Book_RFID = '" + txtBookID.Text + "' ", con);
                cmd2.Parameters.AddWithValue("@Book_RFID", txtBookID.Text);

                SqlDataReader rdr1 = null;

                rdr1 = cmd2.ExecuteReader();
                while (rdr1.Read())
                {
                    bookRfid = rdr1["Book_RFID"].ToString();
                    bookName = rdr1["Book_Name"].ToString();
                    rollNo = rdr1["Roll_No"].ToString();
                    issueDate = rdr1["Issue_date"].ToString();
                    returnDate = rdr1["Return_date"].ToString();
                    
                    //MessageBox.Show("Stu RFId fetched");
                    lblSuccess.Text = "Dear " + StudLoginClick.name + ", you have successfully ISSUED " + bookName + " (" + bookRfid + ") book! Please return it on or before " + returnDate + " or else you would be liable to fine!";
                    msgSend = 1;
                }
                rdr1.Close();

            }

            

            else {
                lblSuccess.Location = new Point(250,710);
                lblSuccess.Text = "Dear "+StudLoginClick.name+", the book you scanned is a wrong one! Please try to scan once again...";
                //MessageBox.Show("else flag = 0 vala");
            }

            con.Close();

            if(msgSend == 1)
            {
                const string accountSid = "ACc0314dbae755a0cd1fad3ad0ed3b29d1";
                const string authToken = "784d8f4dbaf1a3fc0e294ba2118e4a8f";

                TwilioClient.Init(accountSid, authToken);

                MessageResource.Create(

                     to: new PhoneNumber("+91" + phoneno),
                     from: new PhoneNumber("+12024002645"),
                     body: "Dear " + StudLoginClick.name + ", you have successfully ISSUED '" + bookName + "' (" + bookRfid + ") book on "+issueDate+" ! Please return it on or before " + returnDate + " or else you would be liable to fine!\n\nRegards,\nPATKAR LIBRARY!\n\nNote: This is an auto-generated text message, please do not reply." );

                MessageBox.Show("Message sent");
            }
           


        }

        private void RFID_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtBookID.Text.Length >= 12)
            {
                RFID.Close();

            }
            else
            {
                DispString = RFID.ReadExisting();
                this.Invoke(new EventHandler(DisplayText1));
            }

        }
        private void DisplayText1(object sender, EventArgs e)
        {
            txtBookID.AppendText(DispString);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboRenew_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelRenew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRenew_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnRenewSubmit_Click_1(object sender, EventArgs e)
        {
            int renewalPossible = 0;

            DateTime Date = DateTime.Now;
            string current = null;
            current = Date.ToString("dd-MM-yyyy");

            DateTime currentDate = DateTime.Parse(current);

            SqlConnection con1 = new SqlConnection(str);
            con1.Open();

            SqlCommand cmdPhone = new SqlCommand("select * from tbl_Studentdet where RollNo = " + Convert.ToInt32(txtRenewRn.Text) + " ", con1);
            cmdPhone.Parameters.AddWithValue("@RollNo", txtRenewRn.Text);
            //cmd.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
            //cmd.ExecuteNonQuery();

            SqlDataReader rdr = null;
            string StuRfid = null;
            string phoneno = null;
            rdr = cmdPhone.ExecuteReader();
            while (rdr.Read())
            {
                StuRfid = rdr["RFID"].ToString();
                phoneno = rdr["Contact_No"].ToString();
                //MessageBox.Show("Stu RFId fetched");

            }
            rdr.Close();

            SqlDataReader rdr1 = null;
            string renewRn = null;
            string returnDate = null;
            string renewalDate = null;

            SqlCommand cmd = new SqlCommand("select * from tbl_StuBookdet where Roll_No=" + Convert.ToInt32(txtRenewRn.Text) + " AND Book_Name = '" + comboRenew.SelectedItem.ToString() + "'", con1);
            cmd.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtRenewRn.Text));
            cmd.Parameters.AddWithValue("@Book_Name", comboRenew.SelectedItem.ToString());

            rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                renewRn = rdr1["Roll_No"].ToString();
                returnDate = rdr1["Return_date"].ToString();
                renewalDate = rdr1["Renewal_date"].ToString();

                if(string.IsNullOrEmpty(renewalDate))
                {
                    if (rdr1.HasRows)
                    {
                        //lblRenew.Text += DateTime.Parse(renewalDate);

                        int result = DateTime.Compare(currentDate, DateTime.Parse(returnDate));
                        if (result <= 0)
                        {
                            renewalPossible = 1;
                            // MessageBox.Show("renewal hoga bantai");
                        }

                        else
                        {
                            renewalPossible = 0;
                            //MessageBox.Show("renewal nahi hoga emiway bantai");
                        }


                    }
                }
               

                else
                {
                    renewalPossible = -1;
                    lblRenew.Location = new Point(500, 710);
                    lblRenew.Text = "Dear " + StudLoginClick.name + ", only one renewal is allowed per book! ";
                    lblRenew.Show();
                    //MessageBox.Show("rdr row khali");
                }

            }

            rdr1.Close();
            int msgSend = 0;
            string bookRfid = null;
            string bookName = null;
            string rollNo = null;
            string renew = null;
            string returnAfterRenew = null;


            if (renewalPossible == 1)
            {
                SqlCommand cmd1 = new SqlCommand("update tbl_StuBookdet set Renewal_date = '" + current + "' , Renewal_Return_date = '" + currentDate.AddDays(7).ToString("dd-MM-yyyy") + "' where Roll_No = "+Convert.ToInt32(txtRenewRn.Text)+" AND Book_Name = '"+comboRenew.SelectedItem.ToString()+"'", con1);
                cmd1.Parameters.AddWithValue("@Renewal_date", current);
                cmd1.Parameters.AddWithValue("@Renewal_Return_date", currentDate.AddDays(7).ToString("dd-MM-yyyy"));
                cmd1.ExecuteNonQuery();
                //MessageBox.Show("inserted");
                msgSend = 1;
                lblRenew.Text = "Dear " + StudLoginClick.name + ", your '" + comboRenew.SelectedItem.ToString() + "' is RENEWED successfully! Please return it on or before " + currentDate.AddDays(7).ToString("dd-MM-yyyy") + " or else you would be liable to fine!";
                lblRenew.Show();

                SqlCommand cmdFetch = new SqlCommand("select * from tbl_StuBookdet where Book_RFID = '" + txtBookID.Text + "' ", con1);
                cmdFetch.Parameters.AddWithValue("@Book_RFID", txtBookID.Text);

                SqlDataReader rdrFetch = null;
                
                rdrFetch = cmdFetch.ExecuteReader();
                while (rdrFetch.Read())
                {
                    bookRfid = rdrFetch["Book_RFID"].ToString();
                    bookName = rdrFetch["Book_Name"].ToString();
                    rollNo = rdrFetch["Roll_No"].ToString();
                    renew = rdrFetch["Renewal_date"].ToString();
                    returnAfterRenew = rdrFetch["Renewal_Return_date"].ToString();

                }
                rdrFetch.Close();


            }

            if (renewalPossible == 0)
            {
                MessageBox.Show(" NOT inserted");
                lblRenew.Text = "Dear " + StudLoginClick.name + ", you have already crossed your return date, So you cannot renew your book! Check the fine section.. ";
                lblRenew.Show();
            }

            if (msgSend == 1)
            {
                const string accountSid = "ACc0314dbae755a0cd1fad3ad0ed3b29d1";
                const string authToken = "784d8f4dbaf1a3fc0e294ba2118e4a8f";

                TwilioClient.Init(accountSid, authToken);

                MessageResource.Create(

                     to: new PhoneNumber("+91" + phoneno),
                     from: new PhoneNumber("+12024002645"),
                     body: "Dear " + StudLoginClick.name + ", you have successfully RENEWED '" + bookName + "' (" + bookRfid + ") book on " + renew + " ! Please return it on or before " + returnAfterRenew + " or else you would be liable to fine!\n\nRegards,\nPATKAR LIBRARY!\n\nNote: This is an auto-generated text message, please do not reply." );

                MessageBox.Show("Message sent");
            }


        }

        private void btnReturnSubmit_Click(object sender, EventArgs e)
        {
            int returnPossible = 0;

            DateTime Date = DateTime.Now;
            string current = null;
            current = Date.ToString("dd-MM-yyyy");

            DateTime currentDate = DateTime.Parse(current);

            SqlConnection con1 = new SqlConnection(str);
            con1.Open();

            SqlDataReader rdr1 = null;
            string returnRn = null;
            string returnDate = null;
            string returnRenewalDate = null;
            string shelf = null;
            string bookRfid = null;
      
            //string renewalDate = null;

            SqlCommand cmd = new SqlCommand("select * from tbl_StuBookdet where Roll_No=" + Convert.ToInt32(txtReturnRn.Text) + " AND Book_Name = '" + comboReturn.SelectedItem.ToString() + "'", con1);
            cmd.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtReturnRn.Text));
            cmd.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());

            rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                returnRn = rdr1["Roll_No"].ToString();
                returnDate = rdr1["Return_date"].ToString();
                returnRenewalDate = rdr1["Renewal_date"].ToString();
                //MessageBox.Show(returnRenewalDate);

               // DateTime retDate = DateTime.Parse(returnRenewalDate);
                

                if (string.IsNullOrEmpty(returnRenewalDate))
                {
                    if (rdr1.HasRows)
                    {
                        //lblRenew.Text += DateTime.Parse(renewalDate);

                        int result = DateTime.Compare(currentDate, DateTime.Parse(returnDate));
                        if (result <= 0)
                        {
                            returnPossible = 1;
                            //MessageBox.Show("returnnnnnnnnnnnnnn hoga bantai");
                        }

                        else
                        {
                            returnPossible = 0;
                            //MessageBox.Show("return nahi hoga emiway bantai");
                        }


                    }
                }


               else
                {
                    if (rdr1.HasRows)
                    {
                        //lblRenew.Text += DateTime.Parse(renewalDate);

                        int result = DateTime.Compare(currentDate, DateTime.Parse(returnRenewalDate));
                        if (result <= 0)
                        {
                            returnPossible = 2;
                            //MessageBox.Show("renwal vala returnnnnnnnnnnnnnn hoga bantai");
                        }

                        else
                        {
                            returnPossible = 0;
                            //MessageBox.Show("renewal vala return nahi hoga emiway bantai");
                        }


                    }
                }

            }

            rdr1.Close();
            con1.Close();


            if (returnPossible == 1)
            {
                SqlDataReader rdr = null;
                con1.Open();
                SqlCommand cmd3 = new SqlCommand("select * from tbl_Booksdet where Book_Name='" +comboReturn.SelectedItem.ToString() + "'", con1);
                cmd3.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                rdr = cmd3.ExecuteReader();
                while (rdr.Read())
                {
                    string bookName = rdr["Book_Name"].ToString();
                    shelf = rdr["Shelf_No"].ToString();
                    bookRfid = rdr["Book_RFID"].ToString();

                }

                rdr.Close();

                if(bookRfid == txtReturnBookID.Text )
                {
                    SqlCommand cmd1 = new SqlCommand("delete from tbl_StuBookdet where Roll_No = " + Convert.ToInt32(txtReturnRn.Text) + " AND Book_Name ='" + comboReturn.SelectedItem.ToString() + "' AND Book_RFID = '" + txtReturnBookID.Text + "' ", con1);
                    cmd1.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtReturnRn.Text));
                    cmd1.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Book_RFID", txtReturnBookID.Text);
                    cmd1.ExecuteNonQuery();
                    //MessageBox.Show("inserted");
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", your '" + comboReturn.SelectedItem.ToString() + "' is RETURNED successfully! Please keep the book on shelf " + shelf + ".";
                    lblReturn.Show();

                }
                else
                {
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", you have scanned the wrong book! Please try again later!";
                    lblReturn.Show();
                }


            }

            if(returnPossible == 2)
            {
                SqlDataReader rdr = null;
                con1.Open();
                SqlCommand cmd3 = new SqlCommand("select * from tbl_Booksdet where Book_Name='" + comboReturn.SelectedItem.ToString() + "'", con1);
                cmd3.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                rdr = cmd3.ExecuteReader();
                while (rdr.Read())
                {
                    string bookName = rdr["Book_Name"].ToString();
                    shelf = rdr["Shelf_No"].ToString();
                    bookRfid = rdr["Book_RFID"].ToString();

                }

                rdr.Close();

                if (bookRfid == txtReturnBookID.Text)
                {
                    SqlCommand cmd1 = new SqlCommand("delete from tbl_StuBookdet where Roll_No = " + Convert.ToInt32(txtReturnRn.Text) + " AND Book_Name ='" + comboReturn.SelectedItem.ToString() + "' AND Book_RFID = '" + txtReturnBookID.Text + "' ", con1);
                    cmd1.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtReturnRn.Text));
                    cmd1.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Book_RFID", txtReturnBookID.Text);
                    cmd1.ExecuteNonQuery();
                    //MessageBox.Show("inserted");
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", your renewed book'" + comboReturn.SelectedItem.ToString() + "' is RETURNED successfully! Please keep the book on shelf " + shelf + ".";
                    lblReturn.Show();

                }
                else
                {
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", you have scanned the wrong book! Please try again later!";
                    lblReturn.Show();
                }
            }

            if (returnPossible == 0)
            {
                //MessageBox.Show(" return NOT psble");
                lblReturn.Text = "Dear " + StudLoginClick.name + ", you have already crossed your return date, so check the fine section! ";
                lblReturn.Show();
            }
        }

        private void panelRenew_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
