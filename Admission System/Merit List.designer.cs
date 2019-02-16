namespace Admission_System
{
    partial class Merit_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merit_List));
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFeeSub1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.White;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.Gray;
            this.btnGeneral.Location = new System.Drawing.Point(266, 245);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(153, 29);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "General Merit List";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Gray;
            this.btnFirst.Location = new System.Drawing.Point(266, 293);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(153, 27);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First Merit  List";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.BackColor = System.Drawing.Color.White;
            this.btnSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecond.ForeColor = System.Drawing.Color.Gray;
            this.btnSecond.Location = new System.Drawing.Point(266, 340);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(153, 28);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "Second Merit List";
            this.btnSecond.UseVisualStyleBackColor = false;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.BackColor = System.Drawing.Color.White;
            this.btnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThird.ForeColor = System.Drawing.Color.Gray;
            this.btnThird.Location = new System.Drawing.Point(266, 389);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(153, 28);
            this.btnThird.TabIndex = 3;
            this.btnThird.Text = "Third Merit List";
            this.btnThird.UseVisualStyleBackColor = false;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(1128, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 32);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFeeSub1
            // 
            this.btnFeeSub1.BackColor = System.Drawing.Color.White;
            this.btnFeeSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeeSub1.ForeColor = System.Drawing.Color.Gray;
            this.btnFeeSub1.Location = new System.Drawing.Point(266, 441);
            this.btnFeeSub1.Name = "btnFeeSub1";
            this.btnFeeSub1.Size = new System.Drawing.Size(153, 28);
            this.btnFeeSub1.TabIndex = 5;
            this.btnFeeSub1.Text = "Fee Submission";
            this.btnFeeSub1.UseVisualStyleBackColor = false;
            this.btnFeeSub1.Click += new System.EventHandler(this.btnFeeSub1_Click);
            // 
            // Merit_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.btnFeeSub1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnGeneral);
            this.Name = "Merit_List";
            this.Text = "Merit List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Merit_List_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Merit_List_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFeeSub1;
    }
}