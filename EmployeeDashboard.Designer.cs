namespace login_2
{
    partial class EmployeeDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            panelHeader = new Panel();
            TitleLabel = new Label();
            Logoutbtn = new Button();
            LeftPanel = new Panel();
            pictureBox1 = new PictureBox();
            UpInformationButton = new Button();
            btnManageProducts = new Button();
            SellButton = new Button();
            pictureBox2 = new PictureBox();
            EmpInfoName = new Label();
            EmpID = new Label();
            txtEmpname = new TextBox();
            txtempID = new TextBox();
            lblwelcome = new Label();
            panelHeader.SuspendLayout();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaGreen;
            panelHeader.Controls.Add(TitleLabel);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 60);
            panelHeader.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.SkyBlue;
            TitleLabel.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(12, 13);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(378, 27);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Employee Dashboard - Jersey Shop";
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.SkyBlue;
            Logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.Location = new Point(1070, 12);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(100, 35);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SeaGreen;
            LeftPanel.Controls.Add(pictureBox1);
            LeftPanel.Controls.Add(UpInformationButton);
            LeftPanel.Controls.Add(btnManageProducts);
            LeftPanel.Controls.Add(SellButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 60);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(267, 640);
            LeftPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 216);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UpInformationButton
            // 
            UpInformationButton.BackColor = Color.SkyBlue;
            UpInformationButton.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpInformationButton.Image = (Image)resources.GetObject("UpInformationButton.Image");
            UpInformationButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpInformationButton.Location = new Point(12, 436);
            UpInformationButton.Name = "UpInformationButton";
            UpInformationButton.Size = new Size(237, 72);
            UpInformationButton.TabIndex = 3;
            UpInformationButton.Text = "Update Information";
            UpInformationButton.TextAlign = ContentAlignment.MiddleRight;
            UpInformationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpInformationButton.UseVisualStyleBackColor = false;
            UpInformationButton.Click += UpdateInformation_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackColor = Color.SkyBlue;
            btnManageProducts.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProducts.Image = (Image)resources.GetObject("btnManageProducts.Image");
            btnManageProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageProducts.Location = new Point(12, 329);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(237, 72);
            btnManageProducts.TabIndex = 1;
            btnManageProducts.Text = "Manage Inventory";
            btnManageProducts.TextAlign = ContentAlignment.MiddleRight;
            btnManageProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageProducts.UseVisualStyleBackColor = false;
            btnManageProducts.Click += ManageProducts_Click;
            // 
            // SellButton
            // 
            SellButton.BackColor = Color.SkyBlue;
            SellButton.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellButton.Image = (Image)resources.GetObject("SellButton.Image");
            SellButton.ImageAlign = ContentAlignment.MiddleLeft;
            SellButton.Location = new Point(12, 222);
            SellButton.Name = "SellButton";
            SellButton.Size = new Size(237, 72);
            SellButton.TabIndex = 0;
            SellButton.Text = " Sell products";
            SellButton.TextAlign = ContentAlignment.MiddleRight;
            SellButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SellButton.UseVisualStyleBackColor = false;
            SellButton.Click += SellButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(542, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 246);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // EmpInfoName
            // 
            EmpInfoName.BackColor = Color.Transparent;
            EmpInfoName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpInfoName.Location = new Point(467, 389);
            EmpInfoName.Name = "EmpInfoName";
            EmpInfoName.Size = new Size(192, 25);
            EmpInfoName.TabIndex = 4;
            EmpInfoName.Text = "Employee Name:";
            // 
            // EmpID
            // 
            EmpID.BackColor = Color.Transparent;
            EmpID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpID.Location = new Point(467, 452);
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(192, 25);
            EmpID.TabIndex = 5;
            EmpID.Text = "Employee ID:";
            // 
            // txtEmpname
            // 
            txtEmpname.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmpname.Location = new Point(645, 389);
            txtEmpname.Multiline = true;
            txtEmpname.Name = "txtEmpname";
            txtEmpname.ReadOnly = true;
            txtEmpname.Size = new Size(302, 34);
            txtEmpname.TabIndex = 6;
            // 
            // txtempID
            // 
            txtempID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtempID.Location = new Point(645, 452);
            txtempID.Multiline = true;
            txtempID.Name = "txtempID";
            txtempID.ReadOnly = true;
            txtempID.Size = new Size(302, 34);
            txtempID.TabIndex = 7;
            // 
            // lblwelcome
            // 
            lblwelcome.BackColor = Color.Transparent;
            lblwelcome.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(542, 326);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(277, 37);
            lblwelcome.TabIndex = 8;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 700);
            Controls.Add(lblwelcome);
            Controls.Add(txtempID);
            Controls.Add(txtEmpname);
            Controls.Add(EmpID);
            Controls.Add(EmpInfoName);
            Controls.Add(pictureBox2);
            Controls.Add(LeftPanel);
            Controls.Add(Logoutbtn);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label TitleLabel;
        private Button Logoutbtn;
        private Panel LeftPanel;
        private Button SellButton;
        private Button UpInformationButton;
        private Button btnManageProducts;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label EmpInfoName;
        private Label EmpID;
        private TextBox txtEmpname;
        private TextBox txtempID;
        private Label lblwelcome;
    }
}
