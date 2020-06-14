using System;

namespace AMS
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.amsDataSet1 = new AMS.AMSDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_pic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.comboclass = new System.Windows.Forms.ComboBox();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtstudname = new System.Windows.Forms.TextBox();
            this.lbl_admsn = new System.Windows.Forms.Label();
            this.lbl_rn = new System.Windows.Forms.Label();
            this.lbl_stud = new System.Windows.Forms.Label();
            this.lbl_tagid = new System.Windows.Forms.Label();
            this.txttag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Gold;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.Black;
            this.btnsubmit.Location = new System.Drawing.Point(597, 875);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(238, 71);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Gold;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(1308, 875);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(238, 71);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // amsDataSet1
            // 
            this.amsDataSet1.DataSetName = "AMSDataSet";
            this.amsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.RightToLeftChanged += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.RightToLeftChanged += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.RightToLeftChanged += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
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
            this.panel1.TabIndex = 19;
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
            this.panel2.Controls.Add(this.btn_pic);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtcontact);
            this.panel2.Controls.Add(this.lbl_phone);
            this.panel2.Controls.Add(this.female);
            this.panel2.Controls.Add(this.male);
            this.panel2.Controls.Add(this.lbl_gender);
            this.panel2.Controls.Add(this.comboclass);
            this.panel2.Controls.Add(this.txtrollno);
            this.panel2.Controls.Add(this.txtstudname);
            this.panel2.Controls.Add(this.lbl_admsn);
            this.panel2.Controls.Add(this.lbl_rn);
            this.panel2.Controls.Add(this.lbl_stud);
            this.panel2.Controls.Add(this.lbl_tagid);
            this.panel2.Controls.Add(this.txttag);
            this.panel2.Location = new System.Drawing.Point(-1, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2200, 480);
            this.panel2.TabIndex = 20;
            // 
            // btn_pic
            // 
            this.btn_pic.BackColor = System.Drawing.Color.White;
            this.btn_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pic.ForeColor = System.Drawing.Color.Black;
            this.btn_pic.Location = new System.Drawing.Point(1482, 185);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(148, 38);
            this.btn_pic.TabIndex = 38;
            this.btn_pic.Text = "Choose Image";
            this.btn_pic.UseVisualStyleBackColor = false;
            this.btn_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(1482, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(834, 317);
            this.txtcontact.MaxLength = 10;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(528, 34);
            this.txtcontact.TabIndex = 36;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(477, 320);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(150, 29);
            this.lbl_phone.TabIndex = 35;
            this.lbl_phone.Text = "Contact No. :";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(1039, 252);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(116, 33);
            this.female.TabIndex = 34;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(834, 252);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(87, 33);
            this.male.TabIndex = 33;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(477, 256);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(106, 29);
            this.lbl_gender.TabIndex = 32;
            this.lbl_gender.Text = "Gender :";
            // 
            // comboclass
            // 
            this.comboclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclass.FormattingEnabled = true;
            this.comboclass.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboclass.Location = new System.Drawing.Point(834, 386);
            this.comboclass.Margin = new System.Windows.Forms.Padding(4);
            this.comboclass.Name = "comboclass";
            this.comboclass.Size = new System.Drawing.Size(260, 37);
            this.comboclass.TabIndex = 30;
            // 
            // txtrollno
            // 
            this.txtrollno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrollno.Location = new System.Drawing.Point(833, 185);
            this.txtrollno.Margin = new System.Windows.Forms.Padding(4);
            this.txtrollno.MaxLength = 4;
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(528, 34);
            this.txtrollno.TabIndex = 29;
            // 
            // txtstudname
            // 
            this.txtstudname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudname.Location = new System.Drawing.Point(833, 116);
            this.txtstudname.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudname.Name = "txtstudname";
            this.txtstudname.Size = new System.Drawing.Size(528, 34);
            this.txtstudname.TabIndex = 28;
            // 
            // lbl_admsn
            // 
            this.lbl_admsn.AutoSize = true;
            this.lbl_admsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admsn.Location = new System.Drawing.Point(477, 393);
            this.lbl_admsn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admsn.Name = "lbl_admsn";
            this.lbl_admsn.Size = new System.Drawing.Size(225, 29);
            this.lbl_admsn.TabIndex = 27;
            this.lbl_admsn.Text = "Year Of Admission :";
            // 
            // lbl_rn
            // 
            this.lbl_rn.AutoSize = true;
            this.lbl_rn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rn.Location = new System.Drawing.Point(477, 188);
            this.lbl_rn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rn.Name = "lbl_rn";
            this.lbl_rn.Size = new System.Drawing.Size(106, 29);
            this.lbl_rn.TabIndex = 26;
            this.lbl_rn.Text = "Roll No :";
            // 
            // lbl_stud
            // 
            this.lbl_stud.AutoSize = true;
            this.lbl_stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud.Location = new System.Drawing.Point(477, 119);
            this.lbl_stud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stud.Name = "lbl_stud";
            this.lbl_stud.Size = new System.Drawing.Size(178, 29);
            this.lbl_stud.TabIndex = 25;
            this.lbl_stud.Text = "Student Name :";
            // 
            // lbl_tagid
            // 
            this.lbl_tagid.AutoSize = true;
            this.lbl_tagid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tagid.Location = new System.Drawing.Point(477, 47);
            this.lbl_tagid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tagid.Name = "lbl_tagid";
            this.lbl_tagid.Size = new System.Drawing.Size(97, 29);
            this.lbl_tagid.TabIndex = 24;
            this.lbl_tagid.Text = "Tag ID :";
            // 
            // txttag
            // 
            this.txttag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttag.Location = new System.Drawing.Point(834, 41);
            this.txttag.Margin = new System.Windows.Forms.Padding(4);
            this.txttag.MaxLength = 100;
            this.txttag.Name = "txttag";
            this.txttag.Size = new System.Drawing.Size(528, 34);
            this.txttag.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(881, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(417, 53);
            this.label7.TabIndex = 32;
            this.label7.Text = "ADD NEW STUDENT ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(975, 126);
            this.label3.MaximumSize = new System.Drawing.Size(1500, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 56);
            this.label3.TabIndex = 15;
            this.label3.Text = "SmartLIB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD STUDENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancel;
        private AMSDataSet amsDataSet1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox comboclass;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtstudname;
        private System.Windows.Forms.Label lbl_admsn;
        private System.Windows.Forms.Label lbl_rn;
        private System.Windows.Forms.Label lbl_stud;
        private System.Windows.Forms.Label lbl_tagid;
        private System.Windows.Forms.TextBox txttag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}