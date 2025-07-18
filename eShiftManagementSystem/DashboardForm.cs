using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardWidgets();
        }

        private void LoadDashboardWidgets()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // Total Jobs
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Jobs", conn))
                {
                    lblTotalJobs.Text = cmd.ExecuteScalar().ToString();
                }
                // Pending Jobs
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Jobs WHERE Status='Pending'", conn))
                {
                    lblPendingJobs.Text = cmd.ExecuteScalar().ToString();
                }
                // Total Customers
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn))
                {
                    lblTotalCustomers.Text = cmd.ExecuteScalar().ToString();
                }
                // Total Products
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Products", conn))
                {
                    lblTotalProducts.Text = cmd.ExecuteScalar().ToString();
                }
                // Total Loads
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Loads", conn))
                {
                    lblTotalLoads.Text = cmd.ExecuteScalar().ToString();
                }
            }
        }
    }
}
