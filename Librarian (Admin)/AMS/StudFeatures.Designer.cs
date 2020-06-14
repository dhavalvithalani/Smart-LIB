namespace AMS
{
    partial class StudFeatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudFeatures));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.txtReturnBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReturnSubmit = new System.Windows.Forms.Button();
            this.comboReturn = new System.Windows.Forms.ComboBox();
            this.txtReturnRn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblHideSeek = new System.Windows.Forms.Label();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.txtRn = new System.Windows.Forms.TextBox();
            this.lblRn = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRenew = new System.Windows.Forms.Panel();
            this.btnRenewSubmit = new System.Windows.Forms.Button();
            this.comboRenew = new System.Windows.Forms.ComboBox();
            this.txtRenewRn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.aMSDataSet2 = new AMS.AMSDataSet2();
            this.tblStuBookdetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StuBookdetTableAdapter = new AMS.AMSDataSet2TableAdapters.tbl_StuBookdetTableAdapter();
            this.lblRenew = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelReturn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRenew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStuBookdetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(427, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME STUDENT !";
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIssue.Location = new System.Drawing.Point(21, 260);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(161, 62);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRenew.Location = new System.Drawing.Point(21, 354);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(161, 62);
            this.btnRenew.TabIndex = 4;
            this.btnRenew.Text = "Renew Book";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Location = new System.Drawing.Point(21, 446);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 62);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblBookID);
            this.panel1.Controls.Add(this.panelRenew);
            this.panel1.Controls.Add(this.lblHideSeek);
            this.panel1.Controls.Add(this.btnMiddle);
            this.panel1.Controls.Add(this.txtRn);
            this.panel1.Controls.Add(this.lblRn);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.lblBookName);
            this.panel1.Location = new System.Drawing.Point(266, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 512);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(358, 382);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(624, 34);
            this.txtBookID.TabIndex = 12;
            // 
            // panelReturn
            // 
            this.panelReturn.Controls.Add(this.txtReturnBookID);
            this.panelReturn.Controls.Add(this.label6);
            this.panelReturn.Controls.Add(this.btnReturnSubmit);
            this.panelReturn.Controls.Add(this.comboReturn);
            this.panelReturn.Controls.Add(this.txtReturnRn);
            this.panelReturn.Controls.Add(this.label4);
            this.panelReturn.Controls.Add(this.label5);
            this.panelReturn.Location = new System.Drawing.Point(0, 0);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(1041, 512);
            this.panelReturn.TabIndex = 15;
            // 
            // txtReturnBookID
            // 
            this.txtReturnBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnBookID.Location = new System.Drawing.Point(358, 214);
            this.txtReturnBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnBookID.Name = "txtReturnBookID";
            this.txtReturnBookID.Size = new System.Drawing.Size(624, 34);
            this.txtReturnBookID.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Scan Your Book : ";
            // 
            // btnReturnSubmit
            // 
            this.btnReturnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnSubmit.Location = new System.Drawing.Point(405, 390);
            this.btnReturnSubmit.Name = "btnReturnSubmit";
            this.btnReturnSubmit.Size = new System.Drawing.Size(201, 54);
            this.btnReturnSubmit.TabIndex = 19;
            this.btnReturnSubmit.Text = "Submit";
            this.btnReturnSubmit.UseVisualStyleBackColor = true;
            this.btnReturnSubmit.Click += new System.EventHandler(this.btnReturnSubmit_Click);
            // 
            // comboReturn
            // 
            this.comboReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboReturn.FormattingEnabled = true;
            this.comboReturn.Location = new System.Drawing.Point(358, 137);
            this.comboReturn.Name = "comboReturn";
            this.comboReturn.Size = new System.Drawing.Size(624, 37);
            this.comboReturn.TabIndex = 18;
            this.comboReturn.Text = "Choose from below --";
            // 
            // txtReturnRn
            // 
            this.txtReturnRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnRn.Location = new System.Drawing.Point(358, 68);
            this.txtReturnRn.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnRn.Name = "txtReturnRn";
            this.txtReturnRn.ReadOnly = true;
            this.txtReturnRn.Size = new System.Drawing.Size(624, 34);
            this.txtReturnRn.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Roll No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Book Name : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(435, 435);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(201, 54);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(58, 385);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(224, 31);
            this.lblBookID.TabIndex = 11;
            this.lblBookID.Text = "Scan Your Book :";
            // 
            // lblHideSeek
            // 
            this.lblHideSeek.AutoSize = true;
            this.lblHideSeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideSeek.Location = new System.Drawing.Point(136, 297);
            this.lblHideSeek.Name = "lblHideSeek";
            this.lblHideSeek.Size = new System.Drawing.Size(64, 25);
            this.lblHideSeek.TabIndex = 10;
            this.lblHideSeek.Text = "label2";
            // 
            // btnMiddle
            // 
            this.btnMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiddle.Location = new System.Drawing.Point(435, 191);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(201, 54);
            this.btnMiddle.TabIndex = 9;
            this.btnMiddle.Text = "Search Your Book";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // txtRn
            // 
            this.txtRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRn.Location = new System.Drawing.Point(358, 39);
            this.txtRn.Margin = new System.Windows.Forms.Padding(4);
            this.txtRn.Name = "txtRn";
            this.txtRn.ReadOnly = true;
            this.txtRn.Size = new System.Drawing.Size(624, 38);
            this.txtRn.TabIndex = 8;
            // 
            // lblRn
            // 
            this.lblRn.AutoSize = true;
            this.lblRn.BackColor = System.Drawing.Color.Transparent;
            this.lblRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRn.Location = new System.Drawing.Point(58, 46);
            this.lblRn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRn.Name = "lblRn";
            this.lblRn.Size = new System.Drawing.Size(213, 31);
            this.lblRn.TabIndex = 7;
            this.lblRn.Text = "Enter Roll No : ";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(358, 105);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(624, 38);
            this.txtBookName.TabIndex = 6;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(58, 112);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(267, 31);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.Text = "Enter Book Name : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnIssue);
            this.panel2.Controls.Add(this.btnRenew);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Location = new System.Drawing.Point(49, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 512);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelRenew
            // 
            this.panelRenew.Controls.Add(this.btnRenewSubmit);
            this.panelRenew.Controls.Add(this.comboRenew);
            this.panelRenew.Controls.Add(this.txtRenewRn);
            this.panelRenew.Controls.Add(this.label2);
            this.panelRenew.Controls.Add(this.label3);
            this.panelRenew.Location = new System.Drawing.Point(73, 495);
            this.panelRenew.Name = "panelRenew";
            this.panelRenew.Size = new System.Drawing.Size(1041, 512);
            this.panelRenew.TabIndex = 15;
            this.panelRenew.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRenew_Paint_2);
            // 
            // btnRenewSubmit
            // 
            this.btnRenewSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewSubmit.Location = new System.Drawing.Point(410, 375);
            this.btnRenewSubmit.Name = "btnRenewSubmit";
            this.btnRenewSubmit.Size = new System.Drawing.Size(201, 54);
            this.btnRenewSubmit.TabIndex = 14;
            this.btnRenewSubmit.Text = "Submit";
            this.btnRenewSubmit.UseVisualStyleBackColor = true;
            this.btnRenewSubmit.Click += new System.EventHandler(this.btnRenewSubmit_Click_1);
            // 
            // comboRenew
            // 
            this.comboRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRenew.FormattingEnabled = true;
            this.comboRenew.Location = new System.Drawing.Point(363, 122);
            this.comboRenew.Name = "comboRenew";
            this.comboRenew.Size = new System.Drawing.Size(624, 37);
            this.comboRenew.TabIndex = 13;
            this.comboRenew.Text = "Choose from below --";
            // 
            // txtRenewRn
            // 
            this.txtRenewRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenewRn.Location = new System.Drawing.Point(363, 53);
            this.txtRenewRn.Margin = new System.Windows.Forms.Padding(4);
            this.txtRenewRn.Name = "txtRenewRn";
            this.txtRenewRn.ReadOnly = true;
            this.txtRenewRn.Size = new System.Drawing.Size(624, 34);
            this.txtRenewRn.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Roll No : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Book Name : ";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(65, 710);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 29);
            this.lblSuccess.TabIndex = 10;
            // 
            // aMSDataSet2
            // 
            this.aMSDataSet2.DataSetName = "AMSDataSet2";
            this.aMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStuBookdetBindingSource
            // 
            this.tblStuBookdetBindingSource.DataMember = "tbl_StuBookdet";
            this.tblStuBookdetBindingSource.DataSource = this.aMSDataSet2;
            // 
            // tbl_StuBookdetTableAdapter
            // 
            this.tbl_StuBookdetTableAdapter.ClearBeforeFill = true;
            // 
            // lblRenew
            // 
            this.lblRenew.AutoSize = true;
            this.lblRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenew.Location = new System.Drawing.Point(167, 714);
            this.lblRenew.Name = "lblRenew";
            this.lblRenew.Size = new System.Drawing.Size(79, 29);
            this.lblRenew.TabIndex = 15;
            this.lblRenew.Text = "label2";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(296, 714);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(79, 29);
            this.lblReturn.TabIndex = 16;
            this.lblReturn.Text = "label6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 813);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblRenew);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudFeatures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudFeatures";
            this.Load += new System.EventHandler(this.StudFeatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelRenew.ResumeLayout(false);
            this.panelRenew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStuBookdetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRn;
        private System.Windows.Forms.Label lblRn;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Label lblHideSeek;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSuccess;
        private AMSDataSet2 aMSDataSet2;
        private System.Windows.Forms.BindingSource tblStuBookdetBindingSource;
        private AMSDataSet2TableAdapters.tbl_StuBookdetTableAdapter tbl_StuBookdetTableAdapter;
        private System.Windows.Forms.Panel panelRenew;
        private System.Windows.Forms.Label lblRenew;
        private System.Windows.Forms.Button btnRenewSubmit;
        private System.Windows.Forms.ComboBox comboRenew;
        private System.Windows.Forms.TextBox txtRenewRn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Button btnReturnSubmit;
        private System.Windows.Forms.ComboBox comboReturn;
        private System.Windows.Forms.TextBox txtReturnRn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtReturnBookID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}