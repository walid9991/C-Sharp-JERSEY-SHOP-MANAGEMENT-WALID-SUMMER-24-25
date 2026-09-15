namespace AdminDashBoard
{
    partial class UserManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblUserManagement = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            dgvUserList = new DataGridView();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnShowAllUsers = new Button();
            lblEmail = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            lblFullName = new Label();
            btnClear = new Button();
            txtAge = new TextBox();
            lblSearch = new Label();
            lblsalary = new Label();
            txtSalary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // lblUserManagement
            // 
            lblUserManagement.AutoSize = true;
            lblUserManagement.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserManagement.Location = new Point(345, 0);
            lblUserManagement.Name = "lblUserManagement";
            lblUserManagement.Size = new Size(276, 41);
            lblUserManagement.TabIndex = 0;
            lblUserManagement.Text = "User Management";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(467, 111);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(68, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "User ID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(467, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(40, 321);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(45, 23);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(628, 108);
            txtUserID.Margin = new Padding(3, 4, 3, 4);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(187, 30);
            txtUserID.TabIndex = 4;
            txtUserID.TextChanged += txtUserID_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(628, 184);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 30);
            txtPassword.TabIndex = 5;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "ADMIN", "MANAGER", "EMPLOYEE" });
            cmbRole.Location = new Point(155, 313);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(187, 31);
            cmbRole.TabIndex = 6;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // dgvUserList
            // 
            dgvUserList.AllowUserToAddRows = false;
            dgvUserList.AllowUserToDeleteRows = false;
            dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(3, 373);
            dgvUserList.Margin = new Padding(3, 4, 3, 4);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.ReadOnly = true;
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.RowTemplate.Height = 24;
            dgvUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserList.Size = new Size(1133, 333);
            dgvUserList.TabIndex = 7;
            dgvUserList.DoubleClick += dgvUserList_DoubleClick;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(937, 174);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(176, 42);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Update User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.Location = new Point(937, 242);
            btnDeleteUser.Margin = new Padding(3, 4, 3, 4);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(176, 42);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnShowAllUsers
            // 
            btnShowAllUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllUsers.Location = new Point(937, 101);
            btnShowAllUsers.Margin = new Padding(3, 4, 3, 4);
            btnShowAllUsers.Name = "btnShowAllUsers";
            btnShowAllUsers.Size = new Size(176, 42);
            btnShowAllUsers.TabIndex = 10;
            btnShowAllUsers.Text = "Add User";
            btnShowAllUsers.UseVisualStyleBackColor = true;
            btnShowAllUsers.Click += btnAddUsers_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(40, 184);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(40, 256);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 23);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(155, 256);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(187, 30);
            txtPhone.TabIndex = 14;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(155, 111);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(187, 30);
            txtUserName.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(155, 184);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 30);
            txtEmail.TabIndex = 16;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(40, 111);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(97, 23);
            lblFullName.TabIndex = 17;
            lblFullName.Text = "User Name";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(937, 302);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 42);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(628, 249);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(187, 30);
            txtAge.TabIndex = 20;
            txtAge.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(472, 256);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 23);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Age";
            // 
            // lblsalary
            // 
            lblsalary.AutoSize = true;
            lblsalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsalary.Location = new Point(467, 316);
            lblsalary.Name = "lblsalary";
            lblsalary.Size = new Size(60, 23);
            lblsalary.TabIndex = 21;
            lblsalary.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(628, 313);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(187, 30);
            txtSalary.TabIndex = 22;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkCyan;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtSalary);
            Controls.Add(lblsalary);
            Controls.Add(btnClear);
            Controls.Add(btnShowAllUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(txtAge);
            Controls.Add(lblSearch);
            Controls.Add(lblFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(dgvUserList);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblUserManagement);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserManagement";
            Size = new Size(1139, 710);
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserManagement;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblSearch;
        private Label lblsalary;
        private TextBox txtSalary;
    }
}
