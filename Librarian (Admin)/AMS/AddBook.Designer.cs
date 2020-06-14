namespace AMS
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TagId = new System.Windows.Forms.Label();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.lbl_ShelfNo = new System.Windows.Forms.Label();
            this.txt_booktag = new System.Windows.Forms.TextBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.txt_Shelfno = new System.Windows.Forms.TextBox();
            this.comboShelf = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.BackColor = System.Drawing.Color.Gold;
            this.btn_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBook.Location = new System.Drawing.Point(925, 875);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(238, 71);
            this.btn_AddBook.TabIndex = 21;
            this.btn_AddBook.Text = "ADD BOOK";
            this.btn_AddBook.UseVisualStyleBackColor = false;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2058, 252);
            this.panel1.TabIndex = 22;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 58);
            this.label1.MaximumSize = new System.Drawing.Size(1500, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1091, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = " PATKAR VARDE COLLEGE\'S ONLINE LIBRARY ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_TagId);
            this.panel2.Controls.Add(this.lbl_BookName);
            this.panel2.Controls.Add(this.lbl_ShelfNo);
            this.panel2.Controls.Add(this.txt_booktag);
            this.panel2.Controls.Add(this.txt_BookName);
            this.panel2.Controls.Add(this.txt_Shelfno);
            this.panel2.Controls.Add(this.comboShelf);
            this.panel2.Location = new System.Drawing.Point(-1, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2200, 480);
            this.panel2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Shelf  :";
            // 
            // lbl_TagId
            // 
            this.lbl_TagId.AutoSize = true;
            this.lbl_TagId.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_TagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TagId.Location = new System.Drawing.Point(784, 99);
            this.lbl_TagId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TagId.Name = "lbl_TagId";
            this.lbl_TagId.Size = new System.Drawing.Size(97, 29);
            this.lbl_TagId.TabIndex = 34;
            this.lbl_TagId.Text = "Tag ID :";
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(729, 176);
            this.lbl_BookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(152, 29);
            this.lbl_BookName.TabIndex = 35;
            this.lbl_BookName.Text = "Book Name :";
            // 
            // lbl_ShelfNo
            // 
            this.lbl_ShelfNo.AutoSize = true;
            this.lbl_ShelfNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_ShelfNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShelfNo.Location = new System.Drawing.Point(763, 324);
            this.lbl_ShelfNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShelfNo.Name = "lbl_ShelfNo";
            this.lbl_ShelfNo.Size = new System.Drawing.Size(118, 29);
            this.lbl_ShelfNo.TabIndex = 36;
            this.lbl_ShelfNo.Text = "Shelf No :";
            // 
            // txt_booktag
            // 
            this.txt_booktag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_booktag.Location = new System.Drawing.Point(916, 99);
            this.txt_booktag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_booktag.Name = "txt_booktag";
            this.txt_booktag.Size = new System.Drawing.Size(429, 34);
            this.txt_booktag.TabIndex = 33;
            // 
            // txt_BookName
            // 
            this.txt_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(916, 176);
            this.txt_BookName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(429, 34);
            this.txt_BookName.TabIndex = 37;
            // 
            // txt_Shelfno
            // 
            this.txt_Shelfno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Shelfno.Location = new System.Drawing.Point(916, 324);
            this.txt_Shelfno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Shelfno.Name = "txt_Shelfno";
            this.txt_Shelfno.Size = new System.Drawing.Size(429, 34);
            this.txt_Shelfno.TabIndex = 38;
            // 
            // comboShelf
            // 
            this.comboShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboShelf.FormattingEnabled = true;
            this.comboShelf.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboShelf.Location = new System.Drawing.Point(916, 245);
            this.comboShelf.Name = "comboShelf";
            this.comboShelf.Size = new System.Drawing.Size(121, 37);
            this.comboShelf.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(871, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 53);
            this.label7.TabIndex = 34;
            this.label7.Text = "ADD NEW BOOK";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TagId;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_ShelfNo;
        private System.Windows.Forms.TextBox txt_booktag;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.TextBox txt_Shelfno;
        private System.Windows.Forms.ComboBox comboShelf;
        private System.Windows.Forms.Label label7;
    }
}