using login_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashBoard
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl u)
        {
            pnlAdminContainer.Controls.Clear();
            u.Dock = DockStyle.Fill;
            pnlAdminContainer.Controls.Add(u);
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserManagement());
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProductManagement());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Reports());
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            LoginPage back= new LoginPage();
            back.Show();
            this.Close();
        }
    }
}
