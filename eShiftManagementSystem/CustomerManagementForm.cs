using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
            LoadCustomers();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            btnSearch.Click += BtnSearch_Click;
        }

        private void LoadCustomers()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Name, Email, and Password are required.");
                return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Customers (Name, Email, Phone, Address, Password) VALUES (@Name, @Email, @Phone, @Address, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadCustomers();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0) return;
            int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text;
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Customers SET Name=@Name, Email=@Email, Phone=@Phone, Address=@Address, Password=@Password WHERE CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadCustomers();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0) return;
            int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadCustomers();
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0) return;
            var row = dgvCustomers.SelectedRows[0];
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtPassword.Text = row.Cells["Password"].Value?.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomers(txtSearch.Text.Trim());
        }

        private void SearchCustomers(string searchTerm)
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query;
                SqlDataAdapter da;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    query = "SELECT * FROM Customers";
                    da = new SqlDataAdapter(query, conn);
                }
                else if (int.TryParse(searchTerm, out int id))
                {
                    query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
                    da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@CustomerID", id);
                }
                else
                {
                    query = "SELECT * FROM Customers WHERE Name LIKE @Name";
                    da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@Name", "%" + searchTerm + "%");
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }
    }
}
