using System;
using System.Data;
using System.Windows.Forms;
using WFA_Sample_A;
namespace login_2
{
    public partial class ReviewRestock : Form
    {
        private DataAccess Da = null!;
        private DataSet Ds = new DataSet();
        private DataView? Dv = null;
        private string managerID;
        private string managerName;

        public ReviewRestock(String name, string id)
        {
            InitializeComponent();
            this.managerID = id;
            this.managerName = name;
            try
            {
                this.Da = new DataAccess();
                InitializeUi();
                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization failed: " + ex.Message);
            }
        }
        private void InitializeUi()
        {
            try
            {
                if (this.dgvRequests != null)
                {
                    this.dgvRequests.AutoGenerateColumns = true;
                    this.dgvRequests.ReadOnly = true;
                    this.dgvRequests.AllowUserToAddRows = false;
                    this.dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (this.txtRequestID != null) this.txtRequestID.ReadOnly = true;
                if (this.txtJerseyID != null) this.txtJerseyID.ReadOnly = true;

                if (this.cmbSize != null)
                {
                    this.cmbSize.Items.Clear();
                    this.cmbSize.Items.Add("S");
                    this.cmbSize.Items.Add("M");
                    this.cmbSize.Items.Add("L");
                    this.cmbSize.Items.Add("XL");
                    this.cmbSize.Items.Add("XXL");
                    this.cmbSize.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UI setup failed: " + ex.Message);
            }
        }
        private void LoadRequests()
        {
            try
            {
                string sql = "Select RequestID, JerseyID, Size, RequestedQty, EmpID, Note, Status, CreatedAt FROM dbo.StockRequests ORDER BY CreatedAt DESC;";
                this.Ds = this.Da.ExecuteQuery(sql);
                if (this.Ds != null && this.Ds.Tables.Count > 0)
                {
                    this.Dv = new DataView(this.Ds.Tables[0]);
                    this.dgvRequests.DataSource = this.Dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load requests failed: " + ex.Message);
            }
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

        private void ApplySearchFilter()
        {
            try
            {
                if (this.Dv == null)
                    return;

                string s = "";
                if (this.txtSearch != null && this.txtSearch.Text != null)
                {
                    s = this.txtSearch.Text.Trim();
                }

                if (string.IsNullOrEmpty(s))
                {
                    this.Dv.RowFilter = "";
                }
                else
                {
                    s = s.Replace("'", "''");
                    string f1 = "Convert(RequestID,'System.String') LIKE '%" + s + "%'";
                    string f2 = "Convert(JerseyID,'System.String') LIKE '%" + s + "%'";
                    string f3 = "Size LIKE '%" + s + "%'";
                    string f4 = "Convert(RequestedQty,'System.String') LIKE '%" + s + "%'";
                    string f5 = "EmpID LIKE '%" + s + "%'";
                    string f6 = "Status LIKE '%" + s + "%'";
                    this.Dv.RowFilter = f1 + " OR " + f2 + " OR " + f3 + " OR " + f4 + " OR " + f5 + " OR " + f6;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void FillFieldsFromRowIndex(int rowIndex)
        {
            try
            {
                if (rowIndex < 0) return;
                DataGridViewRow row = this.dgvRequests.Rows[rowIndex];
                if (row == null || row.IsNewRow)
                {
                    return;
                }

                if (this.txtRequestID != null)
                {
                    this.txtRequestID.Text = row.Cells["RequestID"].Value?.ToString() ?? "";
                }

                if (this.txtJerseyID != null)
                {
                    this.txtJerseyID.Text = row.Cells["JerseyID"].Value?.ToString() ?? "";
                }

                if (this.txtQuantity != null)
                {
                    this.txtQuantity.Text = row.Cells["RequestedQty"].Value?.ToString() ?? "";
                }

                string sz = row.Cells["Size"].Value?.ToString() ?? "";

                if (this.cmbSize != null)
                {
                    {
                        if (!string.IsNullOrEmpty(sz) && this.cmbSize.Items.Contains(sz))
                            this.cmbSize.SelectedItem = sz;
                        else
                            this.cmbSize.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to read selected row: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            try
            {
                if (this.txtRequestID != null)
                {
                    this.txtRequestID.Clear();
                }
                if (this.txtJerseyID != null)
                {
                    this.txtJerseyID.Clear();
                }
                if (this.txtQuantity != null)
                {
                    this.txtQuantity.Clear();
                }
                if (this.cmbSize != null)
                {
                    this.cmbSize.SelectedIndex = -1;
                }
            }
            catch { }
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillFieldsFromRowIndex(e.RowIndex);
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillFieldsFromRowIndex(e.RowIndex);
        }

        private void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvRequests != null && this.dgvRequests.CurrentRow != null)
                {
                    FillFieldsFromRowIndex(this.dgvRequests.CurrentRow.Index);
                }
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtRequestID.Text))
                {
                    MessageBox.Show("Select a request first.");
                    {
                        return;
                    }
                }

                int requestId = 0;
                int qty = 0;
                if (!int.TryParse(this.txtRequestID.Text.Trim(), out requestId))
                {
                    MessageBox.Show("Invalid RequestID.");
                    {
                        return;
                    }
                }

                if (!int.TryParse(this.txtQuantity.Text.Trim(), out qty) || qty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive number.");
                    {
                        return;
                    }
                }

                string size = Convert.ToString(this.cmbSize?.SelectedItem) ?? "";
                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Select a size.");
                    {
                        return;
                    }
                }

                string upSql = "Update dbo.StockRequests set Size='" + size.Replace("'", "''") + "', RequestedQty=" + qty + " WHERE RequestID=" + requestId + ";";
                int cnt = ExecuteUpdateQuery(upSql);

                if (cnt == 1)
                {
                    MessageBox.Show("Request updated.");
                    LoadRequests();
                }
                else
                {
                    MessageBox.Show("No changes were saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtRequestID.Text) || string.IsNullOrWhiteSpace(this.txtJerseyID.Text))
                {
                    MessageBox.Show("Select a request first.");
                    return;
                }

                int jerseyId = 0;
                int qty = 0;
                if (!int.TryParse(this.txtJerseyID.Text.Trim(), out jerseyId))
                {
                    MessageBox.Show("Invalid JerseyID.");
                    return;
                }
                if (!int.TryParse(this.txtQuantity.Text.Trim(), out qty) || qty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive number.");
                    return;
                }

                string size = Convert.ToString(this.cmbSize?.SelectedItem) ?? "";
                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Choose a size.");
                    return;
                }

                string checkSql = "Select COUNT(*) from dbo.Jersey where JerseyID=" + jerseyId + " AND Size='" + size.Replace("'", "''") + "';";

                object res = this.Da.ExecuteScalar(checkSql);
                int exists = 0;
                if (res != null)
                {
                    int.TryParse(res.ToString(), out exists);
                }

                if (exists <= 0)
                {
                    MessageBox.Show("Jersey with this ID and name does not exist.");
                    return;
                }

                string updSql = "Update dbo.Jersey set [Stock Quantity] = [Stock Quantity] + " + qty + " where JerseyID=" + jerseyId + " AND Size='" + size.Replace("'", "''") + "';";
                int u = ExecuteUpdateQuery(updSql);

                int requestId = Convert.ToInt32(this.txtRequestID.Text.Trim());
                string delSql = "Delete from dbo.StockRequests where RequestID=" + requestId + ";";
                int d = ExecuteUpdateQuery(delSql);

                if (u > 0 && d > 0)
                {
                    MessageBox.Show("Request accepted and stock updated.");
                    LoadRequests();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Operation did not complete yet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Accept failed: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtRequestID.Text))
                {
                    MessageBox.Show("Select a request to delete.");
                    return;
                }

                int requestId = Convert.ToInt32(this.txtRequestID.Text.Trim());
                string delSql = "Delete from dbo.StockRequests where RequestID=" + requestId + ";";
                int c = ExecuteUpdateQuery(delSql);

                if (c == 1)
                {
                    MessageBox.Show("Request deleted.");
                    LoadRequests();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No row deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
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
