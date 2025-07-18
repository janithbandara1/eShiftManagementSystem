namespace eShiftManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox gbTotalJobs;
        private System.Windows.Forms.Label lblTotalJobs;
        private System.Windows.Forms.GroupBox gbPendingJobs;
        private System.Windows.Forms.Label lblPendingJobs;
        private System.Windows.Forms.GroupBox gbTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.GroupBox gbTotalProducts;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.GroupBox gbTotalLoads;
        private System.Windows.Forms.Label lblTotalLoads;

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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gbTotalJobs = new System.Windows.Forms.GroupBox();
            this.lblTotalJobs = new System.Windows.Forms.Label();
            this.gbPendingJobs = new System.Windows.Forms.GroupBox();
            this.lblPendingJobs = new System.Windows.Forms.Label();
            this.gbTotalCustomers = new System.Windows.Forms.GroupBox();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.gbTotalProducts = new System.Windows.Forms.GroupBox();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.gbTotalLoads = new System.Windows.Forms.GroupBox();
            this.lblTotalLoads = new System.Windows.Forms.Label();
            this.gbTotalJobs.SuspendLayout();
            this.gbPendingJobs.SuspendLayout();
            this.gbTotalCustomers.SuspendLayout();
            this.gbTotalProducts.SuspendLayout();
            this.gbTotalLoads.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDashboard.Location = new System.Drawing.Point(20, 20);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(102, 24);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 400);
            this.mainPanel.TabIndex = 1;
            // 
            // gbTotalJobs
            // 
            this.gbTotalJobs.Controls.Add(this.lblTotalJobs);
            this.gbTotalJobs.Location = new System.Drawing.Point(40, 80);
            this.gbTotalJobs.Name = "gbTotalJobs";
            this.gbTotalJobs.Size = new System.Drawing.Size(160, 80);
            this.gbTotalJobs.TabIndex = 1;
            this.gbTotalJobs.TabStop = false;
            this.gbTotalJobs.Text = "Total Jobs";
            // 
            // lblTotalJobs
            // 
            this.lblTotalJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalJobs.Location = new System.Drawing.Point(20, 30);
            this.lblTotalJobs.Name = "lblTotalJobs";
            this.lblTotalJobs.Size = new System.Drawing.Size(120, 30);
            this.lblTotalJobs.TabIndex = 0;
            this.lblTotalJobs.Text = "0";
            // 
            // gbPendingJobs
            // 
            this.gbPendingJobs.Controls.Add(this.lblPendingJobs);
            this.gbPendingJobs.Location = new System.Drawing.Point(220, 80);
            this.gbPendingJobs.Name = "gbPendingJobs";
            this.gbPendingJobs.Size = new System.Drawing.Size(160, 80);
            this.gbPendingJobs.TabIndex = 2;
            this.gbPendingJobs.TabStop = false;
            this.gbPendingJobs.Text = "Pending Jobs";
            // 
            // lblPendingJobs
            // 
            this.lblPendingJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPendingJobs.Location = new System.Drawing.Point(20, 30);
            this.lblPendingJobs.Name = "lblPendingJobs";
            this.lblPendingJobs.Size = new System.Drawing.Size(120, 30);
            this.lblPendingJobs.TabIndex = 0;
            this.lblPendingJobs.Text = "0";
            // 
            // gbTotalCustomers
            // 
            this.gbTotalCustomers.Controls.Add(this.lblTotalCustomers);
            this.gbTotalCustomers.Location = new System.Drawing.Point(400, 80);
            this.gbTotalCustomers.Name = "gbTotalCustomers";
            this.gbTotalCustomers.Size = new System.Drawing.Size(160, 80);
            this.gbTotalCustomers.TabIndex = 3;
            this.gbTotalCustomers.TabStop = false;
            this.gbTotalCustomers.Text = "Total Customers";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalCustomers.Location = new System.Drawing.Point(20, 30);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(120, 30);
            this.lblTotalCustomers.TabIndex = 0;
            this.lblTotalCustomers.Text = "0";
            // 
            // gbTotalProducts
            // 
            this.gbTotalProducts.Controls.Add(this.lblTotalProducts);
            this.gbTotalProducts.Location = new System.Drawing.Point(40, 180);
            this.gbTotalProducts.Name = "gbTotalProducts";
            this.gbTotalProducts.Size = new System.Drawing.Size(160, 80);
            this.gbTotalProducts.TabIndex = 4;
            this.gbTotalProducts.TabStop = false;
            this.gbTotalProducts.Text = "Total Products";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalProducts.Location = new System.Drawing.Point(20, 30);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(120, 30);
            this.lblTotalProducts.TabIndex = 0;
            this.lblTotalProducts.Text = "0";
            // 
            // gbTotalLoads
            // 
            this.gbTotalLoads.Controls.Add(this.lblTotalLoads);
            this.gbTotalLoads.Location = new System.Drawing.Point(220, 180);
            this.gbTotalLoads.Name = "gbTotalLoads";
            this.gbTotalLoads.Size = new System.Drawing.Size(160, 80);
            this.gbTotalLoads.TabIndex = 5;
            this.gbTotalLoads.TabStop = false;
            this.gbTotalLoads.Text = "Total Loads";
            // 
            // lblTotalLoads
            // 
            this.lblTotalLoads.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalLoads.Location = new System.Drawing.Point(20, 30);
            this.lblTotalLoads.Name = "lblTotalLoads";
            this.lblTotalLoads.Size = new System.Drawing.Size(120, 30);
            this.lblTotalLoads.TabIndex = 0;
            this.lblTotalLoads.Text = "0";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.gbTotalJobs);
            this.Controls.Add(this.gbPendingJobs);
            this.Controls.Add(this.gbTotalCustomers);
            this.Controls.Add(this.gbTotalProducts);
            this.Controls.Add(this.gbTotalLoads);
            this.Controls.Add(this.mainPanel);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.gbTotalJobs.ResumeLayout(false);
            this.gbPendingJobs.ResumeLayout(false);
            this.gbTotalCustomers.ResumeLayout(false);
            this.gbTotalProducts.ResumeLayout(false);
            this.gbTotalLoads.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
