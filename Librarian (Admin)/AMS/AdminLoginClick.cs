using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class AdminLoginClick : Form
    {
        public AdminLoginClick()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent newform = new AddStudent();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveStudent newform = new RemoveStudent();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudent newform = new EditStudent();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_EditBook_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminLoginClick_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AddBook_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_RemoveBook_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_EditBook_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_2(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook newform = new AddBook();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            RemoveBookInfo newform = new RemoveBookInfo();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            EditBook newform = new EditBook();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }
    }
}
