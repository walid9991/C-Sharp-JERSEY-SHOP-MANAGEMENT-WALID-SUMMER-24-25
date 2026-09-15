using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WFA_Sample_A;

namespace login_2
{
    public partial class StockManagement : Form
    {
        private DataAccess Da = new DataAccess();
        private DataSet Ds = new DataSet();
        private DataView Dv = new DataView();
        private string managerID;
        private string managerName;

        public StockManagement(String name, string id)
        {
            InitializeComponent();
            this.managerID = id;
            this.managerName = name;
        }
        private int ExecuteUpdateQuery(string sql)
        {
            try
            {
                return this.Da.ExecuteDMLQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database operation failed: " + ex.Message);
                return 0;
            }
        }
        private void StockManagement_Load(object sender, EventArgs e)
        {
            try
            {
                this.Da = new DataAccess();
                InitializeUiState();
                PopulateGridView();
                BuildSizeDropdown();
                ApplySearchFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization failed: " + ex.Message);
            }
        }

        private void InitializeUiState()
        {
            try
            {
                if (this.dgvJersey != null)
                {
                    this.dgvJersey.AutoGenerateColumns = true;
                    this.dgvJersey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.dgvJersey.MultiSelect = false;
                    this.dgvJersey.ReadOnly = false;
                    this.dgvJersey.AllowUserToAddRows = true;
                    this.dgvJersey.AllowUserToDeleteRows = false;
                    this.dgvJersey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (this.txtJerseyID != null)
                {
                    this.txtJerseyID.ReadOnly = true;
                    this.txtJerseyID.Clear();
                }

                if (this.cmbSize != null)
                {
                    this.cmbSize.Items.Clear();
                    this.cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization failed: " + ex.Message);
            }
        }

        private void PopulateGridView()
        {
            try
            {
                string sql = "Select JerseyID, Name, Team, Size, Price, [Stock Quantity] from dbo.Jersey ORDER BY JerseyID;";
                this.Ds = this.Da.ExecuteQuery(sql);
                this.Dv = new DataView(this.Ds.Tables[0]);
                this.dgvJersey.DataSource = this.Dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load jerseys: " + ex.Message);
            }
        }

        private void BuildSizeDropdown()
        {
            try
            {
                if (this.cmbSize == null) return;

                this.cmbSize.Items.Clear();
                this.cmbSize.Items.Add("S");
                this.cmbSize.Items.Add("M");
                this.cmbSize.Items.Add("L");
                this.cmbSize.Items.Add("XL");
                this.cmbSize.Items.Add("XXL");
                this.cmbSize.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Size Not Found: " + ex.Message);
            }
        }

        private void ApplySearchFilter()
        {
            try
            {
                if (this.Dv == null)
                {
                    MessageBox.Show("No data loaded yet. Please refresh first.");
                    return;
                }

                string s = "";
                string filter = "";

                if (this.txtSearch == null)
                {
                    MessageBox.Show("Search box not found!!");
                    return;
                }
                else
                {
                    if (this.txtSearch.Text != null)
                    {
                        s = this.txtSearch.Text.Trim();
                    }
                    else
                    {
                        s = "";
                    }
                }

                if (string.IsNullOrEmpty(s))
                {
                    this.Dv.RowFilter = "";
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        this.Dv.RowFilter = "";
                    }
                    else
                    {
                        s = s.Replace("'", "''");

                        filter = "Convert(JerseyID, 'System.String') LIKE '%" + s + "%' OR Name LIKE '%" + s + "%' OR Team LIKE '%" + s + "%' OR Size LIKE '%" + s + "%'";
                        
                        this.Dv.RowFilter = filter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }
        private void dgvJersey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) 
                return;

                DataGridViewRow row = this.dgvJersey.Rows[e.RowIndex];
                if (row == null || row.IsNewRow) return;

                this.txtJerseyID.Text = row.Cells["JerseyID"].Value?.ToString() ?? "";
                this.txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                this.txtTeam.Text = row.Cells["Team"].Value?.ToString() ?? "";

                string size = row.Cells["Size"].Value?.ToString() ?? "";
                if (this.cmbSize.Items.Contains(size))
                {
                    this.cmbSize.SelectedItem = size;
                }
                else
                {
                    this.cmbSize.SelectedIndex = -1;
                }

                this.txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                this.txtStockQty.Text = row.Cells["Stock Quantity"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selection failed: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.txtName.Text.Trim();
                string team = this.txtTeam.Text.Trim();
                string size = Convert.ToString(this.cmbSize.SelectedItem) ?? "";
                decimal price;
                int qty;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(team) || string.IsNullOrWhiteSpace(size))
                {
                    MessageBox.Show("Fill all required fields.");
                    return;
                }

                if (!decimal.TryParse(this.txtPrice.Text.Trim(), out price))
                {
                    MessageBox.Show("Enter a valid price.");
                    return;
                }

                if (!int.TryParse(this.txtStockQty.Text.Trim(), out qty))
                {
                    MessageBox.Show("Enter a valid stock quantity.");
                    return;
                }

                string sql = "Insert into dbo.Jersey (Name, Team, Size, Price, [Stock Quantity]) values ('" + name.Replace("'", "''") + "', '" + team.Replace("'", "''") + "', '" + size.Replace("'", "''") + "', " + price.ToString("0.##") + ", " + qty + ");";
                int count = ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Jersey Added.");
                    PopulateGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No rows inserted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtJerseyID.Text))
                {
                    MessageBox.Show("Select a jersey to update.");
                    return;
                }

                int id;
                if (!int.TryParse(this.txtJerseyID.Text, out id))
                {
                    MessageBox.Show("Invalid JerseyID.");
                    return;
                }

                string name = this.txtName.Text.Trim();
                string team = this.txtTeam.Text.Trim();
                string size = Convert.ToString(this.cmbSize.SelectedItem) ?? "";

                decimal price;
                int qty;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(team) || string.IsNullOrWhiteSpace(size))
                {
                    MessageBox.Show("Please fill all required fields (Name, Team, Size).");
                    return;
                }

                if (!decimal.TryParse(this.txtPrice.Text.Trim(), out price))
                {
                    MessageBox.Show("Enter a valid price.");
                    return;
                }

                if (!int.TryParse(this.txtStockQty.Text.Trim(), out qty))
                {
                    MessageBox.Show("Enter a valid stock quantity.");
                    return;
                }

                string sql = "Update dbo.Jersey SET Name='" + name.Replace("'", "''") + "', Team='" + team.Replace("'", "''") + "', Size='" + size.Replace("'", "''") + "', Price=" + price.ToString("0.##") + ", [Stock Quantity]=" + qty + " WHERE JerseyID=" + id + ";";
                int count = ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Jersey updated.");
                    PopulateGridView();
                }
                else
                {
                    MessageBox.Show("No rows updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvJersey.CurrentRow == null || this.dgvJersey.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Select a jersey row to delete.");
                    return;
                }

                int id;
                if (!int.TryParse(this.dgvJersey.CurrentRow.Cells["JerseyID"].Value?.ToString(), out id))
                {
                    MessageBox.Show("Invalid JerseyID.");
                    return;
                }

                DialogResult dr = MessageBox.Show("You sure you want to delete this jersey?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                string sql = "Delete from dbo.Jersey where JerseyID=" + id + ";";
                int count = ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Jersey deleted.");
                    PopulateGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No rows deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            try
            {
                this.txtJerseyID.Clear();
                this.txtJerseyID.ReadOnly = true;
                this.txtName.Clear();
                this.txtTeam.Clear();
                this.cmbSize.SelectedIndex = -1;
                this.txtPrice.Clear();
                this.txtStockQty.Clear();
                this.txtSearch.Clear();
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateGridView();
                ApplySearchFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh failed: " + ex.Message);
            }
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerDashboard dashboard = new ManagerDashboard(managerName, managerID);
            dashboard.Show();
            this.Hide();
        }
    }
}
