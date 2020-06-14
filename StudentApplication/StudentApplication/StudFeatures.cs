using AMS;
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
using Timer = System.Windows.Forms.Timer;
using System.Timers;
using WMPLib;

namespace StudentApplication
{


    public partial class StudFeatures : Form
    {
        FormCollection formCollection = Application.OpenForms;

        public ReturnBookProcess rbp;



        private Timer tm = new Timer();
        int timeLeft = 30;
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        public string bookName1 = null;
        private SerialPort RFID;
        private string DispString;



        public StudFeatures()
        {
            InitializeComponent();
            //int checkPlacedCorrect = -1;
        }



        private void StudFeatures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet1.tbl_Booksdet' table. You can move, or remove it, as needed.
            this.tbl_BooksdetTableAdapter.Fill(this.aMSDataSet1.tbl_Booksdet);
            lblUserName.Text += StudLoginClick.name;
            // TODO: This line of code loads data into the 'aMSDataSet.tbl_StuBookdet' table. You can move, or remove it, as needed.
            this.tbl_StuBookdetTableAdapter.Fill(this.aMSDataSet.tbl_StuBookdet);
            //display student pic
            SqlConnection con = new SqlConnection(str);
            MemoryStream ms;
            byte[] photo_aray = new byte[0];

            SqlDataAdapter adapter = new SqlDataAdapter("select Pic from tbl_Studentdet where RFID = '" + StudLoginClick.rfid + "'", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Studentdet");

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


            //// TODO: This line of code loads data into the 'aMSDataSet2.tbl_StuBookdet' table. You can move, or remove it, as needed.
            //// this.tbl_StuBookdetTableAdapter.Fill(this.aMSDataSet2.tbl_StuBookdet);

            panelstu.Location = new Point(710, 18);
            panelstu.Visible = true;

            panel_Issue.Location = new Point(450, 18);
            panel_Issue.Visible = false;

            panelRenew.Location = new Point(450, 18);
            panelRenew.Visible = false;

            panelReturn.Location = new Point(450, 18);
            panelReturn.Visible = false;

            panelLateFee.Location = new Point(450, 18);
            panelLateFee.Visible = false;

            panelLibSchedule.Location = new Point(450, 18);
            panelLibSchedule.Visible = false;

            panelLibRules.Location = new Point(450, 18);
            panelLibRules.Visible = false;

            panelMyAccount.Location = new Point(450, 18);
            panelMyAccount.Visible = false;

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
            lblRenewNotPsble.Hide();
            lblReturn.Hide();
            txt_time.Hide();
            lblTimesUp.Hide();
            lblReturned.Hide();
            lblSuccess.Hide();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            panelRenew.Visible = false;
            panelReturn.Visible = false;
            panelLateFee.Visible = false;
            panelLibSchedule.Visible = false;
            panelLibRules.Visible = false;
            panelMyAccount.Visible = false;

            panelstu.Location = new Point(65, 18);
            panel_Issue.Show();
            lblBookFound.Hide();
            lblBookID.Hide();
            txtBookID.Hide();
            lblRenew.Hide();
            lblRenewNotPsble.Hide();
            lblSuccess.Hide();

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


        //Search your book
        private void btnMiddle_Click(object sender, EventArgs e)
        {
           // btnMiddle.Enabled = false;
            lblRenew.Hide();
            lblReturn.Hide();
            lblRenewNotPsble.Hide();
            int bookPresent = 0;

            SqlConnection con = new SqlConnection(str);

            SqlDataReader rdr1 = null;
            con.Open();
            SqlCommand cmd5 = new SqlCommand("select * from tbl_StuBookdet where Roll_No=" + Convert.ToInt32(txtRn.Text) + " ", con);
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

            if (bookPresent == 0)
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

                            lblBookFound.Text = "Dear Student, your book '" + bookName + "', is kept in shelf " + shelf + "! Please collect it from there and scan your book to issue it..";
                            lblBookFound.Show();
                            lblBookID.Show();
                            txtBookID.Show();
                            btnSubmit.Show();
                        }
                    }

                    else if (rdr == null)
                    {
                        lblBookFound.Text = "Dear Student, your book '" + bookName + "' is not found in our library! You can try again by entering the correct book name or contact the libranian!";
                        lblBookFound.Show();
                        lblBookID.Hide();
                        txtBookID.Hide();
                        btnSubmit.Hide();
                        lblSuccess.Hide();
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

            if (bookPresent == 1)
            {
                lblBookFound.Text = "Dear Student, you have already borrowed '" + txtBookName.Text + "' book. You cannot issue more than 1 copy of same book!";
                lblBookFound.Show();
                lblBookID.Hide();
                txtBookID.Hide();
                btnSubmit.Hide();
                lblSuccess.Hide();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        //ISSUE BOOK
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            int flag = 0;
            SqlConnection con = new SqlConnection(str);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select * from tbl_Studentdet where RollNo = " + Convert.ToInt32(txtRn.Text) + " ", con);
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
                    if ((bkName == txtBookName.Text))
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
                    lblSuccess.Show();
                    msgSend = 1;
                }
                rdr1.Close();

            }



            else
            {
                lblSuccess.Location = new Point(250, 710);
                lblSuccess.Text = "Dear " + StudLoginClick.name + ", the book you scanned is a wrong one! Please try to scan once again...";
                //MessageBox.Show("else flag = 0 vala");
            }

            con.Close();

            /*if (msgSend == 1)
            {
                const string accountSid = "ACc0314dbae755a0cd1fad3ad0ed3b29d1";
                const string authToken = "784d8f4dbaf1a3fc0e294ba2118e4a8f";

                TwilioClient.Init(accountSid, authToken);

                MessageResource.Create(

                     to: new PhoneNumber("+91" + phoneno),
                     from: new PhoneNumber("+12024002645"),
                     body: "Dear " + StudLoginClick.name + ", you have successfully ISSUED '" + bookName + "' (" + bookRfid + ") book on " + issueDate + " ! Please return it on or before " + returnDate + " or else you would be liable to fine!\n\nRegards,\nPATKAR LIBRARY!\n\nNote: This is an auto-generated text message, please do not reply.");

                MessageBox.Show("Message sent");
            }*/

        }

        private void btnRenew_Click(object sender, EventArgs e)          //STUDENT PANEL
        {
            panel_Issue.Visible = false;
            panelReturn.Visible = false;
            panelLateFee.Visible = false;
            panelLibSchedule.Visible = false;
            panelLibRules.Visible = false;
            panelMyAccount.Visible = false;

            panelstu.Location = new Point(65, 18);
            panelRenew.Show();
            lblSuccess.Hide();
            lblRenew.Hide();
            lblReturn.Hide();
            lblRenewNotPsble.Hide();

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
            //MessageBox.Show("dc" + label1.Location);
            //MessageBox.Show("sc" + lblSuccess.Location);
            //MessageBox.Show("dc" + lblRenew.Location);

            //btnReturnSubmit.Enabled = false;

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

                if (string.IsNullOrEmpty(renewalDate))
                {
                    if (rdr1.HasRows)
                    {
                        //lblRenew.Text += DateTime.Parse(renewalDate);

                        int result = DateTime.Compare(currentDate, DateTime.Parse(returnDate));
                        if (result <= 0)
                        {
                            renewalPossible = 1;
                            //MessageBox.Show("renewal hoga bantai");
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
                    //lblRenew.Location = new Point(408,938);
                    lblRenewNotPsble.Text = "Dear " + StudLoginClick.name + ", only one renewal is allowed per book! ";
                    lblRenewNotPsble.Show();
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
                SqlCommand cmd1 = new SqlCommand("update tbl_StuBookdet set Renewal_date = '" + current + "' , Renewal_Return_date = '" + currentDate.AddDays(7).ToString("dd-MM-yyyy") + "' where Roll_No = " + Convert.ToInt32(txtRenewRn.Text) + " AND Book_Name = '" + comboRenew.SelectedItem.ToString() + "'", con1);
                cmd1.Parameters.AddWithValue("@Renewal_date", current);
                cmd1.Parameters.AddWithValue("@Renewal_Return_date", currentDate.AddDays(7).ToString("dd-MM-yyyy"));
                cmd1.ExecuteNonQuery();
                //MessageBox.Show("inserted");
                msgSend = 1;
                lblRenew.Text = "Dear " + StudLoginClick.name + ", your '" + comboRenew.SelectedItem.ToString() + "' book is RENEWED successfully! Please return it on or before " + currentDate.AddDays(7).ToString("dd-MM-yyyy") + " or else you would be liable to fine!";
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

            /*if (msgSend == 1)
            {
                const string accountSid = "ACc0314dbae755a0cd1fad3ad0ed3b29d1";
                const string authToken = "784d8f4dbaf1a3fc0e294ba2118e4a8f";

                TwilioClient.Init(accountSid, authToken);

                MessageResource.Create(

                     to: new PhoneNumber("+91" + phoneno),
                     from: new PhoneNumber("+12024002645"),
                     body: "Dear " + StudLoginClick.name + ", you have successfully RENEWED '" + bookName + "' (" + bookRfid + ") book on " + renew + " ! Please return it on or before " + returnAfterRenew + " or else you would be liable to fine!\n\nRegards,\nPATKAR LIBRARY!\n\nNote: This is an auto-generated text message, please do not reply.");

                MessageBox.Show("Message sent");
            }*/
        }

        string returnRn = null;
        string returnDate = null;
        string returnRenewalDate = null;
        string shelf = null;
        string bookRfid = null;
        int returnPossible = -1;

      

        int count = 30;

        private void tm_Tick(object sender, EventArgs e)
        {
            if(count<10)
            {
                txt_time.Text = "00:0" + count.ToString();
                txt_time.Show();
            }
            else
            {
                txt_time.Text = "00:" + count.ToString();
                txt_time.Show();
            }
           
            count--;
            if (count < 0)
            {
                tm.Enabled = false;
                WMPLib.WindowsMediaPlayer w1 = new WMPLib.WindowsMediaPlayer();
                w1.URL = "C:\\Users\\ADMIN\\Desktop\\project\\timesup-3sec.wav";
                w1.controls.play();

                returnMyBook();
            }



            //tm.Enabled = false;
        }

        private void returnMyBook()
        {

            SqlConnection con1 = new SqlConnection(str);

            if (returnPossible == 1)
            {
                string checkBkPstn = null;
                string shelfEmpty = null;
                SqlDataReader rdr2 = null;
                con1.Open();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_ReturnStatus where RollNo =" + Convert.ToInt32(txtReturnRn.Text) + " AND BookName='" + comboReturn.SelectedItem.ToString() + "' AND BookRFID = '" + txtReturnBookID.Text + "'", con1);
                cmd2.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtReturnRn.Text));
                cmd2.Parameters.AddWithValue("@BookName", comboReturn.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@BookRFID", txtReturnBookID.Text);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    checkBkPstn = rdr2["PlacedCorrect"].ToString();
                    shelfEmpty = rdr2["Shelf"].ToString();

                }

                rdr2.Close();
                con1.Close();
                //MessageBox.Show("csdcsd" + checkBkPstn);


                if (Convert.ToInt32(checkBkPstn) == -1)
                {
                    //MessageBox.Show("dhbsvw");
                    
                    lblTimesUp.Text = "Dear " + StudLoginClick.name + ", your time has expired! Please keep the book in alotted shelf within the given time!";
                    lblTimesUp.Show();
                    //MessageBox.Show("dhbsvssssssssssssssssw");
                }

                else if (Convert.ToInt32(checkBkPstn) == 1)
                {
                    SqlDataReader rdr = null;
                    con1.Open();
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_Booksdet where Book_Name='" + comboReturn.SelectedItem.ToString() + "'", con1);
                    cmd3.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                    rdr = cmd3.ExecuteReader();
                    while (rdr.Read())
                    {
                        bookName1 = rdr["Book_Name"].ToString();
                        shelf = rdr["Shelf_No"].ToString();
                        bookRfid = rdr["Book_RFID"].ToString();

                    }

                    rdr.Close();

                    if (bookRfid == txtReturnBookID.Text)
                    {
                        SqlCommand cmd1 = new SqlCommand("delete from tbl_StuBookdet where Roll_No = " + Convert.ToInt32(txtReturnRn.Text) + " AND Book_Name   ='" + comboReturn.SelectedItem.ToString() + "' AND Book_RFID = '" + txtReturnBookID.Text + "' ", con1);
                        cmd1.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtReturnRn.Text));
                        cmd1.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                        cmd1.Parameters.AddWithValue("@Book_RFID", txtReturnBookID.Text);
                        cmd1.ExecuteNonQuery();
                        //MessageBox.Show("inserted");
                        lblReturned.Text = "Dear " + StudLoginClick.name + ", your '" + comboReturn.SelectedItem.ToString() + "' book is RETURNED successfully!";
                        lblReturned.Show();

                    }


                }

                else
                {
                    //lblReturn.Location = new Point(225, 300);
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", you have to place the book in shelf '" + shelf + "'";
                    lblReturn.Show();
                    
                    lblReturned.Text = "Dear " + StudLoginClick.name + ", your '" + comboReturn.SelectedItem.ToString() + "' book is NOT returned!";
                    lblReturned.Show();
                    lblTimesUp.Hide();
                }



            }

            if (returnPossible == 2)
            {
                string checkBkPstn = null;
                string shelfEmpty = null;
                SqlDataReader rdr2 = null;
                con1.Open();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_ReturnStatus where RollNo =" + Convert.ToInt32(txtReturnRn.Text) + " AND BookName='" + comboReturn.SelectedItem.ToString() + "' AND BookRFID = '" + txtReturnBookID.Text + "'", con1);
                cmd2.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtReturnRn.Text));
                cmd2.Parameters.AddWithValue("@BookName", comboReturn.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@BookRFID", txtReturnBookID.Text);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    checkBkPstn = rdr2["PlacedCorrect"].ToString();
                    shelfEmpty = rdr2["Shelf"].ToString();

                }

                rdr2.Close();
                con1.Close();
                MessageBox.Show("csdcsd" + checkBkPstn);


                if (Convert.ToInt32(checkBkPstn) == -1)
                {
                    
                    lblTimesUp.Text = "Dear " + StudLoginClick.name + ", your time has expired! Please keep the book in alotted shelf within the given time!";
                    lblTimesUp.Show();
                }

                else if (Convert.ToInt32(checkBkPstn) == 1)
                {

                    SqlDataReader rdr = null;
                    con1.Open();
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_Booksdet where Book_Name='" + comboReturn.SelectedItem.ToString() + "'", con1);
                    cmd3.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                    rdr = cmd3.ExecuteReader();
                    while (rdr.Read())
                    {
                        string bookName2 = rdr["Book_Name"].ToString();
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
                        lblReturned.Text = "Dear " + StudLoginClick.name + ", your renewed book '" + comboReturn.SelectedItem.ToString() + "' is RETURNED successfully!";
                        lblReturned.Show();

                    }


                }

                else
                {
                    //lblReturn.Location = new Point(225, 300);
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", you have to place the book in shelf '" + shelf + "'";
                    lblReturn.Show();
                }


            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            panel_Issue.Visible = false;
            panelRenew.Visible = false;
            panelLateFee.Visible = false;
            panelLibSchedule.Visible = false;
            panelLibRules.Visible = false;
            panelMyAccount.Visible = false;


            panelstu.Location = new Point(65, 18);
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //this.Close();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // logout();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void panelReturn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRenew_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Issue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRenew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelReturn_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click_2(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMiddle_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnSubmit_Click_1(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            string current = null;
            current = Date.ToString("dd-MM-yyyy");

            DateTime currentDate = DateTime.Parse(current);

            SqlConnection con1 = new SqlConnection(str);
            con1.Open();

            SqlDataReader rdr1 = null;

            //string renewalDate = null;

            SqlCommand cmd = new SqlCommand("select * from tbl_StuBookdet where Roll_No=" + Convert.ToInt32(txtReturnRn.Text) + " AND Book_Name = '" + comboReturn.SelectedItem.ToString() + "'", con1);
            cmd.Parameters.AddWithValue("@Roll_No", Convert.ToInt32(txtReturnRn.Text));
            cmd.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());

            rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                returnRn = rdr1["Roll_No"].ToString();
                returnDate = rdr1["Return_date"].ToString();
                returnRenewalDate = rdr1["Renewal_Return_date"].ToString();
                //MessageBox.Show("ncwchnw"+returnRenewalDate);

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

            if (returnPossible == 0)
            {
                //MessageBox.Show(" return NOT psble");
                lblReturned.Text = "Dear " + StudLoginClick.name + ", you have already crossed your return date, so check the fine section! ";
                lblReturned.Show();
            }

            string initialPlacedCorrect = "-1";

            if (returnPossible == 1 || returnPossible == 2)
            {
                int checkRowExist = -1;

                con1.Open();
                //MessageBox.Show("select ke pehle...");
                //MessageBox.Show("select"+ Convert.ToInt32(txtReturnRn.Text));
                //MessageBox.Show("select"+ comboReturn.SelectedItem.ToString());

                SqlDataReader rdrr = null;
                SqlCommand cmdd = new SqlCommand("select * from tbl_ReturnStatus where RollNo=" + Convert.ToInt32(txtReturnRn.Text) + " AND BookName = '" + comboReturn.SelectedItem.ToString() + "'", con1);
                cmdd.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtReturnRn.Text));
                cmdd.Parameters.AddWithValue("@BookName", comboReturn.SelectedItem.ToString());
                cmdd.ExecuteNonQuery();
                rdrr = cmdd.ExecuteReader();
                if (rdrr.Read())
                {
                    checkRowExist = 1;

                }
                else
                {
                    checkRowExist = 0;
                }

                rdrr.Close();

                //MessageBox.Show("wc  " + checkRowExist);

                if (checkRowExist == 1)
                {
                    SqlDataReader rdr5 = null;
                    SqlCommand cmd5 = new SqlCommand("update tbl_ReturnStatus set PlacedCorrect=" + Convert.ToInt32("-1") + " where RollNo=" + Convert.ToInt32(txtReturnRn.Text) + " AND BookName='" + comboReturn.SelectedItem.ToString() + "' AND BookRFID ='" + txtReturnBookID.Text + "'", con1);
                    cmd5.Parameters.AddWithValue("@PlacedCorrect", Convert.ToInt32("-1"));
                    cmd5.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtReturnRn.Text));
                    cmd5.Parameters.AddWithValue("@BookName", comboReturn.SelectedItem.ToString());
                    cmd5.Parameters.AddWithValue("@BookRFID", txtReturnBookID.Text);
                    rdr5 = cmd5.ExecuteReader();
                    rdr5.Close();
                }

                if (checkRowExist == 0)
                {
                    SqlCommand cmd3 = new SqlCommand("insert into tbl_ReturnStatus(RollNo,BookName,BookRFID,PlacedCorrect) values (@RollNo,@BookName,@BookRFID,@PlacedCorrect)", con1);
                    cmd3.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtReturnRn.Text));
                    cmd3.Parameters.AddWithValue("@BookName", comboReturn.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("@BookRFID", txtReturnBookID.Text);
                    cmd3.Parameters.AddWithValue("@PlacedCorrect", Convert.ToInt32(initialPlacedCorrect));
                    cmd3.ExecuteNonQuery();

                }

                SqlDataReader rdr = null;
                SqlCommand cmd4 = new SqlCommand("select * from tbl_Booksdet where Book_Name='" + comboReturn.SelectedItem.ToString() + "'", con1);
                cmd4.Parameters.AddWithValue("@Book_Name", comboReturn.SelectedItem.ToString());
                rdr = cmd4.ExecuteReader();
                while (rdr.Read())
                {
                    bookName1 = rdr["Book_Name"].ToString();
                    shelf = rdr["Shelf_No"].ToString();
                    bookRfid = rdr["Book_RFID"].ToString();
                }

                rdr.Close();

                if (bookRfid == txtReturnBookID.Text)
                {
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", kindly place the '" + bookName1 + "' book in shelf " + shelf + ".";
                    lblReturn.Show();
                }

                else
                {
                    lblReturn.Text = "Dear " + StudLoginClick.name + ", you have scanned the wrong book! Please try again later!";
                    lblReturn.Show();
                }

                con1.Close();

                tm.Tick += new EventHandler(tm_Tick);
                tm.Interval = 1000;
                tm.Enabled = true;
                txt_time.Show();

            }



        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            panel_Issue.Visible = false;
            panelReturn.Visible = false;
            panelRenew.Visible = false;
            panelLibSchedule.Visible = false;
            panelLateFee.Visible = false;
            panelMyAccount.Visible = false;

            lblSuccess.Hide();
            lblReturned.Hide();
            lblRenew.Hide();
            lblRenewNotPsble.Hide();

            panelLibRules.Visible = true;

            panelstu.Location = new Point(65, 18);
        }

        private void btnFeeStructure_Click(object sender, EventArgs e)
        {
            panel_Issue.Visible = false;
            panelReturn.Visible = false;
            panelRenew.Visible = false;
            panelLibSchedule.Visible = false;
            panelLibRules.Visible = false;
            panelMyAccount.Visible = false;

            lblSuccess.Hide();
            lblReturned.Hide();
            lblRenew.Hide();
            lblRenewNotPsble.Hide();

            panelLateFee.Visible = true;

            panelstu.Location = new Point(65, 18);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            panel_Issue.Visible = false;
            panelReturn.Visible = false;
            panelRenew.Visible = false;
            panelLateFee.Visible = false;
            panelLibRules.Visible = false;
            panelMyAccount.Visible = false;
            lblSuccess.Hide();
            lblReturned.Hide();
            lblRenew.Hide();
            lblRenewNotPsble.Hide();

            panelLibSchedule.Visible = true;

            panelstu.Location = new Point(65, 18);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ins2_Click(object sender, EventArgs e)
        {

        }

        private void btnMiddle_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_3(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panel_Issue.Visible = false;
            panelReturn.Visible = false;
            panelRenew.Visible = false;
            panelLibSchedule.Visible = false;
            panelLateFee.Visible = false;
            panelLibRules.Visible = false;
            
            lblSuccess.Hide();
            lblReturned.Hide();
            lblRenew.Hide();
            lblRenewNotPsble.Hide();

            panelstu.Location = new Point(65, 18);

            panelMyAccount.Visible = true;

            txtStuName.Text = StudLoginClick.name;

            DateTime Date = DateTime.Now;
            string current = null;
            current = Date.ToString("dd-MM-yyyy");

            DateTime currentDate = DateTime.Parse(current);

            string StuRn = null;
            string StuRfid = null;
            string AdmsnYear = null;
            string IssuedBooks = null;
            string IssueDate = null;
            string RenewedBooks = null;
            string RenewDate = null;
            string checkRenew = null;
            string dateReturn = null;
            string dateReturnAfterRenew = null;
            double addFine = 0;
            int issueLate = -1;
            int renewLate = -1;

            SqlConnection con1 = new SqlConnection(str);
            
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Studentdet where RFID = '" + StudLoginClick.rfid + "'", con1);
            cmd.Parameters.AddWithValue("@RFID", StudLoginClick.rfid);
            SqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                StuRn = rdr["RollNo"].ToString();
                StuRfid = rdr["RFID"].ToString();
                AdmsnYear = rdr["Year_Of_Admsn"].ToString();
                if (rdr != null && rdr.HasRows)
                {
                    txtStuRn.Text = StuRn;
                    txtYearOfAdmsn.Text = AdmsnYear;
     
                }

            }
            rdr.Close();

            SqlCommand cmd1 = new SqlCommand("select * from tbl_StuBookdet where Stu_RFID='"+StudLoginClick.rfid+"'", con1);
            cmd1.Parameters.AddWithValue("@Stu_RFID", StudLoginClick.rfid);
            SqlDataReader rdr1 = null;
            rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                IssueDate = rdr1["Issue_date"].ToString();
                RenewDate = rdr1["Renewal_Return_date"].ToString();
                //MessageBox.Show("c" + RenewDate);
                //lblBooksRenewed.Text = RenewDate.GetType().FullName;
 
            }
            rdr1.Close();

            if (string.IsNullOrEmpty(IssueDate))
            {
                txtBooksIssued.Text = "None";
            }

         
            if (!string.IsNullOrEmpty(IssueDate))
            {
                SqlCommand cmd2 = new SqlCommand("select * from tbl_StuBookdet where Stu_RFID='" + StudLoginClick.rfid + "'", con1);
                cmd2.Parameters.AddWithValue("@Stu_RFID", StudLoginClick.rfid);
                SqlDataReader rdr2 = null;
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    IssuedBooks = rdr2["Book_Name"].ToString();
                    txtBooksIssued.Text += IssuedBooks + " ";
                   
                }
                rdr2.Close();

              

                if (RenewDate!=null)
                {
                    //MessageBox.Show("here");
                    txtBooksRenewed.Text = "";
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_StuBookdet where Stu_RFID='" + StudLoginClick.rfid + "'", con1);
                    cmd3.Parameters.AddWithValue("@Stu_RFID", StudLoginClick.rfid);
                    SqlDataReader rdr3 = null;
                    rdr3 = cmd3.ExecuteReader();
                    while (rdr3.Read())
                    {
                        checkRenew = rdr3["Renewal_date"].ToString();
                        if (!string.IsNullOrEmpty(checkRenew))
                        {
                            //MessageBox.Show("xax");
                            RenewedBooks = rdr3["Book_Name"].ToString();
                            //MessageBox.Show("show" + RenewedBooks);
                            txtBooksRenewed.Text += RenewedBooks + " ";
                            
                        }
                        
                    }
                    rdr3.Close();
                }

                if(string.IsNullOrWhiteSpace(txtBooksRenewed.Text))
                {
                    txtBooksRenewed.Text = "None";
                }
            }
            


            /*if (string.IsNullOrEmpty(RenewDate))
            {
                MessageBox.Show("not here");
                txtBooksRenewed.Text = "None";
            }*/


            

            if(!string.IsNullOrEmpty(IssueDate))
            {
                if (!string.IsNullOrEmpty(RenewDate))
                {
                    SqlCommand cmd4 = new SqlCommand("select * from tbl_StuBookdet where Stu_RFID='" + StudLoginClick.rfid + "'", con1);
                    cmd4.Parameters.AddWithValue("@Stu_RFID", StudLoginClick.rfid);
                    SqlDataReader rdr4 = null;
                    rdr4 = cmd4.ExecuteReader();
                    while (rdr4.Read())
                    {
                        dateReturnAfterRenew = rdr4["Renewal_Return_date"].ToString();
                        //MessageBox.Show("return aftre renewal : " + dateReturnAfterRenew);
                        if(!string.IsNullOrEmpty(dateReturnAfterRenew))
                        {
                            DateTime parsedDateReturnAfterRenew = DateTime.Parse(dateReturnAfterRenew);
                            if (rdr4.HasRows)
                            {
                                //lblRenew.Text += DateTime.Parse(renewalDate);

                                double result = (currentDate - parsedDateReturnAfterRenew).TotalDays;


                                if (result > 0 && result <= 10)
                                {
                                    addFine = addFine + (5 * result);
                                }
                                if (result > 10)
                                {
                                    addFine = addFine + 50;
                                    addFine = addFine + (15 * (result - 10));
                                }

                            }
                        }
                        

                    }
                    rdr4.Close();

                    txtFine.Text = "₹." + addFine.ToString();
                }

                
                //else
                //{
                    SqlCommand cmd5 = new SqlCommand("select * from tbl_StuBookdet where Stu_RFID='" + StudLoginClick.rfid + "'", con1);
                    cmd5.Parameters.AddWithValue("@Stu_RFID", StudLoginClick.rfid);
                    SqlDataReader rdr5 = null;
                    rdr5 = cmd5.ExecuteReader();
                    while (rdr5.Read())
                    {
                        dateReturn = rdr5["Return_date"].ToString();
                        string checkRenewOrNot = rdr5["Renewal_date"].ToString();
                        if (string.IsNullOrEmpty(checkRenewOrNot))
                        {
                            //lblRenew.Text += DateTime.Parse(renewalDate);

                            double result = (currentDate - (DateTime.Parse(dateReturn))).TotalDays;
                            //MessageBox.Show("result:" + result);

                            if (result > 0 && result <= 10)
                            {
                                addFine = addFine + (5 * result);
                            }
                            if (result > 10)
                            {
                                addFine = addFine + 50;
                                addFine = addFine + (15 * (result - 10));
                            }

                        }

                    }
                    rdr5.Close();

                    txtFine.Text = "₹." + addFine.ToString();
                //}
                    

                


            }

            con1.Close();

        }
    }
}