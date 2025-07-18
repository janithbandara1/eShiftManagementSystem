using System.Windows.Forms;

namespace eShiftManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        private Form activeForm = null;
        public AdminDashboardForm()
        {
            InitializeComponent();
            btnMainDashboard.Click += (s, e) => { OpenChildForm(new DashboardForm()); };
            btnCustomerManagement.Click += (s, e) => { OpenChildForm(new CustomerManagementForm()); };
            btnAdminManagement.Click += (s, e) => { OpenChildForm(new AdminManagementForm()); };
            btnJobManagement.Click += (s, e) => { OpenChildForm(new JobManagementForm()); };
            btnLoadManagement.Click += (s, e) => { OpenChildForm(new LoadManagementForm()); };
            btnProductManagement.Click += (s, e) => { OpenChildForm(new ProductManagementForm()); };
            btnReport.Click += (s, e) => { OpenChildForm(new ReportForm()); };
            btnTransportUnitManagement.Click += (s, e) => { OpenChildForm(new TransportUnitManagementForm()); };
            btnLogout.Click += (s, e) => { Logout(); };
            this.Load += AdminDashboardForm_Load;
        }

        private void AdminDashboardForm_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(new DashboardForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void Logout()
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
