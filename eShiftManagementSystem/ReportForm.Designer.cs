namespace eShiftManagementSystem
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReportResults;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;

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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
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
            "Products List",
            "Jobs by Date Range",
            "Delivery Performance"});
            this.cmbReportType.Location = new System.Drawing.Point(20, 50);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 21);
            this.cmbReportType.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 87);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dgvReportResults
            // 
            this.dgvReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportResults.Location = new System.Drawing.Point(20, 128);
            this.dgvReportResults.Name = "dgvReportResults";
            this.dgvReportResults.Size = new System.Drawing.Size(590, 262);
            this.dgvReportResults.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(277, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(437, 51);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 20);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(237, 51);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 21);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(407, 51);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 21);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To:";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
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
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
