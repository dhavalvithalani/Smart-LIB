namespace AMS
{
    partial class EditBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.dataGridViewEditBook = new System.Windows.Forms.DataGridView();
            this.bookRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBooksdetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aMSDataSet7 = new AMS.AMSDataSet7();
            this.tblBooksdetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMSDataSet6 = new AMS.AMSDataSet6();
            this.tbl_BooksdetTableAdapter = new AMS.AMSDataSet6TableAdapters.tbl_BooksdetTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tbl_BooksdetTableAdapter1 = new AMS.AMSDataSet7TableAdapters.tbl_BooksdetTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aMSDataSet10 = new AMS.AMSDataSet10();
            this.tblBooksdetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BooksdetTableAdapter2 = new AMS.AMSDataSet10TableAdapters.tbl_BooksdetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksdetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksdetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet6)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksdetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select the grid which you want to edit and make the required changes...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(837, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 53);
            this.label7.TabIndex = 18;
            this.label7.Text = "EDIT BOOK DETAILS";
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.Location = new System.Drawing.Point(925, 875);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(238, 71);
            this.btnEditUpdate.TabIndex = 17;
            this.btnEditUpdate.Text = "UPDATE";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // dataGridViewEditBook
            // 
            this.dataGridViewEditBook.AutoGenerateColumns = false;
            this.dataGridViewEditBook.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewEditBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEditBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookRFIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.shelfNoDataGridViewTextBoxColumn,
            this.Shelf});
            this.dataGridViewEditBook.DataSource = this.tblBooksdetBindingSource2;
            this.dataGridViewEditBook.Location = new System.Drawing.Point(758, 178);
            this.dataGridViewEditBook.Name = "dataGridViewEditBook";
            this.dataGridViewEditBook.RowTemplate.Height = 24;
            this.dataGridViewEditBook.Size = new System.Drawing.Size(573, 202);
            this.dataGridViewEditBook.TabIndex = 16;
            this.dataGridViewEditBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEditBook_CellContentClick);
            // 
            // bookRFIDDataGridViewTextBoxColumn
            // 
            this.bookRFIDDataGridViewTextBoxColumn.DataPropertyName = "Book_RFID";
            this.bookRFIDDataGridViewTextBoxColumn.HeaderText = "Book_RFID";
            this.bookRFIDDataGridViewTextBoxColumn.Name = "bookRFIDDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // shelfNoDataGridViewTextBoxColumn
            // 
            this.shelfNoDataGridViewTextBoxColumn.DataPropertyName = "Shelf_No";
            this.shelfNoDataGridViewTextBoxColumn.HeaderText = "Shelf_No";
            this.shelfNoDataGridViewTextBoxColumn.Name = "shelfNoDataGridViewTextBoxColumn";
            // 
            // Shelf
            // 
            this.Shelf.DataPropertyName = "Shelf";
            this.Shelf.HeaderText = "Shelf";
            this.Shelf.Name = "Shelf";
            // 
            // tblBooksdetBindingSource1
            // 
            this.tblBooksdetBindingSource1.DataMember = "tbl_Booksdet";
            this.tblBooksdetBindingSource1.DataSource = this.aMSDataSet7;
            // 
            // aMSDataSet7
            // 
            this.aMSDataSet7.DataSetName = "AMSDataSet7";
            this.aMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBooksdetBindingSource
            // 
            this.tblBooksdetBindingSource.DataMember = "tbl_Booksdet";
            this.tblBooksdetBindingSource.DataSource = this.aMSDataSet6;
            // 
            // aMSDataSet6
            // 
            this.aMSDataSet6.DataSetName = "AMSDataSet6";
            this.aMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_BooksdetTableAdapter
            // 
            this.tbl_BooksdetTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1920, 27);
            this.fillByToolStrip.TabIndex = 20;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tbl_BooksdetTableAdapter1
            // 
            this.tbl_BooksdetTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2058, 252);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(994, 129);
            this.label3.MaximumSize = new System.Drawing.Size(1500, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = "SmartLIB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(241, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(172, 173);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 58);
            this.label2.MaximumSize = new System.Drawing.Size(1500, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1091, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = " PATKAR VARDE COLLEGE\'S ONLINE LIBRARY ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridViewEditBook);
            this.panel2.Location = new System.Drawing.Point(-1, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2200, 480);
            this.panel2.TabIndex = 22;
            // 
            // aMSDataSet10
            // 
            this.aMSDataSet10.DataSetName = "AMSDataSet10";
            this.aMSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBooksdetBindingSource2
            // 
            this.tblBooksdetBindingSource2.DataMember = "tbl_Booksdet";
            this.tblBooksdetBindingSource2.DataSource = this.aMSDataSet10;
            // 
            // tbl_BooksdetTableAdapter2
            // 
            this.tbl_BooksdetTableAdapter2.ClearBeforeFill = true;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksdetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksdetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet6)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksdetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.DataGridView dataGridViewEditBook;
        private AMSDataSet6 aMSDataSet6;
        private System.Windows.Forms.BindingSource tblBooksdetBindingSource;
        private AMSDataSet6TableAdapters.tbl_BooksdetTableAdapter tbl_BooksdetTableAdapter;
        private AMSDataSet7 aMSDataSet7;
        private System.Windows.Forms.BindingSource tblBooksdetBindingSource1;
        private AMSDataSet7TableAdapters.tbl_BooksdetTableAdapter tbl_BooksdetTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookRFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shelf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private AMSDataSet10 aMSDataSet10;
        private System.Windows.Forms.BindingSource tblBooksdetBindingSource2;
        private AMSDataSet10TableAdapters.tbl_BooksdetTableAdapter tbl_BooksdetTableAdapter2;
    }
}