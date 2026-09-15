using EmployeeDashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;



namespace login_2
{
    public partial class EmployeeDashboard : Form
    {


        public EmployeeDashboard(string empid, string empname)
        {
            InitializeComponent();
            lblwelcome.Text = "Welcome back, " + empname;
            txtempID.Text = empid;
            txtEmpname.Text = empname;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage();
            log.Show();
            this.Hide();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            string empId = txtempID.Text;
            string empName = txtEmpname.Text;
            SellProduct sell = new SellProduct(empId,empName);
            sell.Show();
            this.Hide();

        }

        private void UpdateInformation_Click(object sender, EventArgs e)
        {
            string empId = txtempID.Text;
            string empName = txtEmpname.Text;

            var ui = new UpdateInformation(empId, empName);
            ui.Show();
            this.Hide();
        }

        private void ManageProducts_Click(object sender, EventArgs e)
        {
            string empId = txtempID.Text; //To know which employee is using the system     
            string empName = txtEmpname.Text; //To know which employee is using the system

            var inv = new ManageInventory(empId, empName); //Opens ManageInventory form with both values
            inv.Show();
            this.Hide();
        }
    }
}
