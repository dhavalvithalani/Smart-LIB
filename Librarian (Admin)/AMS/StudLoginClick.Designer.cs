namespace AMS
{
    partial class StudLoginClick
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
            this.txtwelcome = new System.Windows.Forms.Label();
            this.lblTagID = new System.Windows.Forms.Label();
            this.txttag1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStud = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtwelcome
            // 
            this.txtwelcome.AutoSize = true;
            this.txtwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtwelcome.Location = new System.Drawing.Point(320, 74);
            this.txtwelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtwelcome.Name = "txtwelcome";
            this.txtwelcome.Size = new System.Drawing.Size(673, 69);
            this.txtwelcome.TabIndex = 1;
            this.txtwelcome.Text = "WELCOME STUDENT!!";
            // 
            // lblTagID
            // 
            this.lblTagID.AutoSize = true;
            this.lblTagID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagID.Location = new System.Drawing.Point(326, 243);
            this.lblTagID.Name = "lblTagID";
            this.lblTagID.Size = new System.Drawing.Size(302, 31);
            this.lblTagID.TabIndex = 2;
            this.lblTagID.Text = "Waiting for Card Scan...";
            this.lblTagID.Click += new System.EventHandler(this.lblTagID_Click);
            // 
            // txttag1
            // 
            this.txttag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttag1.Location = new System.Drawing.Point(673, 243);
            this.txttag1.Name = "txttag1";
            this.txttag1.Size = new System.Drawing.Size(291, 34);
            this.txttag1.TabIndex = 3;
            this.txttag1.TextChanged += new System.EventHandler(this.txttag_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(562, 366);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(192, 58);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Click To Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStud
            // 
            this.lblStud.AutoSize = true;
            this.lblStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud.Location = new System.Drawing.Point(258, 525);
            this.lblStud.Name = "lblStud";
            this.lblStud.Size = new System.Drawing.Size(0, 29);
            this.lblStud.TabIndex = 5;
            this.lblStud.Click += new System.EventHandler(this.lblStud_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudLoginClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 697);
            this.Controls.Add(this.lblStud);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txttag1);
            this.Controls.Add(this.lblTagID);
            this.Controls.Add(this.txtwelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudLoginClick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudLoginClick";
            this.Load += new System.EventHandler(this.StudLoginClick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtwelcome;
        private System.Windows.Forms.Label lblTagID;
        private System.Windows.Forms.TextBox txttag1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStud;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}