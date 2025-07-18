namespace eShiftManagementSystem
{
    partial class JobManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblJobManagement;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtRequestedDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRequestedDate;

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
            this.lblJobManagement = new System.Windows.Forms.Label();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtRequestedDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRequestedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobManagement
            // 
            this.lblJobManagement.AutoSize = true;
            this.lblJobManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblJobManagement.Location = new System.Drawing.Point(20, 10);
            this.lblJobManagement.Name = "lblJobManagement";
            this.lblJobManagement.Size = new System.Drawing.Size(157, 24);
            this.lblJobManagement.TabIndex = 0;
            this.lblJobManagement.Text = "Job Management";
            // 
            // dgvJobs
            // 
            this.dgvJobs.Location = new System.Drawing.Point(20, 170);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(670, 200);
            this.dgvJobs.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(100, 50);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(340, 50);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(120, 20);
            this.txtStartLocation.TabIndex = 5;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(570, 50);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(120, 20);
            this.txtDestination.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Accepted",
            "Declined",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(100, 80);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(120, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.Location = new System.Drawing.Point(356, 80);
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.Size = new System.Drawing.Size(120, 20);
            this.txtRequestedDate.TabIndex = 11;
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
            // lblCustomerID
            // 
            this.lblCustomerID.Location = new System.Drawing.Point(20, 50);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(80, 20);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.Location = new System.Drawing.Point(250, 50);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(80, 20);
            this.lblStartLocation.TabIndex = 4;
            this.lblStartLocation.Text = "Start Location:";
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(480, 50);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(80, 20);
            this.lblDestination.TabIndex = 6;
            this.lblDestination.Text = "Destination:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // lblRequestedDate
            // 
            this.lblRequestedDate.Location = new System.Drawing.Point(250, 80);
            this.lblRequestedDate.Name = "lblRequestedDate";
            this.lblRequestedDate.Size = new System.Drawing.Size(100, 20);
            this.lblRequestedDate.TabIndex = 10;
            this.lblRequestedDate.Text = "Requested Date:";
            // 
            // JobManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.lblJobManagement);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblRequestedDate);
            this.Controls.Add(this.txtRequestedDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "JobManagementForm";
            this.Text = "Job Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
