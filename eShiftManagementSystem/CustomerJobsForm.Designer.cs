namespace eShiftManagementSystem
{
    partial class CustomerJobsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.DateTimePicker dtpRequestedDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblRequestedDate;
        private System.Windows.Forms.Label lblStatus;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.dtpRequestedDate = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblRequestedDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Jobs";
            // 
            // dgvJobs
            // 
            this.dgvJobs.Location = new System.Drawing.Point(20, 180);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(600, 200);
            this.dgvJobs.TabIndex = 1;
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(130, 50);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(180, 20);
            this.txtStartLocation.TabIndex = 3;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(430, 50);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(180, 20);
            this.txtDestination.TabIndex = 5;
            // 
            // dtpRequestedDate
            // 
            this.dtpRequestedDate.Location = new System.Drawing.Point(130, 80);
            this.dtpRequestedDate.Name = "dtpRequestedDate";
            this.dtpRequestedDate.Size = new System.Drawing.Size(180, 20);
            this.dtpRequestedDate.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(430, 80);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(180, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.Location = new System.Drawing.Point(20, 50);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(100, 20);
            this.lblStartLocation.TabIndex = 2;
            this.lblStartLocation.Text = "Start Location:";
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(320, 50);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(100, 20);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // lblRequestedDate
            // 
            this.lblRequestedDate.Location = new System.Drawing.Point(20, 80);
            this.lblRequestedDate.Name = "lblRequestedDate";
            this.lblRequestedDate.Size = new System.Drawing.Size(100, 20);
            this.lblRequestedDate.TabIndex = 6;
            this.lblRequestedDate.Text = "Requested Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(320, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // CustomerJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblRequestedDate);
            this.Controls.Add(this.dtpRequestedDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "CustomerJobsForm";
            this.Text = "My Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
