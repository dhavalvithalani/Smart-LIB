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

namespace AMS
{
    public partial class ReturnBookProcess : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;

       

        public ReturnBookProcess()
        {
            InitializeComponent();
        }

        private void txtReturnBookID_TextChanged(object sender, EventArgs e)
        {
            

            

        }

        private void RFID_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {

            if (txtTag1.Text.Length >= 12)
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
            txtTag1.AppendText(DispString);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
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
                txtTag1.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived1);

            int placedCorrect = -1;

            SqlConnection con = new SqlConnection(str);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("update tbl_ReturnStatus set Shelf='A' where BookRFID ='" + txtTag1.Text + "'", con);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("select * from tbl_Booksdet where Book_RFID ='" + txtTag1.Text + "'", con);
            cmd2.ExecuteNonQuery();

            SqlDataReader rdr = null;
            string bookRfid = null;
            string shelf = null;
            rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                bookRfid = rdr["Book_RFID"].ToString();
                shelf = rdr["Shelf"].ToString();
                //MessageBox.Show("Stu RFId fetched");
            }
            rdr.Close();

            SqlCommand cmd3 = new SqlCommand("select * from tbl_ReturnStatus where BookRFID ='" + txtTag1.Text + "'", con);
            SqlDataReader rdr1 = null;
            string checkShelf = null;
            rdr1 = cmd3.ExecuteReader();
            while (rdr1.Read())
            {
                checkShelf = rdr1["Shelf"].ToString();
                //MessageBox.Show("Stu RFId fetched");
            }
            rdr1.Close();

            if(string.Compare(shelf,checkShelf) == 0)
            {
                placedCorrect = 1;
                label1.Text += "The book is placed in correct shelf!!!";
            }
            else
            {
                placedCorrect = 0;
                label1.Text += "The book is NOT in correct shelf!!!";
            }

        }
    }
}
