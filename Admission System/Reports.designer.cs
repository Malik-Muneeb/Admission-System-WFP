namespace Admission_System
{
    partial class Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UG_CandidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UGGeneralListDataSet = new Admission_System.UGGeneralListDataSet();
            this.G_CandidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GGeneralListDataSet = new Admission_System.GGeneralListDataSet();
            this.rwUndergraduate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UG_CandidateTableAdapter = new Admission_System.UGGeneralListDataSetTableAdapters.UG_CandidateTableAdapter();
            this.rbUndergraduate = new System.Windows.Forms.RadioButton();
            this.rbGraduate = new System.Windows.Forms.RadioButton();
            this.lblDegree = new System.Windows.Forms.Label();
            this.rwGraduate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.G_CandidateTableAdapter = new Admission_System.GGeneralListDataSetTableAdapters.G_CandidateTableAdapter();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UG_CandidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGGeneralListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_CandidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GGeneralListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UG_CandidateBindingSource
            // 
            this.UG_CandidateBindingSource.DataMember = "UG_Candidate";
            this.UG_CandidateBindingSource.DataSource = this.UGGeneralListDataSet;
            // 
            // UGGeneralListDataSet
            // 
            this.UGGeneralListDataSet.DataSetName = "UGGeneralListDataSet";
            this.UGGeneralListDataSet.EnforceConstraints = false;
            this.UGGeneralListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // G_CandidateBindingSource
            // 
            this.G_CandidateBindingSource.DataMember = "G_Candidate";
            this.G_CandidateBindingSource.DataSource = this.GGeneralListDataSet;
            // 
            // GGeneralListDataSet
            // 
            this.GGeneralListDataSet.DataSetName = "GGeneralListDataSet";
            this.GGeneralListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rwUndergraduate
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.UG_CandidateBindingSource;
            this.rwUndergraduate.LocalReport.DataSources.Add(reportDataSource3);
            this.rwUndergraduate.LocalReport.ReportEmbeddedResource = "Admission_System.UGGeneralListReport.rdlc";
            this.rwUndergraduate.Location = new System.Drawing.Point(-1, 71);
            this.rwUndergraduate.Name = "rwUndergraduate";
            this.rwUndergraduate.Size = new System.Drawing.Size(1351, 659);
            this.rwUndergraduate.TabIndex = 0;
            this.rwUndergraduate.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // UG_CandidateTableAdapter
            // 
            this.UG_CandidateTableAdapter.ClearBeforeFill = true;
            // 
            // rbUndergraduate
            // 
            this.rbUndergraduate.AutoSize = true;
            this.rbUndergraduate.Location = new System.Drawing.Point(328, 30);
            this.rbUndergraduate.Name = "rbUndergraduate";
            this.rbUndergraduate.Size = new System.Drawing.Size(96, 17);
            this.rbUndergraduate.TabIndex = 1;
            this.rbUndergraduate.TabStop = true;
            this.rbUndergraduate.Text = "Undergraduate";
            this.rbUndergraduate.UseVisualStyleBackColor = true;
            // 
            // rbGraduate
            // 
            this.rbGraduate.AutoSize = true;
            this.rbGraduate.Location = new System.Drawing.Point(441, 30);
            this.rbGraduate.Name = "rbGraduate";
            this.rbGraduate.Size = new System.Drawing.Size(69, 17);
            this.rbGraduate.TabIndex = 2;
            this.rbGraduate.TabStop = true;
            this.rbGraduate.Text = "Graduate";
            this.rbGraduate.UseVisualStyleBackColor = true;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(176, 30);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(118, 19);
            this.lblDegree.TabIndex = 3;
            this.lblDegree.Text = "Select Degree";
            // 
            // rwGraduate
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.G_CandidateBindingSource;
            this.rwGraduate.LocalReport.DataSources.Add(reportDataSource4);
            this.rwGraduate.LocalReport.ReportEmbeddedResource = "Admission_System.GGeneralListReport.rdlc";
            this.rwGraduate.Location = new System.Drawing.Point(-1, 71);
            this.rwGraduate.Name = "rwGraduate";
            this.rwGraduate.Size = new System.Drawing.Size(1370, 770);
            this.rwGraduate.TabIndex = 4;
            this.rwGraduate.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // G_CandidateTableAdapter
            // 
            this.G_CandidateTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.Location = new System.Drawing.Point(588, 24);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(125, 25);
            this.btnGenerateList.TabIndex = 5;
            this.btnGenerateList.Text = "Generate List";
            this.btnGenerateList.UseVisualStyleBackColor = true;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1211, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerateList);
            this.Controls.Add(this.rwGraduate);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.rbGraduate);
            this.Controls.Add(this.rbUndergraduate);
            this.Controls.Add(this.rwUndergraduate);
            this.Name = "Reports";
            this.Text = "General List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UG_CandidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGGeneralListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_CandidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GGeneralListDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwUndergraduate;
        private System.Windows.Forms.BindingSource UG_CandidateBindingSource;
        private UGGeneralListDataSet UGGeneralListDataSet;
        private UGGeneralListDataSetTableAdapters.UG_CandidateTableAdapter UG_CandidateTableAdapter;
        private System.Windows.Forms.RadioButton rbUndergraduate;
        private System.Windows.Forms.RadioButton rbGraduate;
        private System.Windows.Forms.Label lblDegree;
        private Microsoft.Reporting.WinForms.ReportViewer rwGraduate;
        private System.Windows.Forms.BindingSource G_CandidateBindingSource;
        private GGeneralListDataSet GGeneralListDataSet;
        private GGeneralListDataSetTableAdapters.G_CandidateTableAdapter G_CandidateTableAdapter;
        private System.Windows.Forms.Button btnGenerateList;
        private System.Windows.Forms.Button btnBack;

    }
}