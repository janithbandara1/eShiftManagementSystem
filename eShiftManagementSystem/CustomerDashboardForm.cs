using System.Windows.Forms;

namespace eShiftManagementSystem
{
    public partial class CustomerDashboardForm : Form
    {
        private int customerId;
        private Form activeForm = null;
        public CustomerDashboardForm(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
            btnHome.Click += (s, e) => ShowWelcome();
            btnProfile.Click += (s, e) => OpenChildForm(new CustomerProfileForm(customerId));
            btnCustomerJobs.Click += (s, e) => OpenChildForm(new CustomerJobsForm(customerId));
            btnLogout.Click += (s, e) => { Logout(); };
            this.Load += CustomerDashboardForm_Load;
        }

        private void CustomerDashboardForm_Load(object sender, System.EventArgs e)
        {
            ShowWelcome();
        }

        private void ShowWelcome()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            var homeForm = new HomeForm(customerId);
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(homeForm);
            homeForm.Show();
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
