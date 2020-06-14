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
using Microsoft.VisualBasic;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using Timer = System.Windows.Forms.Timer;

namespace AMS
{
    public partial class HomePage : Form
    {

        private Timer tm = new Timer();
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginProcess newform = new AdminLoginProcess();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btnStudLogin_Click(object sender, EventArgs e)
        {
            /*StudLoginClick newform = new StudLoginClick();
            this.Hide();
            newform.ShowDialog();
            this.Show();*/
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
            Timer tmPic = new Timer();
            tmPic.Interval = 3000;
            tmPic.Tick += new EventHandler(changePics);
            tmPic.Start();

            /* string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
             SqlConnection con1 = new SqlConnection(str);
             con1.Open();

             DateTime Date = DateTime.Now;
             string current = null;
             current = Date.ToString("dd-MM-yyyy");
             DateTime currentDate = DateTime.Parse(current);
             //MessageBox.Show("currentDate" + currentDate);

             SqlDataReader rdr1 = null;
             string bookRfid = null;
             string bookName = null;
             string rollNo = null;
             string returnDate = null;
             string renewedReturnDate = null;
             int hasRenewed = -1;

             SqlCommand cmd = new SqlCommand("select * from tbl_StuBookdet where Return_date = '" + currentDate.AddDays(1).ToString("dd-MM-yyyy") + "'", con1);
             cmd.Parameters.AddWithValue("@Return_date", currentDate.AddDays(1).ToString("dd-MM-yyyy"));

             rdr1 = cmd.ExecuteReader();
             while (rdr1.Read())
             {
                 bookRfid = rdr1["Book_RFID"].ToString();
                 bookName = rdr1["Book_Name"].ToString();
                 rollNo = rdr1["Roll_No"].ToString();
                 returnDate = rdr1["Return_date"].ToString();
                 renewedReturnDate = rdr1["Renewal_Return_date"].ToString();

                 if (string.IsNullOrEmpty(renewedReturnDate))
                 {
                     hasRenewed = 0;
                 }
                 else
                 {
                     hasRenewed = 1;
                 }
             }

             rdr1.Close();


             if (hasRenewed == 1)
             {

                 SqlCommand cmd2 = new SqlCommand("select * from tbl_StuBookdet where Renewal_Return_date = '" + currentDate.AddDays(1).ToString("dd-MM-yyyy") + "'", con1);
                 cmd2.Parameters.AddWithValue("@Renewal_Return_date", currentDate.AddDays(1).ToString("dd-MM-yyyy"));

                 rdr1 = cmd2.ExecuteReader();
                 while (rdr1.Read())
                 {
                     bookRfid = rdr1["Book_RFID"].ToString();
                     bookName = rdr1["Book_Name"].ToString();
                     rollNo = rdr1["Roll_No"].ToString();
                     returnDate = rdr1["Renewal_Return_date"].ToString();

                 }

                 rdr1.Close();
             }


            MessageBox.Show("hdsb" + bookRfid + " " + bookName+" "+rollNo+" "+returnDate);

             SqlDataReader rdr2 = null;
             string name = null;
             string phone = null;


             SqlCommand cmd1 = new SqlCommand("select * from tbl_Studentdet where RollNo=" + Convert.ToInt32(rollNo) + " ", con1);
             cmd1.Parameters.AddWithValue("@RollNo", Convert.ToInt32(rollNo));

             rdr2 = cmd1.ExecuteReader();
             while (rdr2.Read())
             {
                 name = rdr2["Student_Name"].ToString();
                 phone = rdr2["Contact_No"].ToString();
                 //rollNo = rdr1["Roll_No"].ToString();
                 //returnDate = rdr1["Return_date"].ToString();

             }

             //MessageBox.Show("hdsb" + name + " " + phone);

             rdr2.Close();

             if (string.Compare(name,"Dhaval") == 0)
             {
                 if(hasRenewed == 0)
                 {
                     const string accountSid = "ACc0314dbae755a0cd1fad3ad0ed3b29d1";
                     const string authToken = "784d8f4dbaf1a3fc0e294ba2118e4a8f";

                     TwilioClient.Init(accountSid, authToken);

                     MessageResource.Create(

                          to: new PhoneNumber("+91" + phone),
                          from: new PhoneNumber("+12024002645"),
                          body: "Dear " + name + " , kindly return the ISSUED '" + bookName + "' book by tomorrow (" + returnDate + ") or renew it!\n\nRegards,\nPATKAR LIBRARY!\n\nNote: This is an auto-generated text message, please do not reply.");

                     //MessageBox.Show("Message sent");
                 }

                 if(hasRenewed == 1)
                 {
                     const string accountSid = "ACc0314dbae755a0cd1fad3ad0ed3b29d1";
                     const string authToken = "784d8f4dbaf1a3fc0e294ba2118e4a8f";

                     TwilioClient.Init(accountSid, authToken);

                     MessageResource.Create(

                          to: new PhoneNumber("+91" + phone),
                          from: new PhoneNumber("+12024002645"),
                          body: "Dear " + name + " , kindly return the RENEWED '" + bookName + "' book by tomorrow (" + returnDate + ") or else you will be liable to fine!\n\nRegards,\nPATKAR LIBRARY!\n\nNote: This is an auto-generated text message, please do not reply.");

                     //MessageBox.Show("Message sent");
                 }


             }



          */
        }

        private void changePics(object sender, EventArgs e)
        {

            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._1);
            b1.Add(Properties.Resources._2);
            b1.Add(Properties.Resources._3);
            b1.Add(Properties.Resources._4);
            int index = DateTime.Now.Second % b1.Count;
            pictureBox1.Image = b1[index];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBookProcess newform = new ReturnBookProcess();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }
    }
}
