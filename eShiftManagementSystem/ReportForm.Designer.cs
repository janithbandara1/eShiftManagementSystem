namespace eShiftManagementSystem
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReportResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblReport = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReportResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblReport.Location = new System.Drawing.Point(20, 10);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(116, 24);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Report Form";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Items.AddRange(new object[] {
            "All Jobs",
            "Jobs by Status",
            "Jobs by Customer",
            "Loads by Transport Unit",
            "Products List"});
            this.cmbReportType.Location = new System.Drawing.Point(20, 50);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 21);
            this.cmbReportType.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(240, 50);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dgvReportResults
            // 
            this.dgvReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportResults.Location = new System.Drawing.Point(20, 90);
            this.dgvReportResults.Name = "dgvReportResults";
            this.dgvReportResults.Size = new System.Drawing.Size(600, 250);
            this.dgvReportResults.TabIndex = 3;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvReportResults);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
