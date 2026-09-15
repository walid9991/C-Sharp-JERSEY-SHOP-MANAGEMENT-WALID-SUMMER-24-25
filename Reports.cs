
using System.Data;
using WFA_Sample_A;

namespace AdminDashBoard
{
    public partial class Reports : UserControl
    {
        private DataAccess da;
        DataTable dt = new DataTable();
        private DataTable reports = new DataTable();
        public Reports()
        {
            InitializeComponent();
            da = new DataAccess();
            dgvReportsList.AutoGenerateColumns = true;
            dgvReportsList.ReadOnly = true;
            dgvReportsList.AllowUserToAddRows = true;
            dgvReportsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowReports();
        }

        public void ShowReports()
        {
            try
            {
                string query =
                "SELECT s.[Sale ID], s.[Product ID], s.[Quantity], s.[Price], j.[Stock Quantity], e.[EmpName], e.[EmpID] " +
                "FROM [Sell Info] AS s " +
                "INNER JOIN [Emp Sell Stats] AS e ON s.[Sale ID] = e.[Sell ID] " +
                "INNER JOIN [Jersey] AS j ON s.[Product ID] = j.[JerseyID]";
                dt = da.ExecuteQueryTable(query);
                reports = dt;
                dgvReportsList.DataSource = reports;
                dgvReportsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ShowTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "LoadingJerseyTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowTotals()
        {
            try
            {
                string queryTotals =
                "SELECT " +
                "SUM(s.[Price]) AS TotalSales, " +
                "SUM(s.[Quantity]) AS TotalSold, " +
                "SUM(j.[Stock Quantity]) AS TotalInventory " +
                "FROM [Sell Info] AS s " +
                "INNER JOIN [Jersey] AS j ON s.[Product ID] = j.[JerseyID]";

                 dt = da.ExecuteQueryTable(queryTotals);

                if (dt.Rows.Count > 0)
                {
                    txtSales.Text = dt.Rows[0]["TotalSales"].ToString()+" BDT ";
                    txttotalSold.Text = dt.Rows[0]["TotalSold"].ToString();
                    txtInventory.Text = dt.Rows[0]["TotalInventory"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot able to calculating totals: " + ex.Message, "ShowTotals", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
