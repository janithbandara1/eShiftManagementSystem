using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                lblError.Text = "Please fill all fields.";
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = role == "Admin"
                    ? "SELECT COUNT(*) FROM Admins WHERE Username=@username AND Password=@password"
                    : "SELECT COUNT(*) FROM Customers WHERE Email=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                int customerId = 0;
                if (role == "Customer")
                {
                    string idQuery = "SELECT CustomerID FROM Customers WHERE Email=@username AND Password=@password";
                    using (SqlCommand idCmd = new SqlCommand(idQuery, conn))
                    {
                        idCmd.Parameters.AddWithValue("@username", username);
                        idCmd.Parameters.AddWithValue("@password", password);
                        var result = idCmd.ExecuteScalar();
                        if (result != null)
                            customerId = Convert.ToInt32(result);
                    }
                }
                if (count > 0)
                {
                    lblError.Text = "";
                    this.Hide();
                    if (role == "Admin")
                    {
                        using (var adminDashboard = new AdminDashboardForm())
                        {
                            adminDashboard.ShowDialog();
                        }
                    }
                    else
                    {
                        using (var customerDashboard = new CustomerDashboardForm(customerId))
                        {
                            customerDashboard.ShowDialog();
                        }
                    }
                    this.Close();
                }
                else
                {
                    lblError.Text = "Invalid credentials.";
                }
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
