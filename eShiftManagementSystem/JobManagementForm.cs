using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class JobManagementForm : Form
    {
        public JobManagementForm()
        {
            InitializeComponent();
            LoadFilterOptions();
            LoadJobs();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvJobs.SelectionChanged += DgvJobs_SelectionChanged;
            btnFilter.Click += BtnFilter_Click;
        }

        private void LoadFilterOptions()
        {
            // Load customers for filter
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, Name FROM Customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbFilterCustomer.Items.Clear();
                cmbFilterCustomer.Items.Add("All");
                foreach (DataRow row in dt.Rows)
                {
                    cmbFilterCustomer.Items.Add(new ComboBoxItem(row["Name"].ToString(), row["CustomerID"].ToString()));
                }
                cmbFilterCustomer.SelectedIndex = 0;
            }
            cmbFilterStatus.SelectedIndex = 0;
            dtpFilterFrom.Value = DateTime.Today.AddMonths(-1);
            dtpFilterTo.Value = DateTime.Today;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LoadJobs(
                cmbFilterCustomer.SelectedItem is ComboBoxItem item ? item.Value : null,
                dtpFilterFrom.Value,
                dtpFilterTo.Value,
                cmbFilterStatus.SelectedItem?.ToString()
            );
        }

        private void LoadJobs(string customerId = null, DateTime? fromDate = null, DateTime? toDate = null, string status = null)
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Jobs WHERE 1=1";
                if (!string.IsNullOrEmpty(customerId))
                    query += " AND CustomerID=@CustomerID";
                if (fromDate.HasValue)
                    query += " AND RequestedDate >= @FromDate";
                if (toDate.HasValue)
                    query += " AND RequestedDate <= @ToDate";
                if (!string.IsNullOrEmpty(status) && status != "All")
                    query += " AND Status=@Status";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (!string.IsNullOrEmpty(customerId))
                    da.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);
                if (fromDate.HasValue)
                    da.SelectCommand.Parameters.AddWithValue("@FromDate", fromDate.Value);
                if (toDate.HasValue)
                    da.SelectCommand.Parameters.AddWithValue("@ToDate", toDate.Value);
                if (!string.IsNullOrEmpty(status) && status != "All")
                    da.SelectCommand.Parameters.AddWithValue("@Status", status);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvJobs.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int customerId = int.TryParse(txtCustomerID.Text.Trim(), out int cid) ? cid : 0;
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString();
            DateTime requestedDate = DateTime.TryParse(txtRequestedDate.Text.Trim(), out DateTime rdate) ? rdate : DateTime.Now;
            if (customerId == 0 || string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields except Requested Date are required.");
                return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Jobs (CustomerID, StartLocation, Destination, Status, RequestedDate) VALUES (@CustomerID, @StartLocation, @Destination, @Status, @RequestedDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@RequestedDate", requestedDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadJobs();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0) return;
            int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["JobID"].Value);
            int customerId = int.TryParse(txtCustomerID.Text.Trim(), out int cid) ? cid : 0;
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString();
            DateTime requestedDate = DateTime.TryParse(txtRequestedDate.Text.Trim(), out DateTime rdate) ? rdate : DateTime.Now;
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Jobs SET CustomerID=@CustomerID, StartLocation=@StartLocation, Destination=@Destination, Status=@Status, RequestedDate=@RequestedDate WHERE JobID=@JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@RequestedDate", requestedDate);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadJobs();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0) return;
            int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["JobID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Jobs WHERE JobID=@JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadJobs();
        }

        private void DgvJobs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0) return;
            var row = dgvJobs.SelectedRows[0];
            txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString();
            txtStartLocation.Text = row.Cells["StartLocation"].Value?.ToString();
            txtDestination.Text = row.Cells["Destination"].Value?.ToString();
            cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            txtRequestedDate.Text = row.Cells["RequestedDate"].Value?.ToString();
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }
            public override string ToString() => Text;
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {

        }
    }
}
