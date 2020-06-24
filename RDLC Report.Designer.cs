namespace Login
{
    partial class RDLC_Report
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
            this.WeeklyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClubActivity = new Login.dsClubActivity();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WeeklyReportTableAdapter = new Login.dsClubActivityTableAdapters.WeeklyReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClubActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // WeeklyReportBindingSource
            // 
            this.WeeklyReportBindingSource.DataMember = "WeeklyReport";
            this.WeeklyReportBindingSource.DataSource = this.dsClubActivity;
            // 
            // dsClubActivity
            // 
            this.dsClubActivity.DataSetName = "dsClubActivity";
            this.dsClubActivity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.WeeklyReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Login.ClubActivitiy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(622, 416);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // WeeklyReportTableAdapter
            // 
            this.WeeklyReportTableAdapter.ClearBeforeFill = true;
            // 
            // RDLC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 483);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RDLC_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDLC_Report";
            this.Load += new System.EventHandler(this.RDLC_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClubActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WeeklyReportBindingSource;
        private dsClubActivity dsClubActivity;
        private dsClubActivityTableAdapters.WeeklyReportTableAdapter WeeklyReportTableAdapter;
    }
}