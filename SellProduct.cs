using EmployeeDashboard;
using System.Data;
using WFA_Sample_A;


namespace login_2
{
    public partial class SellProduct : Form
    {

        DataAccess da=new DataAccess();
        DataView dv=new DataView();
        DataTable dt = new DataTable();
        private DataTable products = new DataTable();
        string EmpID;
        string EmpName;
        public SellProduct(string empid, string empname)
        {
            InitializeComponent();
            EmpID = empid;
            EmpName = empname;
            dgvProduct.AutoGenerateColumns = true;
            dgvProduct.ReadOnly = true;
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowProducts();
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Size");

            comboBox1.SelectedIndex = 0;
        }

        private void ShowProducts()
        {
            try
            {

                dt = da.ExecuteQueryTable("SELECT * FROM [dbo].[Jersey];");
                products = dt;
                dgvProduct.DataSource = products;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Generating Information: " + ex.Message, "LoadJerseyTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void productGridSearch(object sender, EventArgs e)
        {
            if (products.Rows.Count == 0)
            {  return; }
                

            string column = comboBox1.SelectedItem?.ToString() ?? "";
            string filterText = searchTextBox.Text.Trim();


            filterText = filterText.Replace("'", "''");
            dv = products.DefaultView;

            if (string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"{column} LIKE '%{filterText}%'";
            }

            dgvProduct.DataSource = dv;
        }

        private void SortCombobox(object sender, EventArgs e)
        {
            string column = comboBox1.SelectedItem?.ToString() ?? " "; // "Name" or "Team"

            dv = products.DefaultView;
            dv.Sort = column + " ASC";

            dgvProduct.DataSource = dv;

        }
        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            EmployeeDashboard back = new EmployeeDashboard(EmpID, EmpName);
            back.Show();
            this.Hide();
        }

        private void ProcessToSaleBtn_work(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from the cart!");
                return;
            }
            var row = dgvCart.SelectedRows[0];

            string productID = row.Cells["JerseyID"].Value?.ToString()??"0";
            string quantity = row.Cells["JerseyQuantity"].Value?.ToString()??"0";
            string unitPrice = row.Cells["UnitPrice"].Value?.ToString()??"0";
            decimal price = Convert.ToDecimal(unitPrice);
            int qty = Convert.ToInt32(quantity);
            decimal totalprice= (price * qty);
            EmployeeControl3 sellInfo = new EmployeeControl3(EmpID, EmpName, productID, quantity, unitPrice,totalprice);
            sellInfo.ShowDialog();
            if (sellInfo.SaleConfirmed) 
            {
                dgvCart.Rows.Remove(row);
                CalculateGrandTotal();
                ShowProducts();
            }


        }
     
        private void AddToCart_Click(object sender, EventArgs e)
        {

            if (dgvProduct.SelectedRows.Count == 0)
            { return; }
                

            var row = dgvProduct.SelectedRows[0];
            string id = row.Cells["JerseyID"]?.Value.ToString() ?? "0";
            string name = row.Cells["Name"]?.Value.ToString() ?? "0";
            string team = row.Cells["Team"]?.Value.ToString() ?? "0";
            string size = row.Cells["Size"]?.Value.ToString() ?? "0";
            decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);
            int stockQty = Convert.ToInt32(row.Cells["Stock Quantity"].Value);

            foreach (DataGridViewRow cartRow in dgvCart.Rows)
            {
                if (cartRow.IsNewRow)
                {
                    continue;
                }

                string jerseyId = cartRow.Cells["JerseyID"].Value?.ToString() ?? "";
                string rowSize = cartRow.Cells["Size"].Value?.ToString() ?? "";

                if (jerseyId == id && rowSize == size)
                {
                    int qty = 0;
                    if (cartRow.Cells["JerseyQuantity"].Value != null)
                    {
                        qty = Convert.ToInt32(cartRow.Cells["JerseyQuantity"].Value);
                    }
                    if (qty + 1 > stockQty)
                    {
                        MessageBox.Show("Item is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cartRow.Cells["JerseyQuantity"].Value = qty + 1;

                    CalculateGrandTotal();
                    return;
                }
            }
            if (stockQty < 1)
            {
                MessageBox.Show("Item is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvCart.Rows.Add(id, name, team, unitPrice, size, 1);

            CalculateGrandTotal();
        }
        private void CalculateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["UnitPrice"].Value != null && row.Cells["JerseyQuantity"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    int qty = Convert.ToInt32(row.Cells["JerseyQuantity"].Value);
                    grandTotal += price * qty;
                }
            }

            totalpricelbl.Text = grandTotal.ToString("0.00") + " BDT ";
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.CurrentRow == null || dgvCart.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please select an item to remove from the cart.");
                    return;
                }
                dgvCart.Rows.RemoveAt(dgvCart.CurrentRow.Index);
                decimal grandTotal = 0;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    var priceCell = row.Cells["UnitPrice"];
                    var qtyCell = row.Cells["JerseyQuantity"];

                    if (priceCell.Value != null && qtyCell.Value != null)
                    {
                        grandTotal += Convert.ToDecimal(priceCell.Value) * Convert.ToInt32(qtyCell.Value);
                    }
                }
                totalpricelbl.Text = grandTotal.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

