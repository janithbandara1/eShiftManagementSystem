using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class TransportUnitManagementForm : Form
    {
        public TransportUnitManagementForm()
        {
            InitializeComponent();
            LoadTransportUnits();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvTransportUnits.SelectionChanged += DgvTransportUnits_SelectionChanged;
        }

        private void LoadTransportUnits()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TransportUnits", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTransportUnits.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string lorryNumber = txtLorryNumber.Text.Trim();
            string driverName = txtDriverName.Text.Trim();
            string assistantName = txtAssistantName.Text.Trim();
            string containerDetails = txtContainerDetails.Text.Trim();
            if (string.IsNullOrEmpty(lorryNumber) || string.IsNullOrEmpty(driverName))
            {
                MessageBox.Show("Lorry Number and Driver Name are required.");
                return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO TransportUnits (LorryNumber, DriverName, AssistantName, ContainerDetails) VALUES (@LorryNumber, @DriverName, @AssistantName, @ContainerDetails)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryNumber", lorryNumber);
                cmd.Parameters.AddWithValue("@DriverName", driverName);
                cmd.Parameters.AddWithValue("@AssistantName", assistantName);
                cmd.Parameters.AddWithValue("@ContainerDetails", containerDetails);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTransportUnits();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTransportUnits.SelectedRows.Count == 0) return;
            int transportUnitId = Convert.ToInt32(dgvTransportUnits.SelectedRows[0].Cells["TransportUnitID"].Value);
            string lorryNumber = txtLorryNumber.Text.Trim();
            string driverName = txtDriverName.Text.Trim();
            string assistantName = txtAssistantName.Text.Trim();
            string containerDetails = txtContainerDetails.Text.Trim();
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE TransportUnits SET LorryNumber=@LorryNumber, DriverName=@DriverName, AssistantName=@AssistantName, ContainerDetails=@ContainerDetails WHERE TransportUnitID=@TransportUnitID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryNumber", lorryNumber);
                cmd.Parameters.AddWithValue("@DriverName", driverName);
                cmd.Parameters.AddWithValue("@AssistantName", assistantName);
                cmd.Parameters.AddWithValue("@ContainerDetails", containerDetails);
                cmd.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTransportUnits();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransportUnits.SelectedRows.Count == 0) return;
            int transportUnitId = Convert.ToInt32(dgvTransportUnits.SelectedRows[0].Cells["TransportUnitID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM TransportUnits WHERE TransportUnitID=@TransportUnitID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTransportUnits();
        }

        private void DgvTransportUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransportUnits.SelectedRows.Count == 0) return;
            var row = dgvTransportUnits.SelectedRows[0];
            txtLorryNumber.Text = row.Cells["LorryNumber"].Value?.ToString();
            txtDriverName.Text = row.Cells["DriverName"].Value?.ToString();
            txtAssistantName.Text = row.Cells["AssistantName"].Value?.ToString();
            txtContainerDetails.Text = row.Cells["ContainerDetails"].Value?.ToString();
        }
    }
}
