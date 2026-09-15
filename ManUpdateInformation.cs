using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Windows.Forms;
using WFA_Sample_A;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace login_2
{
    public partial class ManUpdateInformation : Form
    {
        private DataAccess da;
        private string managerID;
        private string managerName;
        private DataTable dt;

        public ManUpdateInformation(String name,string id)
        {
            InitializeComponent();
            this.dt = new DataTable();
            this.da = new DataAccess();
            this.managerID = id;
            this.managerName = name;
            LoadManagerInfo();
        }


        private void LoadManagerInfo()
        {
            try
            {
            string query = "SELECT UserID, UserName, Role, Gmail, PhoneNumber,  Age FROM Users WHERE UserID = @id AND Role = 'Manager'";
            SqlParameter[] parameters = { new SqlParameter("@id", this.managerID) };

            dt = da.ExecuteParameterizedQueryTable(query, parameters);

            if (dt.Rows.Count == 1)
            {
            DataRow row = dt.Rows[0];
            txtUserID.Text = row["UserID"].ToString();
            txtUserName.Text = row["UserName"].ToString();
            txtRole.Text = row["Role"].ToString();
            txtGmail.Text = row["Gmail"].ToString();
            txtPhone.Text = row["PhoneNumber"].ToString();
            txtAge.Text = row["Age"].ToString();
            }
            else
            {
            MessageBox.Show("Manager profile not found.", "Error");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading manager info: " + ex.Message);
            }
        }

        private void ClearProfileFields()
        {
          

        }
       
 
        private void btnResetProfile_Click(object sender, EventArgs e)
        {
            ClearProfileFields();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    MessageBox.Show("Manager ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    MessageBox.Show("Manager name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGmail.Text) || !txtGmail.Text.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Please enter a valid Gmail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string sql = "UPDATE Users " +
                             "SET UserName=@UserName, Gmail=@Gmail, PhoneNumber=@PhoneNumber, " +
                             " Age=@Age " +
                             "WHERE UserID=@UserID AND Role='Manager';";

                
                var parameters = new SqlParameter[]
                {
                new SqlParameter("@UserID", txtUserID.Text.Trim()),
                new SqlParameter("@UserName", txtUserName.Text.Trim()),
                new SqlParameter("@Gmail", txtGmail.Text.Trim()),
                new SqlParameter("@PhoneNumber", txtPhone.Text.Trim()),
          
                new SqlParameter("@Age", string.IsNullOrWhiteSpace(txtAge.Text) ? (object)DBNull.Value : int.Parse(txtAge.Text))
                };

                
                int result = da.ExecuteParameterizedQuery(sql, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Manager information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No changes were made or manager not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Salary and Age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating manager: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(this.managerID))
                {
                    MessageBox.Show("No user context to change password.");
                    return;
                }

                string currentPwdInput = txtCurrentPwd.Text.Trim();
                string newPwd = txtNewPwd.Text.Trim();
                string confirmPwd = txtConfirmPwd.Text.Trim();

                if (string.IsNullOrEmpty(currentPwdInput) || string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(confirmPwd))
                {
                    MessageBox.Show("Please fill all password fields.");
                    return;
                }

                if (newPwd != confirmPwd)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }

                
                string Sql = "SELECT Password FROM Users WHERE UserID = @UserID";
                var Params = new SqlParameter[]
                {
                new SqlParameter("@UserID", this.managerID)
                };

                 dt = da.ExecuteQueryTable(Sql, Params);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User not found in the database.");
                    return;
                }

                string dbCurrentPassword = dt.Rows[0]["Password"]?.ToString() ?? string.Empty;

                if (dbCurrentPassword != currentPwdInput)
                {
                    MessageBox.Show("Current password is incorrect.");
                    return;
                }
                if (dbCurrentPassword == newPwd)
                {
                    MessageBox.Show("New password cannot be the same as the current password.");
                    return;
                }

                string updateSql = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";
                var updateParams = new SqlParameter[]
                {
                      new SqlParameter("@NewPassword", confirmPwd),
                      new SqlParameter("@UserID", this.managerID)
                };

                int result = da.ExecuteParameterizedQuery(updateSql, updateParams);
                if (result == 1)
                {
                    txtCurrentPwd.Clear();
                    txtNewPwd.Clear();
                    txtConfirmPwd.Clear();
                    MessageBox.Show("Password changed successfully.");
                }
                else
                {
                    MessageBox.Show("Password update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message);
            }

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            ManagerDashboard dashboard = new ManagerDashboard(managerName,managerID);
            dashboard.Show();
            this.Hide();
        }
    }
}
