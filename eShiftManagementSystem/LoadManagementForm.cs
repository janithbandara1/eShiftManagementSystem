using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class LoadManagementForm : Form
    {
        public LoadManagementForm()
        {
            InitializeComponent();
            LoadLoads();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvLoads.SelectionChanged += DgvLoads_SelectionChanged;
        }

        private void LoadLoads()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Loads", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoads.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int jobId = int.TryParse(txtJobID.Text.Trim(), out int jid) ? jid : 0;
            int productId = int.TryParse(txtProductID.Text.Trim(), out int pid) ? pid : 0;
            int transportUnitId = int.TryParse(txtTransportUnitID.Text.Trim(), out int tuid) ? tuid : 0;
            double weight = double.TryParse(txtWeight.Text.Trim(), out double w) ? w : 0;
            string description = txtDescription.Text.Trim();
            if (jobId == 0 || productId == 0 || transportUnitId == 0)
            {
                MessageBox.Show("JobID, ProductID, and TransportUnitID are required.");
                return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Loads (JobID, ProductID, TransportUnitID, Weight, Description) VALUES (@JobID, @ProductID, @TransportUnitID, @Weight, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadLoads();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLoads.SelectedRows.Count == 0) return;
            int loadId = Convert.ToInt32(dgvLoads.SelectedRows[0].Cells["LoadID"].Value);
            int jobId = int.TryParse(txtJobID.Text.Trim(), out int jid) ? jid : 0;
            int productId = int.TryParse(txtProductID.Text.Trim(), out int pid) ? pid : 0;
            int transportUnitId = int.TryParse(txtTransportUnitID.Text.Trim(), out int tuid) ? tuid : 0;
            double weight = double.TryParse(txtWeight.Text.Trim(), out double w) ? w : 0;
            string description = txtDescription.Text.Trim();
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Loads SET JobID=@JobID, ProductID=@ProductID, TransportUnitID=@TransportUnitID, Weight=@Weight, Description=@Description WHERE LoadID=@LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@LoadID", loadId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadLoads();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoads.SelectedRows.Count == 0) return;
            int loadId = Convert.ToInt32(dgvLoads.SelectedRows[0].Cells["LoadID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Loads WHERE LoadID=@LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoadID", loadId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadLoads();
        }

        private void DgvLoads_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoads.SelectedRows.Count == 0) return;
            var row = dgvLoads.SelectedRows[0];
            txtJobID.Text = row.Cells["JobID"].Value?.ToString();
            txtProductID.Text = row.Cells["ProductID"].Value?.ToString();
            txtTransportUnitID.Text = row.Cells["TransportUnitID"].Value?.ToString();
            txtWeight.Text = row.Cells["Weight"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
        }

        private void LoadManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
