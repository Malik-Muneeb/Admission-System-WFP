namespace Admission_System
{
    partial class _2ndMeritList
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
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UGMeritList2DataSet = new Admission_System.UGMeritList2DataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.rwGraduate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.rwUndergraduate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.gbProgramme = new System.Windows.Forms.GroupBox();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbCS = new System.Windows.Forms.RadioButton();
            this.rbSE = new System.Windows.Forms.RadioButton();
            this.gbDegree = new System.Windows.Forms.GroupBox();
            this.rbGraduate = new System.Windows.Forms.RadioButton();
            this.rbUndergraduate = new System.Windows.Forms.RadioButton();
            this.DataTable1TableAdapter = new Admission_System.UGMeritList2DataSetTableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new Admission_System.UGMeritList2DataSetTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGMeritList2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.gbProgramme.SuspendLayout();
            this.gbDegree.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.UGMeritList2DataSet;
            // 
            // UGMeritList2DataSet
            // 
            this.UGMeritList2DataSet.DataSetName = "UGMeritList2DataSet";
            this.UGMeritList2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.UGMeritList2DataSet;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1130, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 30);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rwGraduate
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable2BindingSource;
            this.rwGraduate.LocalReport.DataSources.Add(reportDataSource3);
            this.rwGraduate.LocalReport.ReportEmbeddedResource = "Admission_System.GMeritList2Report.rdlc";
            this.rwGraduate.Location = new System.Drawing.Point(-5, 69);
            this.rwGraduate.Name = "rwGraduate";
            this.rwGraduate.Size = new System.Drawing.Size(1358, 665);
            this.rwGraduate.TabIndex = 14;
            this.rwGraduate.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.Location = new System.Drawing.Point(954, 24);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(126, 30);
            this.btnGenerateList.TabIndex = 13;
            this.btnGenerateList.Text = "Generate List";
            this.btnGenerateList.UseVisualStyleBackColor = true;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // rwUndergraduate
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.DataTable1BindingSource;
            this.rwUndergraduate.LocalReport.DataSources.Add(reportDataSource4);
            this.rwUndergraduate.LocalReport.ReportEmbeddedResource = "Admission_System.UGMeritList2Repot.rdlc";
            this.rwUndergraduate.Location = new System.Drawing.Point(-5, 69);
            this.rwUndergraduate.Name = "rwUndergraduate";
            this.rwUndergraduate.Size = new System.Drawing.Size(1358, 665);
            this.rwUndergraduate.TabIndex = 12;
            this.rwUndergraduate.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramme.Location = new System.Drawing.Point(536, 33);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(105, 19);
            this.lblProgramme.TabIndex = 11;
            this.lblProgramme.Text = "Programme";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(107, 33);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(66, 19);
            this.lblDegree.TabIndex = 10;
            this.lblDegree.Text = "Degree";
            // 
            // gbProgramme
            // 
            this.gbProgramme.Controls.Add(this.rbIT);
            this.gbProgramme.Controls.Add(this.rbCS);
            this.gbProgramme.Controls.Add(this.rbSE);
            this.gbProgramme.Location = new System.Drawing.Point(647, 12);
            this.gbProgramme.Name = "gbProgramme";
            this.gbProgramme.Size = new System.Drawing.Size(194, 55);
            this.gbProgramme.TabIndex = 9;
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
            // gbDegree
            // 
            this.gbDegree.Controls.Add(this.rbGraduate);
            this.gbDegree.Controls.Add(this.rbUndergraduate);
            this.gbDegree.Location = new System.Drawing.Point(179, 12);
            this.gbDegree.Name = "gbDegree";
            this.gbDegree.Size = new System.Drawing.Size(218, 53);
            this.gbDegree.TabIndex = 8;
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
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // _2ndMeritList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rwGraduate);
            this.Controls.Add(this.btnGenerateList);
            this.Controls.Add(this.rwUndergraduate);
            this.Controls.Add(this.lblProgramme);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.gbProgramme);
            this.Controls.Add(this.gbDegree);
            this.Name = "_2ndMeritList";
            this.Text = "Merit List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._2ndMeritList_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._2ndMeritList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGMeritList2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.gbProgramme.ResumeLayout(false);
            this.gbProgramme.PerformLayout();
            this.gbDegree.ResumeLayout(false);
            this.gbDegree.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private Microsoft.Reporting.WinForms.ReportViewer rwGraduate;
        private System.Windows.Forms.Button btnGenerateList;
        private Microsoft.Reporting.WinForms.ReportViewer rwUndergraduate;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.GroupBox gbProgramme;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbCS;
        private System.Windows.Forms.RadioButton rbSE;
        private System.Windows.Forms.GroupBox gbDegree;
        private System.Windows.Forms.RadioButton rbGraduate;
        private System.Windows.Forms.RadioButton rbUndergraduate;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private UGMeritList2DataSet UGMeritList2DataSet;
        private UGMeritList2DataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private UGMeritList2DataSetTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
    }
}