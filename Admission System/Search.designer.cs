namespace Admission_System
{
    partial class Search
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
            this.SearchDataSet = new Admission_System.SearchDataSet();
            this.G_CandidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GSearchDataSet = new Admission_System.GSearchDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.getFormNoBox = new System.Windows.Forms.TextBox();
            this.lblFormNo = new System.Windows.Forms.Label();
            this.getCNICSearchBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.G_CandidateTableAdapter = new Admission_System.GSearchDataSetTableAdapters.G_CandidateTableAdapter();
            this.lblDegree = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.UG_CandidateTableAdapter = new Admission_System.SearchDataSetTableAdapters.UG_CandidateTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UG_CandidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_CandidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSearchDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UG_CandidateBindingSource
            // 
            this.UG_CandidateBindingSource.DataMember = "UG_Candidate";
            this.UG_CandidateBindingSource.DataSource = this.SearchDataSet;
            // 
            // SearchDataSet
            // 
            this.SearchDataSet.DataSetName = "SearchDataSet";
            this.SearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // G_CandidateBindingSource
            // 
            this.G_CandidateBindingSource.DataMember = "G_Candidate";
            this.G_CandidateBindingSource.DataSource = this.GSearchDataSet;
            // 
            // GSearchDataSet
            // 
            this.GSearchDataSet.DataSetName = "GSearchDataSet";
            this.GSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(761, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // getFormNoBox
            // 
            this.getFormNoBox.Location = new System.Drawing.Point(159, 125);
            this.getFormNoBox.Name = "getFormNoBox";
            this.getFormNoBox.Size = new System.Drawing.Size(100, 20);
            this.getFormNoBox.TabIndex = 1;
            // 
            // lblFormNo
            // 
            this.lblFormNo.AutoSize = true;
            this.lblFormNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormNo.Location = new System.Drawing.Point(41, 124);
            this.lblFormNo.Name = "lblFormNo";
            this.lblFormNo.Size = new System.Drawing.Size(112, 18);
            this.lblFormNo.TabIndex = 2;
            this.lblFormNo.Text = "Form Number";
            // 
            // getCNICSearchBox
            // 
            this.getCNICSearchBox.Location = new System.Drawing.Point(548, 129);
            this.getCNICSearchBox.Mask = "00000-0000000-0";
            this.getCNICSearchBox.Name = "getCNICSearchBox";
            this.getCNICSearchBox.PromptChar = ' ';
            this.getCNICSearchBox.Size = new System.Drawing.Size(100, 20);
            this.getCNICSearchBox.TabIndex = 4;
            this.getCNICSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(325, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "\"OR\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Candidate CNIC";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.UG_CandidateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admission_System.SearchReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 179);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1349, 357);
            this.reportViewer1.TabIndex = 7;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportViewer2
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.G_CandidateBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Admission_System.GSearchReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 179);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1349, 357);
            this.reportViewer2.TabIndex = 8;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // G_CandidateTableAdapter
            // 
            this.G_CandidateTableAdapter.ClearBeforeFill = true;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(44, 52);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(165, 23);
            this.lblDegree.TabIndex = 9;
            this.lblDegree.Text = "Student Degree";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1166, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UG_CandidateTableAdapter
            // 
            this.UG_CandidateTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(230, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Undergraduate";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(338, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Graduate";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1166, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 25);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 733);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getCNICSearchBox);
            this.Controls.Add(this.lblFormNo);
            this.Controls.Add(this.getFormNoBox);
            this.Controls.Add(this.btnSearch);
            this.Name = "Search";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.UG_CandidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_CandidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSearchDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox getFormNoBox;
        private System.Windows.Forms.Label lblFormNo;
        private System.Windows.Forms.MaskedTextBox getCNICSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;        
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UG_CandidateBindingSource;
        private SearchDataSet SearchDataSet;
        private SearchDataSetTableAdapters.UG_CandidateTableAdapter UG_CandidateTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource G_CandidateBindingSource;        
        private GSearchDataSet GSearchDataSet;
        private GSearchDataSetTableAdapters.G_CandidateTableAdapter G_CandidateTableAdapter;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnBack;
    }
}