using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace AMS
{
    public partial class AdminLoginProcess : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";

        public AdminLoginProcess()
        {
            InitializeComponent();
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "40PATKARCOLG00LIB62";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "40PATKARCOLG00LIB62";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void txtwelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int insertAdmin = -1;

            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select * from tbl_Admindet", con);
            SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
               string adminname = rd["adminName"].ToString();
               string pwd = rd["adminPwd"].ToString();

                if(adminname == txtUsername.Text || pwd == Encrypt(txtPwd.Text))
                {
                    MessageBox.Show("AdminName or Password already exists! Please try again!");
                    txtPwd.Text = "";
                    txtUsername.Text = "";
                    insertAdmin = 0;
                }

                else
                {
                    insertAdmin = 1;       
                }


            }
            con.Close();

            if(insertAdmin == 1)
            {
                SqlConnection con1 = new SqlConnection(str);
                con1.Open();

                SqlCommand cmd = new SqlCommand("insert into tbl_Admindet(adminName, adminPwd) values (@adminName, @adminPwd)", con1);
                cmd.Parameters.AddWithValue("@adminName", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@adminPwd", Encrypt(txtPwd.Text.Trim()));
                cmd.ExecuteNonQuery();

                con1.Close();

                MessageBox.Show("Admin added successfully!");
                txtPwd.Text = "";
                txtUsername.Text = "";
            }
            
           
        }

        private void AdminLoginProcess_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_adminlogin_Click(object sender, EventArgs e)
        {
            bool validAdmin = false;
            string pwd = null;

            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Admindet where adminName='" + txtUsername.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                pwd = rd["adminPwd"].ToString();

            }
            rd.Close();

            if (string.Compare(txtPwd.Text, Decrypt(pwd)) == 0)
            {
                validAdmin = true;
            }
            else
            {
                validAdmin = false;
            }
           
            if (validAdmin)
            {
                MessageBox.Show("Login valid ");
                AdminLoginClick newform = new AdminLoginClick();
                this.Hide();
                newform.ShowDialog();
                this.Show();

                txtPwd.Text = "";
                txtUsername.Text = "";
            }

            else
            {
                MessageBox.Show("Invalid username or password! Please try again!");
                txtPwd.Text = "";
                txtUsername.Text = "";
            }
        }
    }
}
