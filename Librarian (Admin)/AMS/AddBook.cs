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
    public partial class AddBook : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;
        

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
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
                txt_booktag.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);

        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (txt_booktag.Text.Length >= 12)
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
            txt_booktag.AppendText(DispString);
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            switch (btn_AddBook.Text)
            {
                case "Submit":
                    if (txt_booktag.Text.Length == 0 || txt_booktag.Text.Length == 0 || txt_booktag.Text.Length == 0)
                    { return; }
                    if (!CheckDuplicateRFID())
                    {
                        MessageBox.Show("Already Saved");
                        txt_booktag.Text = "";
                        return;
                    }
                    break;
            }
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_Booksdet(Book_RFID,Book_Name,Shelf_No,Shelf) values (@Book_RFID,@Book_Name,@Shelf_No,@Shelf)", con);
            cmd.Parameters.AddWithValue("@Book_RFID", txt_booktag.Text);
            cmd.Parameters.AddWithValue("@Book_Name", txt_BookName.Text);
            cmd.Parameters.AddWithValue("@Shelf_No", txt_Shelfno.Text);
            cmd.Parameters.AddWithValue("@Shelf", comboShelf.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            if(string.Compare(comboShelf.SelectedItem.ToString(),"A") == 0)
            {
                SqlCommand cmd1 = new SqlCommand("insert into tbl_Shelfdet_A(bookRFID,bookName) values (@bookRFID,@bookName)", con);
                cmd1.Parameters.AddWithValue("@bookRFID", txt_booktag.Text);
                cmd1.Parameters.AddWithValue("@bookName", txt_BookName.Text);
                cmd1.ExecuteNonQuery();
            }

            if (string.Compare(comboShelf.SelectedItem.ToString(), "B") == 0)
            {
                SqlCommand cmd1 = new SqlCommand("insert into tbl_Shelfdet_B(bookRFID,bookName) values (@bookRFID,@bookName)", con);
                cmd1.Parameters.AddWithValue("@bookRFID", txt_booktag.Text);
                cmd1.Parameters.AddWithValue("@bookName", txt_BookName.Text);
                cmd1.ExecuteNonQuery();
            }

            MessageBox.Show("Book Added Successfully!");
            con.Close();

        }
        private bool CheckDuplicateRFID()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Booksdet where Book_RFID='" + txt_booktag.Text + "'", con);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ShelfNo_Click(object sender, EventArgs e)
        {

        }

        private void comboShelf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
