using AdminDashBoard;
using System.Data;
using WFA_Sample_A;

namespace login_2
{
    public partial class LoginPage : Form
    {
        DataTable dt=new DataTable();
        DataTable namedt=new DataTable();
        DataAccess da = new DataAccess();



        public LoginPage()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string UserID = txtuserID.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your Id and password. ");
                return;
            }

            try
            {
                string query = "select Password from Users where UserID = '" + UserID + "'";
                dt = da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    string dbpassword = dt.Rows[0]["Password"]?.ToString()??" ";
                    if (dbpassword == password)
                    {
                        string First3Letter = UserID.Substring(0, 3).ToUpper();

                        if (First3Letter == "EMP")
                        {
                            string nameQuery = "SELECT UserName FROM Users WHERE UserID = '" + UserID + "'";
                            namedt = da.ExecuteQueryTable(nameQuery);

                            string empName = namedt.Rows[0]["UserName"]?.ToString()?? " ";

                            EmployeeDashboard empLogin = new EmployeeDashboard(UserID, empName);
                            empLogin.Show();
                            this.Hide();
                        }
                        else if (First3Letter == "ADM")
                        {
                            //string nameQuery = "SELECT UserName FROM Users WHERE UserID = '" + UserID + "'";
                            //namedt = da.ExecuteQueryTable(nameQuery);

                            //string adminName = namedt.Rows[0]["UserName"]?.ToString() ?? " ";

                            Admin adminLogin = new Admin();
                            adminLogin.Show();
                            this.Hide();
                        }
                        else if (First3Letter == "MAN")
                        {
                            string nameQuery = "SELECT UserName FROM Users WHERE UserID = '" + UserID + "'";
                            namedt = da.ExecuteQueryTable(nameQuery);

                            string manName = namedt.Rows[0]["UserName"]?.ToString() ?? " ";

                            ManagerDashboard ManLogin = new ManagerDashboard(UserID, manName);
                            ManLogin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid role in User ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                }
                else
                {
                    MessageBox.Show("User ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpass.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }

        }
    }
}
