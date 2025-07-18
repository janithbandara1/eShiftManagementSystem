using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace eShiftManagementSystem
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            btnGenerateReport.Click += BtnGenerateReport_Click;
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Please select a report type.");
                return;
            }
            string query = "";
            switch (reportType)
            {
                case "All Jobs":
                    query = "SELECT * FROM Jobs";
                    break;
                case "Jobs by Status":
                    query = "SELECT Status, COUNT(*) AS JobCount FROM Jobs GROUP BY Status";
                    break;
                case "Jobs by Customer":
                    query = "SELECT c.Name, COUNT(j.JobID) AS JobCount FROM Customers c LEFT JOIN Jobs j ON c.CustomerID = j.CustomerID GROUP BY c.Name";
                    break;
                case "Loads by Transport Unit":
                    query = "SELECT tu.LorryNumber, COUNT(l.LoadID) AS LoadCount FROM TransportUnits tu LEFT JOIN Loads l ON tu.TransportUnitID = l.TransportUnitID GROUP BY tu.LorryNumber";
                    break;
                case "Products List":
                    query = "SELECT * FROM Products";
                    break;
                default:
                    MessageBox.Show("Unknown report type.");
                    return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReportResults.DataSource = dt;
            }
        }
    }
}
