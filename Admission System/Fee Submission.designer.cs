namespace Admission_System
{
    partial class Fee_Submission
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvFeeSubmission = new System.Windows.Forms.DataGridView();
            this.gbDegree = new System.Windows.Forms.GroupBox();
            this.rbGraduate = new System.Windows.Forms.RadioButton();
            this.rbUndergraduate = new System.Windows.Forms.RadioButton();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.gbProgramme = new System.Windows.Forms.GroupBox();
            this.rbSE = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbCS = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeSubmission)).BeginInit();
            this.gbDegree.SuspendLayout();
            this.gbProgramme.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1241, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvFeeSubmission
            // 
            this.dgvFeeSubmission.AllowUserToAddRows = false;
            this.dgvFeeSubmission.AllowUserToDeleteRows = false;
            this.dgvFeeSubmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeSubmission.Location = new System.Drawing.Point(3, 62);
            this.dgvFeeSubmission.Name = "dgvFeeSubmission";
            this.dgvFeeSubmission.Size = new System.Drawing.Size(1362, 604);
            this.dgvFeeSubmission.TabIndex = 1;
            // 
            // gbDegree
            // 
            this.gbDegree.Controls.Add(this.rbGraduate);
            this.gbDegree.Controls.Add(this.rbUndergraduate);
            this.gbDegree.Location = new System.Drawing.Point(150, 12);
            this.gbDegree.Name = "gbDegree";
            this.gbDegree.Size = new System.Drawing.Size(203, 43);
            this.gbDegree.TabIndex = 2;
            this.gbDegree.TabStop = false;
            // 
            // rbGraduate
            // 
            this.rbGraduate.AutoSize = true;
            this.rbGraduate.Location = new System.Drawing.Point(120, 14);
            this.rbGraduate.Name = "rbGraduate";
            this.rbGraduate.Size = new System.Drawing.Size(69, 17);
            this.rbGraduate.TabIndex = 1;
            this.rbGraduate.TabStop = true;
            this.rbGraduate.Text = "Graduate";
            this.rbGraduate.UseVisualStyleBackColor = true;
            this.rbGraduate.CheckedChanged += new System.EventHandler(this.rbGraduate_CheckedChanged);
            // 
            // rbUndergraduate
            // 
            this.rbUndergraduate.AutoSize = true;
            this.rbUndergraduate.Location = new System.Drawing.Point(6, 15);
            this.rbUndergraduate.Name = "rbUndergraduate";
            this.rbUndergraduate.Size = new System.Drawing.Size(96, 17);
            this.rbUndergraduate.TabIndex = 0;
            this.rbUndergraduate.TabStop = true;
            this.rbUndergraduate.Text = "Undergraduate";
            this.rbUndergraduate.UseVisualStyleBackColor = true;
            this.rbUndergraduate.CheckedChanged += new System.EventHandler(this.rbUndergraduate_CheckedChanged);
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(53, 21);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(80, 23);
            this.lblDegree.TabIndex = 3;
            this.lblDegree.Text = "Degree";
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramme.Location = new System.Drawing.Point(412, 21);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(129, 23);
            this.lblProgramme.TabIndex = 4;
            this.lblProgramme.Text = "Programme";
            // 
            // gbProgramme
            // 
            this.gbProgramme.Controls.Add(this.rbSE);
            this.gbProgramme.Controls.Add(this.rbIT);
            this.gbProgramme.Controls.Add(this.rbCS);
            this.gbProgramme.Location = new System.Drawing.Point(559, 12);
            this.gbProgramme.Name = "gbProgramme";
            this.gbProgramme.Size = new System.Drawing.Size(135, 43);
            this.gbProgramme.TabIndex = 5;
            this.gbProgramme.TabStop = false;
            // 
            // rbSE
            // 
            this.rbSE.AutoSize = true;
            this.rbSE.Location = new System.Drawing.Point(92, 15);
            this.rbSE.Name = "rbSE";
            this.rbSE.Size = new System.Drawing.Size(39, 17);
            this.rbSE.TabIndex = 4;
            this.rbSE.TabStop = true;
            this.rbSE.Text = "SE";
            this.rbSE.UseVisualStyleBackColor = true;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(51, 15);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(35, 17);
            this.rbIT.TabIndex = 3;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // rbCS
            // 
            this.rbCS.AutoSize = true;
            this.rbCS.Location = new System.Drawing.Point(6, 15);
            this.rbCS.Name = "rbCS";
            this.rbCS.Size = new System.Drawing.Size(39, 17);
            this.rbCS.TabIndex = 2;
            this.rbCS.TabStop = true;
            this.rbCS.Text = "CS";
            this.rbCS.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(779, 27);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1167, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Fee_Submission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbProgramme);
            this.Controls.Add(this.lblProgramme);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.gbDegree);
            this.Controls.Add(this.dgvFeeSubmission);
            this.Controls.Add(this.btnSave);
            this.Name = "Fee_Submission";
            this.Text = "Fee Submission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fee_Submission_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeSubmission)).EndInit();
            this.gbDegree.ResumeLayout(false);
            this.gbDegree.PerformLayout();
            this.gbProgramme.ResumeLayout(false);
            this.gbProgramme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvFeeSubmission;
        private System.Windows.Forms.GroupBox gbDegree;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.RadioButton rbUndergraduate;
        private System.Windows.Forms.RadioButton rbGraduate;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.GroupBox gbProgramme;
        private System.Windows.Forms.RadioButton rbCS;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbSE;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBack;
    }
}