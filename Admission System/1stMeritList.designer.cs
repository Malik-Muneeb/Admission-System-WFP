namespace Admission_System
{
    partial class _1stMeritList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UG_CandidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MeritList1DataSet = new Admission_System.MeritList1DataSet();
            this.G_CandidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GMeritList1DataSet = new Admission_System.GMeritList1DataSet();
            this.gbDegree = new System.Windows.Forms.GroupBox();
            this.rbGraduate = new System.Windows.Forms.RadioButton();
            this.rbUndergraduate = new System.Windows.Forms.RadioButton();
            this.gbProgramme = new System.Windows.Forms.GroupBox();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbCS = new System.Windows.Forms.RadioButton();
            this.rbSE = new System.Windows.Forms.RadioButton();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.rwGraduate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.rwGraduateA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.UG_CandidateTableAdapter = new Admission_System.MeritList1DataSetTableAdapters.UG_CandidateTableAdapter();
            this.G_CandidateTableAdapter = new Admission_System.GMeritList1DataSetTableAdapters.G_CandidateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UG_CandidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeritList1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_CandidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GMeritList1DataSet)).BeginInit();
            this.gbDegree.SuspendLayout();
            this.gbProgramme.SuspendLayout();
            this.SuspendLayout();
            // 
            // UG_CandidateBindingSource
            // 
            this.UG_CandidateBindingSource.DataMember = "UG_Candidate";
            this.UG_CandidateBindingSource.DataSource = this.MeritList1DataSet;
            // 
            // MeritList1DataSet
            // 
            this.MeritList1DataSet.DataSetName = "MeritList1DataSet";
            this.MeritList1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // G_CandidateBindingSource
            // 
            this.G_CandidateBindingSource.DataMember = "G_Candidate";
            this.G_CandidateBindingSource.DataSource = this.GMeritList1DataSet;
            // 
            // GMeritList1DataSet
            // 
            this.GMeritList1DataSet.DataSetName = "GMeritList1DataSet";
            this.GMeritList1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbDegree
            // 
            this.gbDegree.Controls.Add(this.rbGraduate);
            this.gbDegree.Controls.Add(this.rbUndergraduate);
            this.gbDegree.Location = new System.Drawing.Point(175, 31);
            this.gbDegree.Name = "gbDegree";
            this.gbDegree.Size = new System.Drawing.Size(218, 55);
            this.gbDegree.TabIndex = 0;
            this.gbDegree.TabStop = false;
            // 
            // rbGraduate
            // 
            this.rbGraduate.AutoSize = true;
            this.rbGraduate.Location = new System.Drawing.Point(129, 18);
            this.rbGraduate.Name = "rbGraduate";
            this.rbGraduate.Size = new System.Drawing.Size(69, 17);
            this.rbGraduate.TabIndex = 4;
            this.rbGraduate.TabStop = true;
            this.rbGraduate.Text = "Graduate";
            this.rbGraduate.UseVisualStyleBackColor = true;
            this.rbGraduate.CheckedChanged += new System.EventHandler(this.rbGraduate_CheckedChanged);
            // 
            // rbUndergraduate
            // 
            this.rbUndergraduate.AutoSize = true;
            this.rbUndergraduate.Location = new System.Drawing.Point(20, 17);
            this.rbUndergraduate.Name = "rbUndergraduate";
            this.rbUndergraduate.Size = new System.Drawing.Size(96, 17);
            this.rbUndergraduate.TabIndex = 0;
            this.rbUndergraduate.TabStop = true;
            this.rbUndergraduate.Text = "Undergraduate";
            this.rbUndergraduate.UseVisualStyleBackColor = true;
            this.rbUndergraduate.CheckedChanged += new System.EventHandler(this.rbUndergraduate_CheckedChanged);
            // 
            // gbProgramme
            // 
            this.gbProgramme.Controls.Add(this.rbIT);
            this.gbProgramme.Controls.Add(this.rbCS);
            this.gbProgramme.Controls.Add(this.rbSE);
            this.gbProgramme.Location = new System.Drawing.Point(643, 31);
            this.gbProgramme.Name = "gbProgramme";
            this.gbProgramme.Size = new System.Drawing.Size(194, 55);
            this.gbProgramme.TabIndex = 1;
            this.gbProgramme.TabStop = false;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(80, 19);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(35, 17);
            this.rbIT.TabIndex = 2;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // rbCS
            // 
            this.rbCS.AutoSize = true;
            this.rbCS.Location = new System.Drawing.Point(25, 19);
            this.rbCS.Name = "rbCS";
            this.rbCS.Size = new System.Drawing.Size(39, 17);
            this.rbCS.TabIndex = 1;
            this.rbCS.TabStop = true;
            this.rbCS.Text = "CS";
            this.rbCS.UseVisualStyleBackColor = true;
            // 
            // rbSE
            // 
            this.rbSE.AutoSize = true;
            this.rbSE.Location = new System.Drawing.Point(131, 19);
            this.rbSE.Name = "rbSE";
            this.rbSE.Size = new System.Drawing.Size(39, 17);
            this.rbSE.TabIndex = 0;
            this.rbSE.TabStop = true;
            this.rbSE.Text = "SE";
            this.rbSE.UseVisualStyleBackColor = true;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(103, 48);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(66, 19);
            this.lblDegree.TabIndex = 2;
            this.lblDegree.Text = "Degree";
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramme.Location = new System.Drawing.Point(532, 48);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(105, 19);
            this.lblProgramme.TabIndex = 3;
            this.lblProgramme.Text = "Programme";
            // 
            // rwGraduate
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UG_CandidateBindingSource;
            this.rwGraduate.LocalReport.DataSources.Add(reportDataSource1);
            this.rwGraduate.LocalReport.ReportEmbeddedResource = "Admission_System.UGMeritList1Report.rdlc";
            this.rwGraduate.Location = new System.Drawing.Point(2, 92);
            this.rwGraduate.Name = "rwGraduate";
            this.rwGraduate.Size = new System.Drawing.Size(1347, 637);
            this.rwGraduate.TabIndex = 4;
            this.rwGraduate.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.Location = new System.Drawing.Point(988, 41);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(126, 28);
            this.btnGenerateList.TabIndex = 5;
            this.btnGenerateList.Text = "Generate List";
            this.btnGenerateList.UseVisualStyleBackColor = true;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // rwGraduateA
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.G_CandidateBindingSource;
            this.rwGraduateA.LocalReport.DataSources.Add(reportDataSource2);
            this.rwGraduateA.LocalReport.ReportEmbeddedResource = "Admission_System.GMeritList1Report.rdlc";
            this.rwGraduateA.Location = new System.Drawing.Point(-3, 92);
            this.rwGraduateA.Name = "rwGraduateA";
            this.rwGraduateA.Size = new System.Drawing.Size(1352, 637);
            this.rwGraduateA.TabIndex = 6;
            this.rwGraduateA.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1188, 43);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UG_CandidateTableAdapter
            // 
            this.UG_CandidateTableAdapter.ClearBeforeFill = true;
            // 
            // G_CandidateTableAdapter
            // 
            this.G_CandidateTableAdapter.ClearBeforeFill = true;
            // 
            // _1stMeritList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rwGraduateA);
            this.Controls.Add(this.btnGenerateList);
            this.Controls.Add(this.rwGraduate);
            this.Controls.Add(this.lblProgramme);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.gbProgramme);
            this.Controls.Add(this.gbDegree);
            this.Name = "_1stMeritList";
            this.Text = "Merit List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._1stMeritList_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._1stMeritList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.UG_CandidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeritList1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_CandidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GMeritList1DataSet)).EndInit();
            this.gbDegree.ResumeLayout(false);
            this.gbDegree.PerformLayout();
            this.gbProgramme.ResumeLayout(false);
            this.gbProgramme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDegree;
        private System.Windows.Forms.GroupBox gbProgramme;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.RadioButton rbUndergraduate;
        private System.Windows.Forms.RadioButton rbGraduate;
        private System.Windows.Forms.RadioButton rbCS;
        private System.Windows.Forms.RadioButton rbSE;
        private System.Windows.Forms.RadioButton rbIT;
        private Microsoft.Reporting.WinForms.ReportViewer rwGraduate;
        private System.Windows.Forms.BindingSource UG_CandidateBindingSource;
        private MeritList1DataSet MeritList1DataSet;
        private MeritList1DataSetTableAdapters.UG_CandidateTableAdapter UG_CandidateTableAdapter;
        private System.Windows.Forms.Button btnGenerateList;
        private Microsoft.Reporting.WinForms.ReportViewer rwGraduateA;
        private System.Windows.Forms.BindingSource G_CandidateBindingSource;
        private GMeritList1DataSet GMeritList1DataSet;
        private GMeritList1DataSetTableAdapters.G_CandidateTableAdapter G_CandidateTableAdapter;
        private System.Windows.Forms.Button btnBack;
    }
}