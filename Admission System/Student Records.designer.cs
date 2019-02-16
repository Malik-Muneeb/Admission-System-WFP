namespace Admission_System
{
    partial class Student_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Records));
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnSearchRecord = new System.Windows.Forms.Button();
            this.btnEnterRecord = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecord.Location = new System.Drawing.Point(299, 417);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(213, 27);
            this.btnUpdateRecord.TabIndex = 3;
            this.btnUpdateRecord.Text = "Update Student Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnSearchRecord
            // 
            this.btnSearchRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRecord.Location = new System.Drawing.Point(299, 352);
            this.btnSearchRecord.Name = "btnSearchRecord";
            this.btnSearchRecord.Size = new System.Drawing.Size(213, 28);
            this.btnSearchRecord.TabIndex = 2;
            this.btnSearchRecord.Text = "Search and Delete Student Record";
            this.btnSearchRecord.UseVisualStyleBackColor = true;
            this.btnSearchRecord.Click += new System.EventHandler(this.btnSearchRecord_Click);
            // 
            // btnEnterRecord
            // 
            this.btnEnterRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterRecord.Location = new System.Drawing.Point(299, 288);
            this.btnEnterRecord.Name = "btnEnterRecord";
            this.btnEnterRecord.Size = new System.Drawing.Size(213, 29);
            this.btnEnterRecord.TabIndex = 1;
            this.btnEnterRecord.Text = "Enter Student Record";
            this.btnEnterRecord.UseVisualStyleBackColor = true;
            this.btnEnterRecord.Click += new System.EventHandler(this.btnEnterRecord_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1151, 63);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Student_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnSearchRecord);
            this.Controls.Add(this.btnEnterRecord);
            this.Name = "Student_Records";
            this.Text = "Student Records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_Records_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_Records_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnSearchRecord;
        private System.Windows.Forms.Button btnEnterRecord;
        private System.Windows.Forms.Button btnBack;
    }
}