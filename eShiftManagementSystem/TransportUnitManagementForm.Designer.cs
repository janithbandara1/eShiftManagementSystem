namespace eShiftManagementSystem
{
    partial class TransportUnitManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTransportUnitManagement;
        private System.Windows.Forms.DataGridView dgvTransportUnits;
        private System.Windows.Forms.TextBox txtLorryNumber;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtAssistantName;
        private System.Windows.Forms.TextBox txtContainerDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLorryNumber;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblAssistantName;
        private System.Windows.Forms.Label lblContainerDetails;

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
            this.lblTransportUnitManagement = new System.Windows.Forms.Label();
            this.dgvTransportUnits = new System.Windows.Forms.DataGridView();
            this.txtLorryNumber = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtAssistantName = new System.Windows.Forms.TextBox();
            this.txtContainerDetails = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLorryNumber = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblAssistantName = new System.Windows.Forms.Label();
            this.lblContainerDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransportUnitManagement
            // 
            this.lblTransportUnitManagement.AutoSize = true;
            this.lblTransportUnitManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTransportUnitManagement.Location = new System.Drawing.Point(20, 10);
            this.lblTransportUnitManagement.Name = "lblTransportUnitManagement";
            this.lblTransportUnitManagement.Size = new System.Drawing.Size(243, 24);
            this.lblTransportUnitManagement.TabIndex = 0;
            this.lblTransportUnitManagement.Text = "Transport Unit Management";
            // 
            // dgvTransportUnits
            // 
            this.dgvTransportUnits.Location = new System.Drawing.Point(20, 180);
            this.dgvTransportUnits.Name = "dgvTransportUnits";
            this.dgvTransportUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportUnits.Size = new System.Drawing.Size(600, 200);
            this.dgvTransportUnits.TabIndex = 1;
            // 
            // txtLorryNumber
            // 
            this.txtLorryNumber.Location = new System.Drawing.Point(100, 50);
            this.txtLorryNumber.Name = "txtLorryNumber";
            this.txtLorryNumber.Size = new System.Drawing.Size(100, 20);
            this.txtLorryNumber.TabIndex = 3;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(300, 50);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(100, 20);
            this.txtDriverName.TabIndex = 5;
            // 
            // txtAssistantName
            // 
            this.txtAssistantName.Location = new System.Drawing.Point(520, 50);
            this.txtAssistantName.Name = "txtAssistantName";
            this.txtAssistantName.Size = new System.Drawing.Size(100, 20);
            this.txtAssistantName.TabIndex = 7;
            // 
            // txtContainerDetails
            // 
            this.txtContainerDetails.Location = new System.Drawing.Point(120, 80);
            this.txtContainerDetails.Name = "txtContainerDetails";
            this.txtContainerDetails.Size = new System.Drawing.Size(200, 20);
            this.txtContainerDetails.TabIndex = 9;
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
            // lblLorryNumber
            // 
            this.lblLorryNumber.Location = new System.Drawing.Point(20, 50);
            this.lblLorryNumber.Name = "lblLorryNumber";
            this.lblLorryNumber.Size = new System.Drawing.Size(80, 20);
            this.lblLorryNumber.TabIndex = 2;
            this.lblLorryNumber.Text = "Lorry Number:";
            // 
            // lblDriverName
            // 
            this.lblDriverName.Location = new System.Drawing.Point(220, 50);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(80, 20);
            this.lblDriverName.TabIndex = 4;
            this.lblDriverName.Text = "Driver Name:";
            // 
            // lblAssistantName
            // 
            this.lblAssistantName.Location = new System.Drawing.Point(420, 50);
            this.lblAssistantName.Name = "lblAssistantName";
            this.lblAssistantName.Size = new System.Drawing.Size(100, 20);
            this.lblAssistantName.TabIndex = 6;
            this.lblAssistantName.Text = "Assistant Name:";
            // 
            // lblContainerDetails
            // 
            this.lblContainerDetails.Location = new System.Drawing.Point(20, 80);
            this.lblContainerDetails.Name = "lblContainerDetails";
            this.lblContainerDetails.Size = new System.Drawing.Size(100, 20);
            this.lblContainerDetails.TabIndex = 8;
            this.lblContainerDetails.Text = "Container Details:";
            // 
            // TransportUnitManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.lblTransportUnitManagement);
            this.Controls.Add(this.dgvTransportUnits);
            this.Controls.Add(this.lblLorryNumber);
            this.Controls.Add(this.txtLorryNumber);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.lblAssistantName);
            this.Controls.Add(this.txtAssistantName);
            this.Controls.Add(this.lblContainerDetails);
            this.Controls.Add(this.txtContainerDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "TransportUnitManagementForm";
            this.Text = "Transport Unit Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
