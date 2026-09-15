using System;
using Microsoft.Data.SqlClient;
using System.Data;
using WFA_Sample_A;

namespace AdminDashBoard
{
    public partial class UserManagement : UserControl
    {
        private DataAccess Da { get; set; }
        private string? Sql { get; set; }
        DataTable dt=new DataTable();


        public UserManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
        }
        private void PopulateGridView(string sql = "SELECT * FROM Users;")
        {
            try
            {

                dt = Da.ExecuteQueryTable("SELECT * FROM [dbo].[Users];");
                dgvUserList.DataSource = dt;
                dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "LoadJerseyDbTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearAll()
        {
            this.txtUserID.Clear();
            this.txtUserName.Clear();
            this.txtAge.Clear();
            this.txtEmail.Clear();
            this.txtSalary.Clear();
            this.txtPassword.Clear();
            this.txtPhone.Clear();
            this.cmbRole.SelectedIndex = -1;
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ReadOnly = false;
        }



        private void dgvUserList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow != null)
            {
                try
                {
                    this.txtPassword.Text = dgvUserList.CurrentRow.Cells["Password"].Value?.ToString();
                    this.txtPassword.PasswordChar = '*';
                    this.txtPassword.ReadOnly = true;

                    this.txtUserID.ReadOnly = true;
                    this.txtUserID.Text = dgvUserList.CurrentRow.Cells["UserID"].Value?.ToString();
                    this.txtUserName.Text = dgvUserList.CurrentRow.Cells["UserName"].Value?.ToString();
                    this.txtEmail.Text = dgvUserList.CurrentRow.Cells["Gmail"].Value?.ToString();
                    this.cmbRole.Text = dgvUserList.CurrentRow.Cells["Role"].Value?.ToString();
                    this.txtPhone.Text = dgvUserList.CurrentRow.Cells["PhoneNumber"].Value?.ToString();
                    this.txtAge.Text = dgvUserList.CurrentRow.Cells["Age"].Value?.ToString();
                    this.txtSalary.Text = dgvUserList.CurrentRow.Cells["Salary"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading User details: " + ex.Message);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUserList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string userId = dgvUserList.CurrentRow.Cells["UserID"].Value?.ToString() ?? " ";
                if (string.IsNullOrWhiteSpace(userId))
                {
                    MessageBox.Show("Invalid UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("Are you sure you want to delete user '" + userId + "'?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Users WHERE UserID=@UserID;";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@UserID", userId)
                    };

                    int result = Da.ExecuteParameterizedQuery(sql, parameters);
                    if (result > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            PopulateGridView();
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "SELECT * FROM Users WHERE UserName LIKE '" + this.txtAge.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUserList.CurrentRow == null)
                {
                    MessageBox.Show("Select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "UPDATE Users SET UserName=@UserName, Password=@Password, Age=@Age, Gmail=@Gmail, Salary=@Salary, PhoneNumber=@PhoneNumber, Role=@Role " +
                             "WHERE UserID=@UserID;";

                var parameters = new SqlParameter[]
                {
                new SqlParameter("@UserID", txtUserID.Text),
                new SqlParameter("@UserName", txtUserName.Text),
                new SqlParameter("@Password", txtPassword.Text),
                new SqlParameter("@Age", string.IsNullOrWhiteSpace(txtAge.Text) ? (object)DBNull.Value : int.Parse(txtAge.Text)),
                new SqlParameter("@Gmail", txtEmail.Text),
                new SqlParameter("@Salary", string.IsNullOrWhiteSpace(txtSalary.Text) ? (object)DBNull.Value : decimal.Parse(txtSalary.Text)),
                new SqlParameter("@PhoneNumber", txtPhone.Text),
                new SqlParameter("@Role", cmbRole.Text)
                };

                int result = Da.ExecuteParameterizedQuery(sql, parameters);
                if (result > 0)
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    PopulateGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "INSERT INTO Users (UserID, UserName, Password, Age, Gmail, Salary, PhoneNumber, Role) " +
                             "VALUES (@UserID, @UserName, @Password, @Age, @Gmail, @Salary, @PhoneNumber, @Role);";

                var parameters = new SqlParameter[]
                {
                new SqlParameter("@UserID", txtUserID.Text),
                new SqlParameter("@UserName", txtUserName.Text),
                new SqlParameter("@Password", txtPassword.Text),
                new SqlParameter("@Age", string.IsNullOrWhiteSpace(txtAge.Text) ? (object)DBNull.Value : int.Parse(txtAge.Text)),
                new SqlParameter("@Gmail", txtEmail.Text),
                new SqlParameter("@Salary", string.IsNullOrWhiteSpace(txtSalary.Text) ? (object)DBNull.Value : decimal.Parse(txtSalary.Text)),
                new SqlParameter("@PhoneNumber", txtPhone.Text),
                new SqlParameter("@Role", cmbRole.Text)
                };

                int result = Da.ExecuteParameterizedQuery(sql, parameters);
                if (result > 0)
                {
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    PopulateGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);

            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
