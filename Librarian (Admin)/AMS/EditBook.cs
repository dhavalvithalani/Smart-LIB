using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class EditBook : Form
    {

        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter Adp;
        DataSet ds;
        SqlCommandBuilder cmd;


        public EditBook()
        {
            InitializeComponent();
        }

        private void dataGridViewEditBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet10.tbl_Booksdet' table. You can move, or remove it, as needed.
            this.tbl_BooksdetTableAdapter2.Fill(this.aMSDataSet10.tbl_Booksdet);
            // TODO: This line of code loads data into the 'aMSDataSet7.tbl_Booksdet' table. You can move, or remove it, as needed.
            this.tbl_BooksdetTableAdapter1.Fill(this.aMSDataSet7.tbl_Booksdet);
            // TODO: This line of code loads data into the 'aMSDataSet6.tbl_Booksdet' table. You can move, or remove it, as needed.
            this.tbl_BooksdetTableAdapter.Fill(this.aMSDataSet6.tbl_Booksdet);
            con = new SqlConnection(str);
            con.Open();
            Adp = new SqlDataAdapter("SELECT Book_RFID, Book_Name, Shelf_No FROM tbl_Booksdet", con);
            ds = new System.Data.DataSet();
            Adp.Fill(ds, "dbo.tbl_Booksdet");
            dataGridViewEditBook.DataSource = ds.Tables[0];

        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Adp);
            Adp.UpdateCommand = cmd.GetUpdateCommand();
            Adp.Update(ds, "dbo.tbl_Booksdet");
            MessageBox.Show("Book record updated successfully!!");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_BooksdetTableAdapter1.FillBy(this.aMSDataSet7.tbl_Booksdet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
