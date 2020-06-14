using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using WMPLib;


namespace AMS
{
    public partial class ReturnBookProcess : Form
    {
        
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID3;
        private SerialPort RFID4;
        private string DispString3;
        private string DispString4;
        int checkPort3 = -1;
        int checkPort4 = -1;
        public int placedCorrect = -1;
        //StudFeatures sf = new StudFeatures();
        //ReturnBookProcess rbp1 = new ReturnBookProcess();

        public ReturnBookProcess()
        {
            InitializeComponent();
        }

        private void txtReturnBookID_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string shelfA = "A";
            string shelfB = "B";

            if (checkPort3 == 1) {
                SqlConnection con = new SqlConnection(str);

                con.Open();

                SqlCommand cmd1 = new SqlCommand("update tbl_ReturnStatus set Shelf='"+shelfA+"' where BookRFID ='" + txtTag1.Text + "'", con);
                cmd1.Parameters.AddWithValue("@Shelf", shelfA);
                cmd1.Parameters.AddWithValue("@BookRFID", txtTag1.Text);
                int a = cmd1.ExecuteNonQuery();
                label1.Text += a.ToString();

                SqlCommand cmd2 = new SqlCommand("select * from tbl_Booksdet where Book_RFID ='" + txtTag1.Text + "'", con);
                cmd2.ExecuteNonQuery();

                SqlDataReader rdr = null;
                string bookRfid = null;
                string shelf = null;
                string shelfPstn = null;
                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    bookRfid = rdr["Book_RFID"].ToString();
                    shelf = rdr["Shelf"].ToString();
                    shelfPstn = rdr["Shelf_No"].ToString();
                    //MessageBox.Show("Stu RFId fetched");
                }
                rdr.Close();

                SqlCommand cmd3 = new SqlCommand("select * from tbl_ReturnStatus where BookRFID ='" + txtTag1.Text + "'", con);
                SqlDataReader rdr1 = null;
                string checkShelf = null;
                string rollNo = null;
                string bkName = null;
                rdr1 = cmd3.ExecuteReader();
                while (rdr1.Read())
                {
                    checkShelf = rdr1["Shelf"].ToString();
                    rollNo = rdr1["RollNo"].ToString();
                    bkName = rdr1["BookName"].ToString();
                    //MessageBox.Show("Stu RFId fetched");
                }
                rdr1.Close();

                if (string.Compare(shelf, checkShelf) == 0 && a!=0)
                {

                    placedCorrect = 1;
                    SqlCommand cmd4 = new SqlCommand("update tbl_ReturnStatus set PlacedCorrect=" + placedCorrect + " where BookRFID ='" + txtTag1.Text + "'", con);
                    cmd4.Parameters.AddWithValue("@PlacedCorrect", placedCorrect);
                    cmd4.Parameters.AddWithValue("@BookRFID", txtTag1.Text);
                    cmd4.ExecuteNonQuery();

                    label1.Text = "The book is placed in correct shelf !!";
                }
                else if(a!=0)
                {
                    placedCorrect = 0;
                    SqlCommand cmd4 = new SqlCommand("update tbl_ReturnStatus set PlacedCorrect=" + placedCorrect + " where BookRFID ='" + txtTag1.Text + "'", con);
                    cmd4.Parameters.AddWithValue("@PlacedCorrect", placedCorrect);
                    cmd4.Parameters.AddWithValue("@BookRFID", txtTag1.Text);
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = new SqlCommand("select * from tbl_Studentdet where RollNo ='" + Convert.ToInt32(rollNo) + "'", con);
                    SqlDataReader rdr2 = null;
                    string stuName = null;
                    rdr2 = cmd5.ExecuteReader();
                    while (rdr2.Read())
                    {
                        stuName = rdr2["Student_Name"].ToString();
                        //MessageBox.Show("Stu RFId fetched");
                    }
                    rdr2.Close();

                    if (label1.ForeColor != System.Drawing.Color.Red)
                    {
                        label1.ForeColor = System.Drawing.Color.Red;
                    }
                    label1.Text = "The book is NOT in correct shelf !!";
                    label3.Show();
                    label3.Text = stuName + " has misplaced '" + bkName + "' book! It has to be kept in " + shelfPstn + "!!";
                    WMPLib.WindowsMediaPlayer w1 = new WMPLib.WindowsMediaPlayer();
                    w1.URL = "C:\\Users\\ADMIN\\Desktop\\project\\wrongBook.mp3";
                    w1.controls.play();
                }
                else
                {
                    label1.Text = "The book is not scanned properly !!";
                }

            }


            if (checkPort4 == 1)
            {
                SqlConnection con = new SqlConnection(str);

                con.Open();

                SqlCommand cmd1 = new SqlCommand("update tbl_ReturnStatus set Shelf='" + shelfB + "' where BookRFID ='" + txtTag2.Text + "'", con);
                cmd1.Parameters.AddWithValue("@Shelf", shelfB);
                cmd1.Parameters.AddWithValue("@BookRFID", txtTag2.Text);
                int a = cmd1.ExecuteNonQuery();
                label2.Text += a.ToString();

                SqlCommand cmd2 = new SqlCommand("select * from tbl_Booksdet where Book_RFID ='" + txtTag2.Text + "'", con);
                cmd2.ExecuteNonQuery();

                SqlDataReader rdr = null;
                string bookRfid = null;
                string shelf = null;
                string shelfPstn = null;
                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    bookRfid = rdr["Book_RFID"].ToString();
                    //MessageBox.Show("book RFId fetched");
                    shelf = rdr["Shelf"].ToString();
                    shelfPstn = rdr["Shelf_No"].ToString();
                    //MessageBox.Show("Stu RFId fetched");
                }
                rdr.Close();

                SqlCommand cmd3 = new SqlCommand("select * from tbl_ReturnStatus where BookRFID ='" + txtTag2.Text + "'", con);
                SqlDataReader rdr1 = null;
                string checkShelf = null;
                string rollNo = null;
                string bkName = null;
                rdr1 = cmd3.ExecuteReader();
                while (rdr1.Read())
                {
                    checkShelf = rdr1["Shelf"].ToString();
                    rollNo = rdr1["RollNo"].ToString();
                    bkName = rdr1["BookName"].ToString();
                    //MessageBox.Show("Stu RFId fetched");
                }
                rdr1.Close();

                if (string.Compare(shelf, checkShelf) == 0 && a!=0)
                {
                    placedCorrect = 1;
                    SqlCommand cmd4 = new SqlCommand("update tbl_ReturnStatus set PlacedCorrect=" + placedCorrect + " where BookRFID ='" + txtTag2.Text + "'", con);
                    cmd4.Parameters.AddWithValue("@PlacedCorrect", placedCorrect);
                    cmd4.Parameters.AddWithValue("@BookRFID", txtTag2.Text);
                    cmd4.ExecuteNonQuery();
                    label2.Text = "The book is placed in correct shelf !!";
                }
                else if(a!=0)
                {
                    placedCorrect = 0;

                    SqlCommand cmd4 = new SqlCommand("update tbl_ReturnStatus set PlacedCorrect=" + placedCorrect + " where BookRFID ='" + txtTag2.Text + "'", con);
                    cmd4.Parameters.AddWithValue("@PlacedCorrect", placedCorrect);
                    cmd4.Parameters.AddWithValue("@BookRFID", txtTag2.Text);
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = new SqlCommand("select * from tbl_Studentdet where RollNo = " + Convert.ToInt32(rollNo) + " ", con);
                    SqlDataReader rdr2 = null;
                    string stuName = null;
                    rdr2 = cmd5.ExecuteReader();
                    while (rdr2.Read())
                    {
                        stuName = rdr2["Student_Name"].ToString();
                        //MessageBox.Show("Stu RFId fetched");
                    }
                    rdr2.Close();

                    if (label2.ForeColor != System.Drawing.Color.Red)
                    {
                        label2.ForeColor = System.Drawing.Color.Red;
                    }
                    label2.Text = "The book is NOT in correct shelf !!";
                    label4.Show();
                    label4.Text = stuName + " has misplaced '" + bkName + "' book! It has to be kept in " + shelfPstn + "!!";
                    WMPLib.WindowsMediaPlayer w1 = new WMPLib.WindowsMediaPlayer();
                    w1.URL = "C:\\Users\\ADMIN\\Desktop\\project\\wrongBook.mp3";
                    w1.controls.play();
                }
                else
                {
                    label2.Text = "The book is not scanned properly !!";
                }

            }



        }

        private void ReturnBookProcess_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();

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
                //MessageBox.Show("RFID 3 Open");
                DispString3 = "";
                
                txtTag1.Text = "";
               
               
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
                //MessageBox.Show("RFID 4 Open");
                DispString4 = "";
                txtTag2.Text = "";
                
            }
            else
            {
                RFID4.Close();
            }
            RFID4.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived4);

        }

        private void RFID_DataReceived3(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtTag1.Text.Length >= 12)
            {
                //MessageBox.Show(" COM 3 Length>=12");
                checkPort3 = 1;
                RFID3.Close();

            }
            else
            {
                DispString3 = RFID3.ReadExisting();
                //MessageBox.Show(" COM 3 Read existing");
                this.Invoke(new EventHandler(DisplayText3));
            }


        }

        private void DisplayText3(object sender, EventArgs e)
        {
            txtTag1.AppendText(DispString3);
        }

        private void RFID_DataReceived4(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtTag2.Text.Length >= 12)
            {
                //MessageBox.Show(" COM 4 Length>=12");
                checkPort4 = 1;
                RFID4.Close();

            }
            else
            {
                DispString4 = RFID4.ReadExisting();
                //MessageBox.Show(" COM 4 Read existing");
                this.Invoke(new EventHandler(DisplayText4));
            }

        }

        private void DisplayText4(object sender, EventArgs e)
        {
            txtTag2.AppendText(DispString4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RFID.Close();

            /*MessageBox.Show("start");
            RFID4 = new SerialPort();
            RFID4.PortName = "COM4";
            RFID4.BaudRate = 9600;
            RFID4.DataBits = 8;
            RFID4.Parity = Parity.None;
            RFID4.StopBits = StopBits.One;
            RFID4.Open();
            RFID4.ReadTimeout = 500;
            if (RFID4.IsOpen)
            {
                MessageBox.Show("com4 open");
                DispString2 = "";
                txtTag2.Text = "";
            }
            else
            {
                MessageBox.Show("com4 cloed");
                RFID4.Close();
            }
            RFID4.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived2);
        }*/
        }

       
        private void txtTag2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
