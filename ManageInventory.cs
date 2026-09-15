using System;
using System.Data;
using Microsoft.Data.SqlClient;
using WFA_Sample_A;

namespace login_2
{
    public partial class ManageInventory : Form
    {
        private DataAccess Da { get; set; } = null!; //accepts Nullable values(compiler expects it to always have                                                                                                   
        private DataSet Ds { get; set; } = null!;  //accepts Nullable values
        private string Sql { get; set; } = string.Empty; //null! tells the compiler “I will initialize this before use"

        private string empID = ""; //To know which employee is using the system
        private string empName = "";

        public ManageInventory()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                InitializeUiState();
                PopulateGridView();
                Filtering();
                ApplyFilters();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Initialization failed: " + ex.Message);
            }
        }

        public ManageInventory(string empId, string empName)
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                this.empID = empId ?? "";
                this.empName = empName ?? "";
                InitializeUiState();
                PopulateGridView();
                Filtering();
                ApplyFilters();
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
                if (this.cboStockStatus != null)
                {
                    this.cboStockStatus.Items.Clear(); 
                    this.cboStockStatus.Items.Add("All");
                    this.cboStockStatus.Items.Add("In Stock");
                    this.cboStockStatus.Items.Add("Low (≤5)");
                    this.cboStockStatus.Items.Add("Out (0)");
                    this.cboStockStatus.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void PopulateGridView(string sql = "Select JerseyID, Name, Team, Size, Price, [Stock Quantity] as StockQuantity from dbo.Jersey order by JerseyID;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql); //full query result is stored inside Ds 
                this.dgvInventory.DataSource = this.Ds.Tables[0]; //executes the query in the gridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load inventory: " + ex.Message);
            }
        }

        private int ExecuteUpdateQuery(string sql) //avoid repeating the same code/query in everywhere
        {
            try
            {
                return this.Da.ExecuteDMLQuery(sql);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database load failed: " + ex.Message);
                return 0;
            }
        }

        private void Filtering()
        {
            try
            {
                if (this.Ds == null || this.Ds.Tables.Count == 0) 
                    return; //DataSet এ ডাটা নাই, গ্রিডে দেখানোর মতো টেবিল না এলে কাজ বন্ধ করে দেয়।

                DataTable dt = this.Ds.Tables[0];

                if (this.cboTeam != null)
                {
                    this.cboTeam.Items.Clear();//Remove all existing items from the cboTeam ComboBox
                    this.cboTeam.Items.Add("All");

                    int i;
                    for (i = 0; i < dt.Rows.Count; i++) //সব Row ঘুরে ইউনিক Team যোগ করা
                    {
                        string team = dt.Rows[i]["Team"] != DBNull.Value ? dt.Rows[i]["Team"]?.ToString() ?? string.Empty : string.Empty; //taking the Team name from the database table row.
                        //If value is null in the database, it stores an empty string ("") instead of crashing.
                        if (!string.IsNullOrWhiteSpace(team))
                        {
                            bool exists = false; //created "exists" to check whether the current team name is already in ComboBox or not.
                            foreach (var item in this.cboTeam.Items)
                            {
                                //যদি ComboBox এ একই টিম নাম পাওয়া যায় তাহলে exists = true করে বের হয়ে আসে
                                if (item?.ToString() == team)
                                {
                                    exists = true;
                                    break;
                                }

                            }
                            if (!exists) this.cboTeam.Items.Add(team);
                        }
                    }
                    this.cboTeam.SelectedIndex = 0;
                }

                // Size list
                if (this.cboSize != null)
                {
                    this.cboSize.Items.Clear();
                    this.cboSize.Items.Add("All");
                    int i2;
                    for (i2 = 0; i2 < dt.Rows.Count; i2++)
                    {
                        string size = dt.Rows[i2]["Size"] != DBNull.Value? (dt.Rows[i2]["Size"]?.ToString() ?? ""): "";

                        if (!string.IsNullOrWhiteSpace(size))
                        {
                            bool exists2 = false;
                            foreach (var item in this.cboSize.Items)
                            {
                                string currentSize = item?.ToString() ?? "";
                                if (currentSize == size)
                                {
                                    exists2 = true;
                                    break;
                                }
                            }

                            if (!exists2) this.cboSize.Items.Add(size);
                        }
                    }
                    this.cboSize.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to build filter lists: " + ex.Message);
            }
        }

        private void ApplyFilters()
        {
            try
            {
                if (this.Ds == null || this.Ds.Tables.Count == 0)
                    return;

                DataView dv = new DataView(this.Ds.Tables[0]);
                string filter = "";

               //search
                string s = ""; //Creates variable named "s"
                if (this.txtSearch != null)
                {
                    if (this.txtSearch.Text != null)
                    { 
                        s = this.txtSearch.Text.Trim();
                    }
                    else 
                    {
                        s = " ";
                    }
                }
                else
                {
                    s = "";
                }

                if (!string.IsNullOrEmpty(s))
                {
                    s = s.Replace("'", "''");
                    filter = "(Convert(JerseyID,'System.String') like '%" + s + "%' or Name like '%" + s + "%' or Team like '%" + s + "%' or Size like '%" + s + "%')";
                    //'%" + s + "%' = '%Arsenal%' 
                }

                if (this.cboTeam != null && this.cboTeam.SelectedItem != null)
                {
                    string team = this.cboTeam.SelectedItem?.ToString() ?? string.Empty;//Get the selected team name (ex: "Arsenal")
                    if (team != "All")
                    {
                        if (filter != "") 
                            filter += " AND ";
                        team = team.Replace("'", "''");
                        filter += "Team = '" + team + "'"; //"Team = 'Arsenal'"
                    }
                }

                if (this.cboSize != null && this.cboSize.SelectedItem != null)
                {
                    string size = this.cboSize.SelectedItem?.ToString()?? string.Empty;
                    if (size != "All")
                    {
                        if (filter != "") 
                            filter += " AND ";
                        size = size.Replace("'", "''"); //to avoid team name like 'Queen's Park'
                        filter += "Size = '" + size + "'"; //"Size = 'M'"
                    }
                }

                if (this.cboStockStatus != null && this.cboStockStatus.SelectedItem != null)
                {
                    string status = this.cboStockStatus.SelectedItem?.ToString() ?? string.Empty;
                    //type jersey names, so grid shows only those jerseys.
                    if (status == "In Stock")
                    {
                        if (filter != "") 
                            filter += " AND ";
                        filter += "StockQuantity > 0";
                    }
                    else
                    {
                        if (status == "Low (≤5)")
                        {
                            if (filter != "") 
                                filter += " AND "; //Team = 'Arsenal' and StockQuantity > 0
                            filter += "StockQuantity > 0 AND StockQuantity <= 5";
                        }
                        else
                        {
                            if (status == "Out (0)")
                            {
                                if (filter != "") 
                                    filter += " AND ";
                                filter += "StockQuantity = 0";
                            }
                        }
                    }
                }

                dv.RowFilter = filter;
                this.dgvInventory.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtering failed: " + ex.Message);
            }
        }

        private void RequestRestock()
        {
            try
            {
                if (this.dgvInventory == null || this.dgvInventory.CurrentRow == null)
                {
                    MessageBox.Show("Please select a jersey first.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.empID)) //checks whether current employee ID is empty or missing.
                {
                    MessageBox.Show("Missing EMP ID");
                    return;
                }

                int jerseyId;
                object? id = this.dgvInventory.CurrentRow.Cells["JerseyID"]?.Value;
                //CurrentRow.Cells= row that clicked in the table.

                if (id == null || !int.TryParse(id.ToString(), out jerseyId))
                {
                    MessageBox.Show("Invalid JerseyID in selected row.");
                    return;
                }

                string size = this.dgvInventory.CurrentRow.Cells["Size"]?.Value?.ToString() ?? string.Empty;

                RestockDialog dlg = new RestockDialog(jerseyId, size);
                if (dlg.ShowDialog() != DialogResult.OK) return;

                string sql = "Insert into dbo.StockRequests (JerseyID, Size, RequestedQty, EmpID, Note) VALUES (@JerseyID, @Size, @RequestedQty, @EmpID, @Note)";
                int rows = this.Da.ExecuteDMLQuery(sql,
                    new SqlParameter("@JerseyID", jerseyId),
                    new SqlParameter("@Size", size),
                    new SqlParameter("@RequestedQty", dlg.RequestedQty),
                    new SqlParameter("@EmpID", this.empID),
                    new SqlParameter("@Note", string.Empty));
                if (rows == 1)
                {
                    MessageBox.Show("Restock request done");

                    PopulateGridView();
                    ApplyFilters();
                }
                else
                {
                    MessageBox.Show("Failed to submit restock request.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Restock request failed: " + ex.Message);
            }
        }
        private void GoBack()
        {
            try
            {
                EmployeeDashboard dash = new EmployeeDashboard(this.empID, this.empName);
                this.Hide();
                dash.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Navigation failed: " + ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtSearch != null)
                    this.txtSearch.Clear();
                if (this.cboTeam != null && this.cboTeam.Items.Count > 0) 
                    this.cboTeam.SelectedIndex = 0;
                if (this.cboSize != null && this.cboSize.Items.Count > 0) 
                    this.cboSize.SelectedIndex = 0;
                if (this.cboStockStatus != null && this.cboStockStatus.Items.Count > 0) 
                    this.cboStockStatus.SelectedIndex = 0;

                PopulateGridView();
                Filtering();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh failed: " + ex.Message);
            }
        }

        private void BtnRequestRestock_Click(object sender, EventArgs e)
        {
            RequestRestock();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void cboTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void cboStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
