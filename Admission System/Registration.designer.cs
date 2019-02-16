namespace Admission_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.getFNameBox = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.fNameLabel = new System.Windows.Forms.TextBox();
            this.LblRegistrationTitle = new System.Windows.Forms.Label();
            this.getLNameBox = new System.Windows.Forms.TextBox();
            this.getUserNameBox = new System.Windows.Forms.TextBox();
            this.getPassBox = new System.Windows.Forms.TextBox();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnOther = new System.Windows.Forms.RadioButton();
            this.LblInquiryGender = new System.Windows.Forms.Label();
            this.LblRegistrationSubtitle = new System.Windows.Forms.Label();
            this.LblGenderDesc = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblFNameStar = new System.Windows.Forms.Label();
            this.lblUNameStar = new System.Windows.Forms.Label();
            this.lblPassStar = new System.Windows.Forms.Label();
            this.lblGenderStar = new System.Windows.Forms.Label();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getFNameBox
            // 
            this.getFNameBox.Location = new System.Drawing.Point(1000, 279);
            this.getFNameBox.Name = "getFNameBox";
            this.getFNameBox.Size = new System.Drawing.Size(122, 20);
            this.getFNameBox.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(1189, 500);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 32);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // fNameLabel
            // 
            this.fNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameLabel.Enabled = false;
            this.fNameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ForeColor = System.Drawing.Color.Green;
            this.fNameLabel.Location = new System.Drawing.Point(1000, 252);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(85, 22);
            this.fNameLabel.TabIndex = 13;
            this.fNameLabel.Text = "First Name";
            this.fNameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRegistrationTitle
            // 
            this.LblRegistrationTitle.AutoSize = true;
            this.LblRegistrationTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRegistrationTitle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LblRegistrationTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRegistrationTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrationTitle.ForeColor = System.Drawing.Color.Green;
            this.LblRegistrationTitle.Location = new System.Drawing.Point(320, 38);
            this.LblRegistrationTitle.Name = "LblRegistrationTitle";
            this.LblRegistrationTitle.Size = new System.Drawing.Size(669, 33);
            this.LblRegistrationTitle.TabIndex = 16;
            this.LblRegistrationTitle.Text = "Admission System of Post Graduate College";
            // 
            // getLNameBox
            // 
            this.getLNameBox.Location = new System.Drawing.Point(1135, 279);
            this.getLNameBox.Name = "getLNameBox";
            this.getLNameBox.Size = new System.Drawing.Size(129, 20);
            this.getLNameBox.TabIndex = 1;
            // 
            // getUserNameBox
            // 
            this.getUserNameBox.Location = new System.Drawing.Point(1000, 332);
            this.getUserNameBox.Name = "getUserNameBox";
            this.getUserNameBox.Size = new System.Drawing.Size(129, 20);
            this.getUserNameBox.TabIndex = 2;
            // 
            // getPassBox
            // 
            this.getPassBox.Location = new System.Drawing.Point(1000, 385);
            this.getPassBox.Name = "getPassBox";
            this.getPassBox.PasswordChar = '*';
            this.getPassBox.Size = new System.Drawing.Size(129, 20);
            this.getPassBox.TabIndex = 3;
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Checked = true;
            this.btnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMale.ForeColor = System.Drawing.Color.Green;
            this.btnMale.Location = new System.Drawing.Point(1009, 454);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(57, 19);
            this.btnMale.TabIndex = 4;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.CheckedChanged += new System.EventHandler(this.btnMale_CheckedChanged);
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemale.ForeColor = System.Drawing.Color.Green;
            this.btnFemale.Location = new System.Drawing.Point(1067, 454);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(73, 19);
            this.btnFemale.TabIndex = 5;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.btnFemale_CheckedChanged);
            // 
            // btnOther
            // 
            this.btnOther.AutoSize = true;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.Color.Green;
            this.btnOther.Location = new System.Drawing.Point(1141, 454);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(60, 19);
            this.btnOther.TabIndex = 6;
            this.btnOther.TabStop = true;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.CheckedChanged += new System.EventHandler(this.btnOther_CheckedChanged);
            // 
            // LblInquiryGender
            // 
            this.LblInquiryGender.AutoSize = true;
            this.LblInquiryGender.BackColor = System.Drawing.Color.Transparent;
            this.LblInquiryGender.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LblInquiryGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblInquiryGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInquiryGender.ForeColor = System.Drawing.Color.Black;
            this.LblInquiryGender.Location = new System.Drawing.Point(1006, 435);
            this.LblInquiryGender.Name = "LblInquiryGender";
            this.LblInquiryGender.Size = new System.Drawing.Size(36, 16);
            this.LblInquiryGender.TabIndex = 27;
            this.LblInquiryGender.Text = "I am ";
            // 
            // LblRegistrationSubtitle
            // 
            this.LblRegistrationSubtitle.AutoSize = true;
            this.LblRegistrationSubtitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRegistrationSubtitle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LblRegistrationSubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRegistrationSubtitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrationSubtitle.ForeColor = System.Drawing.Color.Green;
            this.LblRegistrationSubtitle.Location = new System.Drawing.Point(1026, 189);
            this.LblRegistrationSubtitle.Name = "LblRegistrationSubtitle";
            this.LblRegistrationSubtitle.Size = new System.Drawing.Size(177, 30);
            this.LblRegistrationSubtitle.TabIndex = 28;
            this.LblRegistrationSubtitle.Text = "Registration";
            // 
            // LblGenderDesc
            // 
            this.LblGenderDesc.AutoSize = true;
            this.LblGenderDesc.Location = new System.Drawing.Point(1048, 437);
            this.LblGenderDesc.Name = "LblGenderDesc";
            this.LblGenderDesc.Size = new System.Drawing.Size(0, 13);
            this.LblGenderDesc.TabIndex = 29;
            // 
            // lblFNameStar
            // 
            this.lblFNameStar.AutoSize = true;
            this.lblFNameStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNameStar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFNameStar.Location = new System.Drawing.Point(1091, 252);
            this.lblFNameStar.Name = "lblFNameStar";
            this.lblFNameStar.Size = new System.Drawing.Size(13, 16);
            this.lblFNameStar.TabIndex = 30;
            this.lblFNameStar.Text = "*";
            this.lblFNameStar.Visible = false;
            // 
            // lblUNameStar
            // 
            this.lblUNameStar.AutoSize = true;
            this.lblUNameStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUNameStar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUNameStar.Location = new System.Drawing.Point(1091, 307);
            this.lblUNameStar.Name = "lblUNameStar";
            this.lblUNameStar.Size = new System.Drawing.Size(13, 16);
            this.lblUNameStar.TabIndex = 31;
            this.lblUNameStar.Text = "*";
            this.lblUNameStar.Visible = false;
            // 
            // lblPassStar
            // 
            this.lblPassStar.AutoSize = true;
            this.lblPassStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassStar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassStar.Location = new System.Drawing.Point(1087, 366);
            this.lblPassStar.Name = "lblPassStar";
            this.lblPassStar.Size = new System.Drawing.Size(13, 16);
            this.lblPassStar.TabIndex = 32;
            this.lblPassStar.Text = "*";
            this.lblPassStar.Visible = false;
            // 
            // lblGenderStar
            // 
            this.lblGenderStar.AutoSize = true;
            this.lblGenderStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderStar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGenderStar.Location = new System.Drawing.Point(1088, 413);
            this.lblGenderStar.Name = "lblGenderStar";
            this.lblGenderStar.Size = new System.Drawing.Size(13, 16);
            this.lblGenderStar.TabIndex = 33;
            this.lblGenderStar.Text = "*";
            this.lblGenderStar.Visible = false;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.Color.Green;
            this.btnBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackLogin.Location = new System.Drawing.Point(1055, 551);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(132, 30);
            this.btnBackLogin.TabIndex = 8;
            this.btnBackLogin.Text = "Go to login page";
            this.btnBackLogin.UseVisualStyleBackColor = false;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(1135, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 22);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Last Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Green;
            this.textBox2.Location = new System.Drawing.Point(1000, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 22);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "Username";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Green;
            this.textBox3.Location = new System.Drawing.Point(1000, 410);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 22);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "Gender";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Green;
            this.textBox4.Location = new System.Drawing.Point(1000, 357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 22);
            this.textBox4.TabIndex = 37;
            this.textBox4.Text = "Password";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.lblGenderStar);
            this.Controls.Add(this.lblPassStar);
            this.Controls.Add(this.lblUNameStar);
            this.Controls.Add(this.lblFNameStar);
            this.Controls.Add(this.LblGenderDesc);
            this.Controls.Add(this.LblRegistrationSubtitle);
            this.Controls.Add(this.LblInquiryGender);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.getPassBox);
            this.Controls.Add(this.getUserNameBox);
            this.Controls.Add(this.getLNameBox);
            this.Controls.Add(this.LblRegistrationTitle);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.getFNameBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getFNameBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox fNameLabel;
        private System.Windows.Forms.Label LblRegistrationTitle;
        private System.Windows.Forms.TextBox getLNameBox;
        private System.Windows.Forms.TextBox getUserNameBox;
        private System.Windows.Forms.TextBox getPassBox;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnOther;
        private System.Windows.Forms.Label LblInquiryGender;
        private System.Windows.Forms.Label LblRegistrationSubtitle;
        private System.Windows.Forms.Label LblGenderDesc;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblFNameStar;
        private System.Windows.Forms.Label lblUNameStar;
        private System.Windows.Forms.Label lblPassStar;
        private System.Windows.Forms.Label lblGenderStar;
        private System.Windows.Forms.Button btnBackLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}