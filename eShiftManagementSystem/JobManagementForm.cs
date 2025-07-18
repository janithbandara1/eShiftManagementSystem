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
            LoadJobs();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvJobs.SelectionChanged += DgvJobs_SelectionChanged;
        }

        private void LoadJobs()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Jobs", conn);
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
    }
}
