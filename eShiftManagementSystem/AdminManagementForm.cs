using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class AdminManagementForm : Form
    {
        public AdminManagementForm()
        {
            InitializeComponent();
            LoadAdmins();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvAdmins.SelectionChanged += DgvAdmins_SelectionChanged;
        }

        private void LoadAdmins()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Admins", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAdmins.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password are required.");
                return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Admins (Username, Password) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAdmins();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0) return;
            int adminId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["AdminID"].Value);
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Admins SET Username=@Username, Password=@Password WHERE AdminID=@AdminID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@AdminID", adminId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAdmins();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0) return;
            int adminId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["AdminID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Admins WHERE AdminID=@AdminID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminID", adminId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAdmins();
        }

        private void DgvAdmins_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0) return;
            var row = dgvAdmins.SelectedRows[0];
            txtUsername.Text = row.Cells["Username"].Value?.ToString();
            txtPassword.Text = row.Cells["Password"].Value?.ToString();
        }
    }
}
