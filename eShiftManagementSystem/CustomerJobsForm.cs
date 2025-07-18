using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class CustomerJobsForm : Form
    {
        private int customerId;
        public CustomerJobsForm(int customerId)
        {
            this.customerId = customerId;
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Jobs WHERE CustomerID=@CustomerID", conn);
                da.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvJobs.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            DateTime requestedDate = dtpRequestedDate.Value;
            string status = txtStatus.Text.Trim();
            if (string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required.");
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
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            DateTime requestedDate = dtpRequestedDate.Value;
            string status = txtStatus.Text.Trim();
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Jobs SET StartLocation=@StartLocation, Destination=@Destination, Status=@Status, RequestedDate=@RequestedDate WHERE JobID=@JobID AND CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@RequestedDate", requestedDate);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
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
                string query = "DELETE FROM Jobs WHERE JobID=@JobID AND CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadJobs();
        }

        private void DgvJobs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0) return;
            var row = dgvJobs.SelectedRows[0];
            txtStartLocation.Text = row.Cells["StartLocation"].Value?.ToString();
            txtDestination.Text = row.Cells["Destination"].Value?.ToString();
            txtStatus.Text = row.Cells["Status"].Value?.ToString();
            dtpRequestedDate.Value = row.Cells["RequestedDate"].Value != null ? Convert.ToDateTime(row.Cells["RequestedDate"].Value) : DateTime.Now;
        }
    }
}
