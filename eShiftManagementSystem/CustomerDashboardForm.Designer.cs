namespace eShiftManagementSystem
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomerDashboard;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCustomerJobs;
        private System.Windows.Forms.Button btnLogout;

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
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCustomerJobs = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.LightGray;
            this.topBarPanel.Controls.Add(this.btnHome);
            this.topBarPanel.Controls.Add(this.btnProfile);
            this.topBarPanel.Controls.Add(this.btnCustomerJobs);
            this.topBarPanel.Controls.Add(this.btnLogout);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(838, 60);
            this.topBarPanel.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(40, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 30);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(120, 15);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 30);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnCustomerJobs
            // 
            this.btnCustomerJobs.Location = new System.Drawing.Point(260, 15);
            this.btnCustomerJobs.Name = "btnCustomerJobs";
            this.btnCustomerJobs.Size = new System.Drawing.Size(120, 30);
            this.btnCustomerJobs.TabIndex = 2;
            this.btnCustomerJobs.Text = "My Jobs";
            this.btnCustomerJobs.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(400, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(838, 381);
            this.mainPanel.TabIndex = 0;
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topBarPanel);
            this.Name = "CustomerDashboardForm";
            this.Text = "Customer Dashboard";
            this.topBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel mainPanel;
    }
}
