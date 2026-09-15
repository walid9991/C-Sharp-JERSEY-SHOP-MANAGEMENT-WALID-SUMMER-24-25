namespace login_2
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            lblTitle = new Label();
            lblWelcome = new Label();
            lblMgrName = new Label();
            lblMgrID = new Label();
            txtManagerName = new TextBox();
            txtManagerID = new TextBox();
            btnReviewRestock = new Button();
            btnStockManagement = new Button();
            btnProfileOverview = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(55, 85, 64);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-4, -1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1018, 70);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(911, 19);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 33);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(90, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manager Dashboard - Jersey Shop";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ActiveCaptionText;
            lblWelcome.Location = new Point(441, 221);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(268, 23);
            lblWelcome.TabIndex = 3;
            // 
            // lblMgrName
            // 
            lblMgrName.AutoSize = true;
            lblMgrName.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMgrName.ForeColor = SystemColors.ActiveCaptionText;
            lblMgrName.Location = new Point(404, 291);
            lblMgrName.Name = "lblMgrName";
            lblMgrName.Size = new Size(106, 15);
            lblMgrName.TabIndex = 4;
            lblMgrName.Text = "Manager Name";
            // 
            // lblMgrID
            // 
            lblMgrID.AutoSize = true;
            lblMgrID.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMgrID.ForeColor = SystemColors.ActiveCaptionText;
            lblMgrID.Location = new Point(404, 341);
            lblMgrID.Name = "lblMgrID";
            lblMgrID.Size = new Size(83, 15);
            lblMgrID.TabIndex = 5;
            lblMgrID.Text = "Manager ID";
            // 
            // txtManagerName
            // 
            txtManagerName.Location = new Point(516, 291);
            txtManagerName.Name = "txtManagerName";
            txtManagerName.ReadOnly = true;
            txtManagerName.Size = new Size(140, 23);
            txtManagerName.TabIndex = 6;
            txtManagerName.TextChanged += txtManagerName_TextChanged;
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(516, 338);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.ReadOnly = true;
            txtManagerID.Size = new Size(140, 23);
            txtManagerID.TabIndex = 7;
            txtManagerID.TextChanged += txtManagerID_TextChanged;
            // 
            // btnReviewRestock
            // 
            btnReviewRestock.BackColor = Color.FromArgb(55, 85, 64);
            btnReviewRestock.FlatStyle = FlatStyle.Flat;
            btnReviewRestock.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReviewRestock.ForeColor = SystemColors.ControlLightLight;
            btnReviewRestock.Location = new Point(86, 339);
            btnReviewRestock.Name = "btnReviewRestock";
            btnReviewRestock.Size = new Size(97, 58);
            btnReviewRestock.TabIndex = 2;
            btnReviewRestock.Text = "Review Restock";
            btnReviewRestock.UseVisualStyleBackColor = false;
            btnReviewRestock.Click += btnReviewRestock_Click;
            // 
            // btnStockManagement
            // 
            btnStockManagement.BackColor = Color.FromArgb(55, 85, 64);
            btnStockManagement.FlatStyle = FlatStyle.Flat;
            btnStockManagement.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockManagement.ForeColor = SystemColors.ControlLightLight;
            btnStockManagement.Location = new Point(86, 249);
            btnStockManagement.Name = "btnStockManagement";
            btnStockManagement.Size = new Size(97, 58);
            btnStockManagement.TabIndex = 3;
            btnStockManagement.Text = "Stock Management";
            btnStockManagement.UseVisualStyleBackColor = false;
            btnStockManagement.Click += btnStockManagement_Click;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.BackColor = Color.FromArgb(55, 85, 64);
            btnProfileOverview.FlatStyle = FlatStyle.Flat;
            btnProfileOverview.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfileOverview.ForeColor = SystemColors.ControlLightLight;
            btnProfileOverview.Location = new Point(86, 170);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(97, 54);
            btnProfileOverview.TabIndex = 4;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = false;
            btnProfileOverview.Click += btnProfileOverview_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 85, 64);
            panel1.Location = new Point(24, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 263);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(472, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1011, 499);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btnReviewRestock);
            Controls.Add(btnStockManagement);
            Controls.Add(btnProfileOverview);
            Controls.Add(txtManagerID);
            Controls.Add(txtManagerName);
            Controls.Add(lblMgrID);
            Controls.Add(lblMgrName);
            Controls.Add(lblWelcome);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManagerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnLogout;
        private Label lblWelcome;
        private Label lblMgrName;
        private Label lblMgrID;
        private TextBox txtManagerName;
        private TextBox txtManagerID;
        private Button btnReviewRestock;
        private Button btnStockManagement;
        private Button btnProfileOverview;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}