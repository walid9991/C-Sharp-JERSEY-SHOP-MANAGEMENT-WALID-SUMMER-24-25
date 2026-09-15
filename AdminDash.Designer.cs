namespace AdminDashBoard
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pnlAdminSidebar = new Panel();
            btnLOGOUT = new Button();
            lblJERSEYCHAI = new Label();
            btnReports = new Button();
            lblAdmin = new Label();
            btnProductManagement = new Button();
            btnUserManagement = new Button();
            pnlAdminContainer = new Panel();
            pnlAdminSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminSidebar
            // 
            pnlAdminSidebar.BackColor = Color.SeaGreen;
            pnlAdminSidebar.Controls.Add(btnLOGOUT);
            pnlAdminSidebar.Controls.Add(lblJERSEYCHAI);
            pnlAdminSidebar.Controls.Add(btnReports);
            pnlAdminSidebar.Controls.Add(lblAdmin);
            pnlAdminSidebar.Controls.Add(btnProductManagement);
            pnlAdminSidebar.Controls.Add(btnUserManagement);
            pnlAdminSidebar.Dock = DockStyle.Left;
            pnlAdminSidebar.Location = new Point(0, 0);
            pnlAdminSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlAdminSidebar.Name = "pnlAdminSidebar";
            pnlAdminSidebar.Size = new Size(288, 663);
            pnlAdminSidebar.TabIndex = 0;
            // 
            // btnLOGOUT
            // 
            btnLOGOUT.BackColor = Color.SteelBlue;
            btnLOGOUT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLOGOUT.Image = (Image)resources.GetObject("btnLOGOUT.Image");
            btnLOGOUT.ImageAlign = ContentAlignment.MiddleLeft;
            btnLOGOUT.Location = new Point(12, 512);
            btnLOGOUT.Margin = new Padding(3, 4, 3, 4);
            btnLOGOUT.Name = "btnLOGOUT";
            btnLOGOUT.Size = new Size(259, 69);
            btnLOGOUT.TabIndex = 5;
            btnLOGOUT.Text = "LOG OUT";
            btnLOGOUT.UseVisualStyleBackColor = false;
            btnLOGOUT.Click += btnLOGOUT_Click;
            // 
            // lblJERSEYCHAI
            // 
            lblJERSEYCHAI.AutoSize = true;
            lblJERSEYCHAI.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJERSEYCHAI.Location = new Point(28, 0);
            lblJERSEYCHAI.Name = "lblJERSEYCHAI";
            lblJERSEYCHAI.Size = new Size(219, 41);
            lblJERSEYCHAI.TabIndex = 0;
            lblJERSEYCHAI.Text = "JERSEY - CHAI";
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.SteelBlue;
            btnReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(12, 404);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(259, 69);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(95, 51);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(64, 23);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "Admin";
            // 
            // btnProductManagement
            // 
            btnProductManagement.BackColor = Color.SteelBlue;
            btnProductManagement.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductManagement.Image = (Image)resources.GetObject("btnProductManagement.Image");
            btnProductManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductManagement.Location = new Point(12, 306);
            btnProductManagement.Margin = new Padding(3, 4, 3, 4);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(259, 69);
            btnProductManagement.TabIndex = 3;
            btnProductManagement.Text = "      Product Management";
            btnProductManagement.UseVisualStyleBackColor = false;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.SteelBlue;
            btnUserManagement.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.Image = (Image)resources.GetObject("btnUserManagement.Image");
            btnUserManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.Location = new Point(12, 200);
            btnUserManagement.Margin = new Padding(3, 4, 3, 4);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(259, 69);
            btnUserManagement.TabIndex = 2;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // pnlAdminContainer
            // 
            pnlAdminContainer.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAdminContainer.Dock = DockStyle.Fill;
            pnlAdminContainer.Location = new Point(288, 0);
            pnlAdminContainer.Margin = new Padding(3, 4, 3, 4);
            pnlAdminContainer.Name = "pnlAdminContainer";
            pnlAdminContainer.Size = new Size(1124, 663);
            pnlAdminContainer.TabIndex = 1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 663);
            Controls.Add(pnlAdminContainer);
            Controls.Add(pnlAdminSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            pnlAdminSidebar.ResumeLayout(false);
            pnlAdminSidebar.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminSidebar;
        private System.Windows.Forms.Panel pnlAdminContainer;
        private System.Windows.Forms.Button btnLOGOUT;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblJERSEYCHAI;
    }
}

