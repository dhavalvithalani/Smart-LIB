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
    public partial class EditStudent : Form
    {
        string str = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter Adp;
        DataSet ds;
        SqlCommandBuilder cmd;

        public EditStudent()
        {
            InitializeComponent(); 
        }

        public bool IsPostBack { get; private set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDataSet9.tbl_Studentdet' table. You can move, or remove it, as needed.
            this.tbl_StudentdetTableAdapter1.Fill(this.aMSDataSet9.tbl_Studentdet);
           
            
            con = new SqlConnection(str);
            con.Open();
            Adp = new SqlDataAdapter("SELECT RFID, Student_Name, RollNo, Gender, Contact_No, Year_Of_Admsn FROM tbl_Studentdet", con);
            ds = new System.Data.DataSet();
            Adp.Fill(ds,"dbo.tbl_Studentdet");
            dataGridView1.DataSource = ds.Tables[0];


        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Adp);
            Adp.UpdateCommand = cmd.GetUpdateCommand();
            Adp.Update(ds,"dbo.tbl_Studentdet");
            MessageBox.Show("Student record updated successfully!!");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_StudentdetTableAdapter.FillBy(this.aMSDataSet1.tbl_Studentdet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
