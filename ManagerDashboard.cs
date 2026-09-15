using System;
using System.Windows.Forms;

namespace login_2
{
    public partial class ManagerDashboard : Form
    {
        private string managerId = string.Empty;
        private string managerName = string.Empty;

        public ManagerDashboard()
        {
            InitializeComponent();
        }
        public ManagerDashboard(string id, string name)
        {
            InitializeComponent();

            managerId = id;
            managerName = name;


            lblWelcome.Text = "Welcome, " + managerName;
            txtManagerID.Text = managerId;
            txtManagerName.Text = managerName;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {

            LoginPage log = new LoginPage();
            log.Show();
            this.Hide();
        }

        private void btnReviewRestock_Click(object sender, EventArgs e)
        {
            var review = new ReviewRestock(managerId, managerName);
            review.Owner = this; 
            this.Hide();
            review.Show();
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            var manage = new StockManagement(managerName, managerId);
            manage.Owner = this; 
            this.Hide();
            manage.Show();
        }

        private void btnProfileOverview_Click(object sender, EventArgs e)
        {
            ManUpdateInformation Update = new ManUpdateInformation(managerName, managerId);
            Update.Owner = this;
            this.Hide();
            Update.Show();
        }

        private void txtManagerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtManagerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}