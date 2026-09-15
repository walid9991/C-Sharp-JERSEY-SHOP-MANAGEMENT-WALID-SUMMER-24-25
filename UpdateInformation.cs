using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WFA_Sample_A;

namespace login_2
{
    public partial class UpdateInformation : Form
    {
        private DataAccess Da { get; set; } = new DataAccess();
        private DataSet Ds { get; set; } = new DataSet();
        private string Sql { get; set; } = string.Empty;

        public string empID = " ";
        public string empName = " ";

        public UpdateInformation()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                InitializeUiState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        public UpdateInformation(string empId, string empName)
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                if (empId != null)
                 {
                    this.empID = empId;
                 }
                else
                  {
                    this.empID = "";
                  }

                if (empName != null)
                 {
                    this.empName = empName;
                 }
                else
                  { 
                    this.empName = ""; 
                  }

                InitializeUiState();
                PopulateProfile();
                PopulateRecentSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void InitializeUiState()
        {
            try
            {
                if (this.dgvRecentSales != null)
                {
                    this.dgvRecentSales.ReadOnly = true;
                    this.dgvRecentSales.AllowUserToAddRows = false;
                    this.dgvRecentSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.dgvRecentSales.AutoGenerateColumns = true;
                }

                if (this.lblStatus != null)
                    this.lblStatus.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing UI: " + ex.Message);
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

        private void PopulateProfile()
        {
            try
            {
                if (string.IsNullOrEmpty(this.empID))
                    return;

                this.Sql = "Select * from Users where UserID = '" + this.empID + "'";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];

                    if (row["UserID"] != null)
                       {
                          this.txtUserID.Text = row["UserID"].ToString();
                       }
                      else
                         {
                          this.txtUserID.Text = "";
                         }

                    if (row["Role"] != null)
                       {
                           this.txtRole.Text = row["Role"].ToString();
                       }
                      else
                         {
                            this.txtRole.Text = "";
                         }
                    if (row["UserName"] != null)
                      {
                          this.txtUserName.Text = row["UserName"].ToString();
                      }
                      else
                          {
                              this.txtUserName.Text = "";
                          }

                       if (row["Gmail"] != null)
                          {
                             this.txtGmail.Text = row["Gmail"].ToString();
                           }
                         else
                            {
                                this.txtGmail.Text = "";
                            }

                       if (row["PhoneNumber"] != null)
                          {
                              this.txtPhone.Text = row["PhoneNumber"].ToString();
                          }
                      else
                        {
                            this.txtPhone.Text = "";
                        }
 
                      if (row["Age"] != null)
                       {
                          this.txtAge.Text = row["Age"].ToString();
                       }
                        else
                           {
                        this.txtAge.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Profile not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Profile: " + ex.Message);
            }
        }

        private void PopulateRecentSales()
        {
            try
            {
                if (string.IsNullOrEmpty(this.empID)) 
                    return;

                this.Sql = "Select top 10 s.[Sell ID] as SaleID, si.[Product ID] as ProductID, si.[Quantity] as Quantity, si.[Price] as Price, si.[Purchase Date] as PurchaseDate from [Emp Sell Stats] s JOIN [Sell Info] si on si.[Sale ID] = s.[Sell ID] where s.EmpID = '" + this.empID + "' ORDER BY si.[Purchase Date] DESC";

                this.Ds = this.Da.ExecuteQuery(this.Sql);
                this.dgvRecentSales.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in recent sales: " + ex.Message);
            }
        }

        private bool ValidateProfileInputs()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtGmail.Text))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string gmail = txtGmail.Text.Trim();
                if (!gmail.ToLower().EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Enter a valid email address.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!string.IsNullOrEmpty(txtAge.Text))
                {
                    if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 0)
                    {
                        MessageBox.Show("Enter a valid age.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ClearProfileFields()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.empID))
                {
                    PopulateProfile();
                }
                else
                {
                    this.txtUserName.Clear();
                    this.txtGmail.Clear();
                    this.txtPhone.Clear();
                    this.txtAge.Clear();
                }

                if (this.lblStatus != null)
                { 
                    this.lblStatus.Text = ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in clearing fields: " + ex.Message);
            }
        }

        private void SaveProfile()
        {
            try
            {
                if (string.IsNullOrEmpty(this.empID))
                {
                    MessageBox.Show("No user context to update.");
                    return;
                }

                if (!ValidateProfileInputs()) return;

                string name = txtUserName.Text.Trim();
                string gmail = txtGmail.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string ageValue = string.IsNullOrWhiteSpace(txtAge.Text) ? "NULL" : txtAge.Text.Trim();

                this.Sql = "Update Users set UserName = '" + name + "', Gmail = '" + gmail + "', PhoneNumber = '" + phone + "', Age = " + ageValue + " WHERE UserID = '" + this.empID + "'";
                int count = ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    if (this.lblStatus != null) this.lblStatus.Text = "Profile updated.";
                    MessageBox.Show("Profile updated.");
                    PopulateProfile();
                }
                else
                {
                    MessageBox.Show("No changes were saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void ChangePassword()
        {
            try
            {
                if (string.IsNullOrEmpty(this.empID))
                {
                    MessageBox.Show("No user context to change password.");
                    return;
                }

                string current;
                if (txtCurrentPwd.Text != null)
                    current = txtCurrentPwd.Text;
                else
                    current = "";

                string newPwd;
                if (txtNewPwd.Text != null)
                    newPwd = txtNewPwd.Text;
                else
                    newPwd = "";

                string confirm;
                if (txtConfirmPwd.Text != null)
                    confirm = txtConfirmPwd.Text;
                else
                    confirm = "";

                if (string.IsNullOrEmpty(current) || string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(confirm))
                {
                    MessageBox.Show("Please fill all password fields.");
                    return;
                }

                if (newPwd != confirm)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }

                this.Sql = "Select Password from Users where UserID = '" + this.empID + "'";
                object dbPassObj = this.Da.ExecuteScalar(this.Sql);
                
                string? dbPass;
                if (dbPassObj != null)
                {
                    dbPass = dbPassObj.ToString() ?? string.Empty;
                }
                else
                {
                    dbPass = null;
                }


                if (dbPass == null || dbPass != current)
                {
                    MessageBox.Show("Current password is incorrect.");
                    return;
                }

                this.Sql = "Update Users set Password = '" + newPwd + "' where UserID = '" + this.empID + "'";
                int count = ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    txtCurrentPwd.Clear();
                    txtNewPwd.Clear();
                    txtConfirmPwd.Clear();

                    if (this.lblStatus != null)
                    { 
                        this.lblStatus.Text = "Password changed."; 
                    }
                    MessageBox.Show("Password changed.");
                }
                else
                {
                    MessageBox.Show("Password change failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message);
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
                MessageBox.Show("Error navigating back: " + ex.Message);
            }
        }

        private void btnResetProfile_Click(object sender, EventArgs e)
        {
            ClearProfileFields();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
