namespace AMS
{
    partial class RemoveBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBookInfo));
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblRn = new System.Windows.Forms.Label();
            this.txtBookTagID = new System.Windows.Forms.TextBox();
            this.lblScanID = new System.Windows.Forms.Label();
            this.RBBookName = new System.Windows.Forms.RadioButton();
            this.RBBooktag = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltxtBk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.Gold;
            this.btnRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBook.Location = new System.Drawing.Point(923, 339);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(238, 71);
            this.btnRemoveBook.TabIndex = 31;
            this.btnRemoveBook.Text = "REMOVE";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(952, 205);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(400, 38);
            this.txtBookName.TabIndex = 30;
            // 
            // lblRn
            // 
            this.lblRn.AutoSize = true;
            this.lblRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRn.Location = new System.Drawing.Point(656, 210);
            this.lblRn.Name = "lblRn";
            this.lblRn.Size = new System.Drawing.Size(242, 31);
            this.lblRn.TabIndex = 29;
            this.lblRn.Text = "Enter Book Name :";
            // 
            // txtBookTagID
            // 
            this.txtBookTagID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTagID.Location = new System.Drawing.Point(952, 162);
            this.txtBookTagID.Name = "txtBookTagID";
            this.txtBookTagID.Size = new System.Drawing.Size(400, 38);
            this.txtBookTagID.TabIndex = 28;
            // 
            // lblScanID
            // 
            this.lblScanID.AutoSize = true;
            this.lblScanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanID.Location = new System.Drawing.Point(656, 167);
            this.lblScanID.Name = "lblScanID";
            this.lblScanID.Size = new System.Drawing.Size(240, 31);
            this.lblScanID.TabIndex = 27;
            this.lblScanID.Text = "Scan Book\'s Tag : ";
            // 
            // RBBookName
            // 
            this.RBBookName.AutoSize = true;
            this.RBBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBookName.Location = new System.Drawing.Point(1202, 98);
            this.RBBookName.Name = "RBBookName";
            this.RBBookName.Size = new System.Drawing.Size(215, 35);
            this.RBBookName.TabIndex = 26;
            this.RBBookName.TabStop = true;
            this.RBBookName.Text = "By Book Name";
            this.RBBookName.UseVisualStyleBackColor = true;
            this.RBBookName.CheckedChanged += new System.EventHandler(this.RBBookName_CheckedChanged);
            // 
            // RBBooktag
            // 
            this.RBBooktag.AutoSize = true;
            this.RBBooktag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBooktag.Location = new System.Drawing.Point(1007, 98);
            this.RBBooktag.Name = "RBBooktag";
            this.RBBooktag.Size = new System.Drawing.Size(156, 35);
            this.RBBooktag.TabIndex = 25;
            this.RBBooktag.TabStop = true;
            this.RBBooktag.Text = "By Tag ID";
            this.RBBooktag.UseVisualStyleBackColor = true;
            this.RBBooktag.CheckedChanged += new System.EventHandler(this.RBBooktag_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Select your option :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(867, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 53);
            this.label7.TabIndex = 23;
            this.label7.Text = "REMOVE BOOK";
            // 
            // lbltxtBk
            // 
            this.lbltxtBk.AutoSize = true;
            this.lbltxtBk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtBk.ForeColor = System.Drawing.Color.Red;
            this.lbltxtBk.Location = new System.Drawing.Point(515, 890);
            this.lbltxtBk.Name = "lbltxtBk";
            this.lbltxtBk.Size = new System.Drawing.Size(198, 29);
            this.lbltxtBk.TabIndex = 32;
            this.lbltxtBk.Text = "lblRemoveBook";
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
            this.panel1.TabIndex = 33;
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
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RBBooktag);
            this.panel2.Controls.Add(this.RBBookName);
            this.panel2.Controls.Add(this.btnRemoveBook);
            this.panel2.Controls.Add(this.lblScanID);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtBookTagID);
            this.panel2.Controls.Add(this.lblRn);
            this.panel2.Location = new System.Drawing.Point(-1, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2200, 480);
            this.panel2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(730, 890);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            // 
            // RemoveBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltxtBk);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoveBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveBookInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RemoveBookInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblRn;
        private System.Windows.Forms.TextBox txtBookTagID;
        private System.Windows.Forms.Label lblScanID;
        private System.Windows.Forms.RadioButton RBBookName;
        private System.Windows.Forms.RadioButton RBBooktag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltxtBk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}