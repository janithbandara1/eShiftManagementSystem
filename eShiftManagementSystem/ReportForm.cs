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
            cmbReportType.SelectedIndexChanged += CmbReportType_SelectedIndexChanged;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void CmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem?.ToString();
            bool isDateRange = reportType == "Jobs by Date Range";
            dtpFrom.Enabled = isDateRange;
            dtpTo.Enabled = isDateRange;
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
                case "Jobs by Date Range":
                    query = "SELECT * FROM Jobs WHERE RequestedDate >= @FromDate AND RequestedDate <= @ToDate";
                    break;
                case "Delivery Performance":
                    query = "SELECT Status, COUNT(*) AS JobCount FROM Jobs GROUP BY Status";
                    break;
                default:
                    MessageBox.Show("Unknown report type.");
                    return;
            }
            string connStr = ConfigurationManager.ConnectionStrings["eShiftDBConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da;
                if (reportType == "Jobs by Date Range")
                {
                    da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                }
                else
                {
                    da = new SqlDataAdapter(query, conn);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReportResults.DataSource = dt;
                // For Delivery Performance, show completion rate
                if (reportType == "Delivery Performance")
                {
                    int completed = 0, total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        total += Convert.ToInt32(row["JobCount"]);
                        if (row["Status"].ToString() == "Completed")
                            completed = Convert.ToInt32(row["JobCount"]);
                    }
                    double rate = total > 0 ? (double)completed / total * 100 : 0;
                    MessageBox.Show($"Delivery Completion Rate: {rate:F2}%");
                }
            }
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
