using System.Windows.Forms;

namespace eShiftManagementSystem
{
    public partial class HomeForm : Form
    {
        private int customerId;
        public HomeForm(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
        }
    }
}
