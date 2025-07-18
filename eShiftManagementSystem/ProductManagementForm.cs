using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
            LoadProducts();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
        }

        private void LoadProducts()
        {
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            string description = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Product Name is required.");
                return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Products (ProductName, Description) VALUES (@ProductName, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadProducts();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            string productName = txtProductName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Products SET ProductName=@ProductName, Description=@Description WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadProducts();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Products WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadProducts();
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            var row = dgvProducts.SelectedRows[0];
            txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
        }
    }
}
