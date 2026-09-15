namespace login_2
{
    partial class ManUpdateInformation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            grpProfile = new GroupBox();
            btnResetProfile = new Button();
            btnSaveProfile = new Button();
            txtAge = new TextBox();
            lblAge = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtGmail = new TextBox();
            lblGmail = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtRole = new TextBox();
            lblRole = new Label();
            txtUserID = new TextBox();
            lblUserID = new Label();
            lblStatus = new Label();
            grpPassword = new GroupBox();
            btnBack = new Button();
            btnChangePassword = new Button();
            txtConfirmPwd = new TextBox();
            lblConfirmPwd = new Label();
            txtNewPwd = new TextBox();
            lblNewPwd = new Label();
            txtCurrentPwd = new TextBox();
            lblCurrentPwd = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpProfile.SuspendLayout();
            grpPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(55, 85, 64);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-2, -1);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1049, 79);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(78, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update My Information";
            // 
            // grpProfile
            // 
            grpProfile.Controls.Add(btnResetProfile);
            grpProfile.Controls.Add(btnSaveProfile);
            grpProfile.Controls.Add(txtAge);
            grpProfile.Controls.Add(lblAge);
            grpProfile.Controls.Add(txtPhone);
            grpProfile.Controls.Add(lblPhone);
            grpProfile.Controls.Add(txtGmail);
            grpProfile.Controls.Add(lblGmail);
            grpProfile.Controls.Add(txtUserName);
            grpProfile.Controls.Add(lblUserName);
            grpProfile.Controls.Add(txtRole);
            grpProfile.Controls.Add(lblRole);
            grpProfile.Controls.Add(txtUserID);
            grpProfile.Controls.Add(lblUserID);
            grpProfile.Font = new Font("Cambria", 12.75F, FontStyle.Bold);
            grpProfile.ForeColor = Color.FromArgb(55, 85, 64);
            grpProfile.Location = new Point(14, 117);
            grpProfile.Margin = new Padding(3, 4, 3, 4);
            grpProfile.Name = "grpProfile";
            grpProfile.Padding = new Padding(3, 4, 3, 4);
            grpProfile.Size = new Size(461, 587);
            grpProfile.TabIndex = 1;
            grpProfile.TabStop = false;
            grpProfile.Text = "Profile";
            // 
            // btnResetProfile
            // 
            btnResetProfile.BackColor = Color.FromArgb(55, 85, 64);
            btnResetProfile.FlatAppearance.BorderSize = 0;
            btnResetProfile.FlatStyle = FlatStyle.Flat;
            btnResetProfile.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            btnResetProfile.ForeColor = SystemColors.ControlLightLight;
            btnResetProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetProfile.Location = new Point(183, 470);
            btnResetProfile.Margin = new Padding(3, 4, 3, 4);
            btnResetProfile.Name = "btnResetProfile";
            btnResetProfile.Size = new Size(96, 53);
            btnResetProfile.TabIndex = 13;
            btnResetProfile.Text = "Reset";
            btnResetProfile.UseVisualStyleBackColor = false;
            btnResetProfile.Click += btnResetProfile_Click;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.FromArgb(55, 85, 64);
            btnSaveProfile.FlatAppearance.BorderSize = 0;
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            btnSaveProfile.ForeColor = SystemColors.ControlLightLight;
            btnSaveProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveProfile.Location = new Point(29, 470);
            btnSaveProfile.Margin = new Padding(3, 4, 3, 4);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(96, 55);
            btnSaveProfile.TabIndex = 12;
            btnSaveProfile.Text = "Save";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(126, 403);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(153, 27);
            txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblAge.Location = new Point(29, 416);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(42, 22);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(126, 343);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(153, 27);
            txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblPhone.Location = new Point(29, 349);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 22);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(126, 275);
            txtGmail.Margin = new Padding(3, 4, 3, 4);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(222, 27);
            txtGmail.TabIndex = 7;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblGmail.Location = new Point(29, 281);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(61, 22);
            lblGmail.TabIndex = 6;
            lblGmail.Text = "Gmail";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(126, 207);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(222, 27);
            txtUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblUserName.Location = new Point(29, 213);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(60, 22);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Name";
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(126, 140);
            txtRole.Margin = new Padding(3, 4, 3, 4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(222, 27);
            txtRole.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblRole.Location = new Point(29, 153);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 22);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(126, 75);
            txtUserID.Margin = new Padding(3, 4, 3, 4);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(222, 27);
            txtUserID.TabIndex = 1;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblUserID.Location = new Point(29, 88);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(75, 22);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(178, 1000);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 22);
            lblStatus.TabIndex = 14;
            // 
            // grpPassword
            // 
            grpPassword.Controls.Add(btnBack);
            grpPassword.Controls.Add(btnChangePassword);
            grpPassword.Controls.Add(txtConfirmPwd);
            grpPassword.Controls.Add(lblConfirmPwd);
            grpPassword.Controls.Add(txtNewPwd);
            grpPassword.Controls.Add(lblNewPwd);
            grpPassword.Controls.Add(txtCurrentPwd);
            grpPassword.Controls.Add(lblCurrentPwd);
            grpPassword.Font = new Font("Cambria", 12.75F, FontStyle.Bold);
            grpPassword.ForeColor = Color.FromArgb(55, 85, 64);
            grpPassword.Location = new Point(529, 117);
            grpPassword.Margin = new Padding(3, 4, 3, 4);
            grpPassword.Name = "grpPassword";
            grpPassword.Padding = new Padding(3, 4, 3, 4);
            grpPassword.Size = new Size(424, 503);
            grpPassword.TabIndex = 2;
            grpPassword.TabStop = false;
            grpPassword.Text = "Change Password";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(55, 85, 64);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(310, 450);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 51);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(55, 85, 64);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            btnChangePassword.ForeColor = SystemColors.ControlLightLight;
            btnChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.Location = new Point(25, 314);
            btnChangePassword.Margin = new Padding(3, 4, 3, 4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(189, 57);
            btnChangePassword.TabIndex = 14;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmPwd.Location = new Point(117, 243);
            txtConfirmPwd.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(156, 27);
            txtConfirmPwd.TabIndex = 8;
            txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // lblConfirmPwd
            // 
            lblConfirmPwd.AutoSize = true;
            lblConfirmPwd.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblConfirmPwd.Location = new Point(25, 249);
            lblConfirmPwd.Name = "lblConfirmPwd";
            lblConfirmPwd.Size = new Size(81, 22);
            lblConfirmPwd.TabIndex = 7;
            lblConfirmPwd.Text = "Confirm";
            // 
            // txtNewPwd
            // 
            txtNewPwd.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPwd.Location = new Point(117, 168);
            txtNewPwd.Margin = new Padding(3, 4, 3, 4);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(156, 27);
            txtNewPwd.TabIndex = 6;
            txtNewPwd.UseSystemPasswordChar = true;
            // 
            // lblNewPwd
            // 
            lblNewPwd.AutoSize = true;
            lblNewPwd.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblNewPwd.Location = new Point(25, 175);
            lblNewPwd.Name = "lblNewPwd";
            lblNewPwd.Size = new Size(48, 22);
            lblNewPwd.TabIndex = 5;
            lblNewPwd.Text = "New";
            // 
            // txtCurrentPwd
            // 
            txtCurrentPwd.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrentPwd.Location = new Point(117, 88);
            txtCurrentPwd.Margin = new Padding(3, 4, 3, 4);
            txtCurrentPwd.Name = "txtCurrentPwd";
            txtCurrentPwd.Size = new Size(156, 27);
            txtCurrentPwd.TabIndex = 4;
            txtCurrentPwd.UseSystemPasswordChar = true;
            // 
            // lblCurrentPwd
            // 
            lblCurrentPwd.AutoSize = true;
            lblCurrentPwd.Font = new Font("Cambria", 11.25F, FontStyle.Bold);
            lblCurrentPwd.Location = new Point(25, 95);
            lblCurrentPwd.Name = "lblCurrentPwd";
            lblCurrentPwd.Size = new Size(78, 22);
            lblCurrentPwd.TabIndex = 3;
            lblCurrentPwd.Text = "Current";
            // 
            // UpdateInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1046, 704);
            Controls.Add(lblStatus);
            Controls.Add(grpPassword);
            Controls.Add(grpProfile);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateInformation";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpProfile.ResumeLayout(false);
            grpProfile.PerformLayout();
            grpPassword.ResumeLayout(false);
            grpPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnResetProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtCurrentPwd;
        private System.Windows.Forms.Label lblCurrentPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
