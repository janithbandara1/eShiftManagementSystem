namespace eShiftManagementSystem
{
    partial class LoadManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLoadManagement;
        private System.Windows.Forms.DataGridView dgvLoads;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtTransportUnitID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblTransportUnitID;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDescription;

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
            this.lblLoadManagement = new System.Windows.Forms.Label();
            this.dgvLoads = new System.Windows.Forms.DataGridView();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtTransportUnitID = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblTransportUnitID = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoads)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadManagement
            // 
            this.lblLoadManagement.AutoSize = true;
            this.lblLoadManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLoadManagement.Location = new System.Drawing.Point(20, 10);
            this.lblLoadManagement.Name = "lblLoadManagement";
            this.lblLoadManagement.Size = new System.Drawing.Size(168, 24);
            this.lblLoadManagement.TabIndex = 0;
            this.lblLoadManagement.Text = "Load Management";
            // 
            // dgvLoads
            // 
            this.dgvLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoads.Location = new System.Drawing.Point(20, 180);
            this.dgvLoads.Name = "dgvLoads";
            this.dgvLoads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoads.Size = new System.Drawing.Size(600, 200);
            this.dgvLoads.TabIndex = 1;
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(100, 50);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(80, 20);
            this.txtJobID.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(290, 50);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(80, 20);
            this.txtProductID.TabIndex = 5;
            // 
            // txtTransportUnitID
            // 
            this.txtTransportUnitID.Location = new System.Drawing.Point(500, 50);
            this.txtTransportUnitID.Name = "txtTransportUnitID";
            this.txtTransportUnitID.Size = new System.Drawing.Size(80, 20);
            this.txtTransportUnitID.TabIndex = 7;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(100, 80);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(80, 20);
            this.txtWeight.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(290, 80);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblJobID
            // 
            this.lblJobID.Location = new System.Drawing.Point(20, 50);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(80, 20);
            this.lblJobID.TabIndex = 2;
            this.lblJobID.Text = "JobID:";
            // 
            // lblProductID
            // 
            this.lblProductID.Location = new System.Drawing.Point(200, 50);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(80, 20);
            this.lblProductID.TabIndex = 4;
            this.lblProductID.Text = "ProductID:";
            // 
            // lblTransportUnitID
            // 
            this.lblTransportUnitID.Location = new System.Drawing.Point(390, 50);
            this.lblTransportUnitID.Name = "lblTransportUnitID";
            this.lblTransportUnitID.Size = new System.Drawing.Size(100, 20);
            this.lblTransportUnitID.TabIndex = 6;
            this.lblTransportUnitID.Text = "TransportUnitID:";
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(20, 80);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 20);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(200, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 20);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // LoadManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.lblLoadManagement);
            this.Controls.Add(this.dgvLoads);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblTransportUnitID);
            this.Controls.Add(this.txtTransportUnitID);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "LoadManagementForm";
            this.Text = "Load Management";
            this.Load += new System.EventHandler(this.LoadManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
