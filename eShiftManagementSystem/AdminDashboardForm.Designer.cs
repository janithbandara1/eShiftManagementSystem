namespace eShiftManagementSystem
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnAdminManagement;
        private System.Windows.Forms.Button btnJobManagement;
        private System.Windows.Forms.Button btnLoadManagement;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTransportUnitManagement;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnMainDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnMainDashboard = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnAdminManagement = new System.Windows.Forms.Button();
            this.btnJobManagement = new System.Windows.Forms.Button();
            this.btnLoadManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTransportUnitManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.LightGray;
            this.sidebarPanel.Controls.Add(this.pictureBoxLogo);
            this.sidebarPanel.Controls.Add(this.btnMainDashboard);
            this.sidebarPanel.Controls.Add(this.btnCustomerManagement);
            this.sidebarPanel.Controls.Add(this.btnAdminManagement);
            this.sidebarPanel.Controls.Add(this.btnJobManagement);
            this.sidebarPanel.Controls.Add(this.btnLoadManagement);
            this.sidebarPanel.Controls.Add(this.btnProductManagement);
            this.sidebarPanel.Controls.Add(this.btnReport);
            this.sidebarPanel.Controls.Add(this.btnTransportUnitManagement);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 441);
            this.sidebarPanel.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(74, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnMainDashboard
            // 
            this.btnMainDashboard.Location = new System.Drawing.Point(22, 68);
            this.btnMainDashboard.Name = "btnMainDashboard";
            this.btnMainDashboard.Size = new System.Drawing.Size(160, 30);
            this.btnMainDashboard.TabIndex = 0;
            this.btnMainDashboard.Text = "Main Dashboard";
            this.btnMainDashboard.UseVisualStyleBackColor = true;
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.Location = new System.Drawing.Point(22, 108);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(160, 30);
            this.btnCustomerManagement.TabIndex = 1;
            this.btnCustomerManagement.Text = "Customer Management";
            this.btnCustomerManagement.UseVisualStyleBackColor = true;
            // 
            // btnAdminManagement
            // 
            this.btnAdminManagement.Location = new System.Drawing.Point(22, 148);
            this.btnAdminManagement.Name = "btnAdminManagement";
            this.btnAdminManagement.Size = new System.Drawing.Size(160, 30);
            this.btnAdminManagement.TabIndex = 2;
            this.btnAdminManagement.Text = "Admin Management";
            this.btnAdminManagement.UseVisualStyleBackColor = true;
            // 
            // btnJobManagement
            // 
            this.btnJobManagement.Location = new System.Drawing.Point(22, 188);
            this.btnJobManagement.Name = "btnJobManagement";
            this.btnJobManagement.Size = new System.Drawing.Size(160, 30);
            this.btnJobManagement.TabIndex = 3;
            this.btnJobManagement.Text = "Job Management";
            this.btnJobManagement.UseVisualStyleBackColor = true;
            // 
            // btnLoadManagement
            // 
            this.btnLoadManagement.Location = new System.Drawing.Point(22, 228);
            this.btnLoadManagement.Name = "btnLoadManagement";
            this.btnLoadManagement.Size = new System.Drawing.Size(160, 30);
            this.btnLoadManagement.TabIndex = 4;
            this.btnLoadManagement.Text = "Load Management";
            this.btnLoadManagement.UseVisualStyleBackColor = true;
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Location = new System.Drawing.Point(22, 268);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(160, 30);
            this.btnProductManagement.TabIndex = 5;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(22, 308);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(160, 30);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnTransportUnitManagement
            // 
            this.btnTransportUnitManagement.Location = new System.Drawing.Point(22, 348);
            this.btnTransportUnitManagement.Name = "btnTransportUnitManagement";
            this.btnTransportUnitManagement.Size = new System.Drawing.Size(160, 30);
            this.btnTransportUnitManagement.TabIndex = 7;
            this.btnTransportUnitManagement.Text = "Transport Unit Management";
            this.btnTransportUnitManagement.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(22, 384);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 30);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(638, 441);
            this.mainPanel.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard";
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
