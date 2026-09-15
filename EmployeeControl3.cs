
using System.Data;
using Microsoft.Data.SqlClient;
using WFA_Sample_A;

namespace EmployeeDashboard
{

    public partial class EmployeeControl3 : Form
    {
        private DataAccess da;
        public bool SaleConfirmed = false;
        private DataTable dt = new DataTable();
        public EmployeeControl3(string empid, string empname, string jerseyID, string quantity, string Unitprice, decimal totalprice)
        {

            InitializeComponent();
            txtProductID.Text = jerseyID;
            txtProductQuantity.Text = quantity;
            txtPrice.Text = Unitprice;
            txttotalprice.Text = totalprice.ToString("0.00");
            txtEmpID.Text = empid;
            txtEmpName.Text = empname;
            da = new DataAccess();
            dgvCustomerInfo.AutoGenerateColumns = true;
            dgvCustomerInfo.ReadOnly = true;
            dgvCustomerInfo.AllowUserToAddRows = false;
            dgvCustomerInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ShowJerseyTable();
        }

        private void ShowJerseyTable()
        {
            try
            {
                dt = da.ExecuteQueryTable("SELECT * FROM [dbo].[sell Info];");
                dgvCustomerInfo.DataSource = dt;
                dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "ShowJerseyTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtGmail.Text.Trim();//a string function trim for remove any unusual space;
            if (!email.ToLower().EndsWith("@gmail.com"))
            {
                emailerror.Text = "Please enter a valid email address.";
            }
            else
            {
                emailerror.Text = "";

            }
        }

        private void btnReset_Click(object? sender, EventArgs? e)
        {
            this.txtCusName.Clear();
            this.txtGmail.Clear();
        }
        private void removebtn_Click(object sender, EventArgs e)
        {
            if (dgvCustomerInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(dgvCustomerInfo.SelectedRows[0].Cells["Product ID"].Value);
            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            } 

            try
            {
                string query = "DELETE FROM [dbo].[sell Info] WHERE [Product ID] = '" + selectedId + "'";
                int rows = da.ExecuteUpdateQuery(query);

                if (rows > 0)
                {
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowJerseyTable(); // Refresh the grid
                }
                else
                {
                MessageBox.Show("Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCusName.Text))
            {
                MessageBox.Show("Please Fillup all the fields. ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure want to Confirm this sale?", "Confirm Sale",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string insertSellInfo = "INSERT INTO [dbo].[sell Info] " +
                                        "([Product ID],[Customer Name],[Gmail],[Quantity],[Purchase Date],[Price]) " +
                                        "VALUES(@ProductID,@CustomerName,@Gmail,@Quantity,@PurchaseDate,@Price); " +
                                        "SELECT SCOPE_IDENTITY();";

                da.Sqlcom = new SqlCommand(insertSellInfo, da.Sqlcon);
                da.Sqlcom.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                da.Sqlcom.Parameters.AddWithValue("@CustomerName", txtCusName.Text.Trim());
                da.Sqlcom.Parameters.AddWithValue("@Gmail", txtGmail.Text.Trim());
                da.Sqlcom.Parameters.AddWithValue("@Quantity", txtProductQuantity.Text.Trim());
                da.Sqlcom.Parameters.AddWithValue("@PurchaseDate", DateTime.Now.Date);
                da.Sqlcom.Parameters.AddWithValue("@Price", txttotalprice.Text.Trim());

                int sellId = Convert.ToInt32(da.Sqlcom.ExecuteScalar());

                if (sellId > 0)
                {
                    
                    string updateStock = "UPDATE [dbo].[Jersey] " +
                                         "SET [Stock Quantity] = [Stock Quantity] - @SoldQty " +
                                         "WHERE JerseyID = @ProductID";
                    da.Sqlcom = new SqlCommand(updateStock, da.Sqlcon);
                    da.Sqlcom.Parameters.AddWithValue("@SoldQty", txtProductQuantity.Text.Trim());
                    da.Sqlcom.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                    da.Sqlcom.ExecuteNonQuery();

                    string empStatsQuery = "INSERT INTO [dbo].[Emp Sell Stats] " +
                                           "([Sell ID],[EmpID],[EmpName],[Price]) " +
                                           "VALUES(@SellID,@EmpID,@EmpName,@Price)";
                    da.Sqlcom = new SqlCommand(empStatsQuery, da.Sqlcon);
                    da.Sqlcom.Parameters.AddWithValue("@SellID", sellId);
                    da.Sqlcom.Parameters.AddWithValue("@EmpID", txtEmpID.Text.Trim());
                    da.Sqlcom.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
                    da.Sqlcom.Parameters.AddWithValue("@Price", txttotalprice.Text.Trim());
                    da.Sqlcom.ExecuteNonQuery();

                    SaleConfirmed = true;
                    MessageBox.Show("Sale confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowJerseyTable();
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
