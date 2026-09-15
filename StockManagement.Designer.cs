namespace login_2
{
    partial class StockManagement
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
            btnBack = new Button();
            lblTitle = new Label();
            grpEntry = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbSize = new ComboBox();
            txtStockQty = new TextBox();
            txtPrice = new TextBox();
            txtTeam = new TextBox();
            txtName = new TextBox();
            txtJerseyID = new TextBox();
            lblStockQty = new Label();
            lblPrice = new Label();
            lblSize = new Label();
            lblTeam = new Label();
            lblName = new Label();
            lblJerseyID = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvJersey = new DataGridView();
            label1 = new Label();
            panelHeader.SuspendLayout();
            grpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJersey).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(55, 85, 64);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-5, -1);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1251, 97);
            panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(55, 85, 64);
            btnBack.Location = new Point(1128, 33);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 47);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(106, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Management";
            // 
            // grpEntry
            // 
            grpEntry.Controls.Add(btnClear);
            grpEntry.Controls.Add(btnDelete);
            grpEntry.Controls.Add(btnUpdate);
            grpEntry.Controls.Add(btnAdd);
            grpEntry.Controls.Add(cmbSize);
            grpEntry.Controls.Add(txtStockQty);
            grpEntry.Controls.Add(txtPrice);
            grpEntry.Controls.Add(txtTeam);
            grpEntry.Controls.Add(txtName);
            grpEntry.Controls.Add(txtJerseyID);
            grpEntry.Controls.Add(lblStockQty);
            grpEntry.Controls.Add(lblPrice);
            grpEntry.Controls.Add(lblSize);
            grpEntry.Controls.Add(lblTeam);
            grpEntry.Controls.Add(lblName);
            grpEntry.Controls.Add(lblJerseyID);
            grpEntry.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEntry.ForeColor = Color.FromArgb(55, 85, 64);
            grpEntry.Location = new Point(14, 104);
            grpEntry.Margin = new Padding(3, 4, 3, 4);
            grpEntry.Name = "grpEntry";
            grpEntry.Padding = new Padding(3, 4, 3, 4);
            grpEntry.Size = new Size(457, 516);
            grpEntry.TabIndex = 1;
            grpEntry.TabStop = false;
            grpEntry.Text = "Jersey Entry";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(55, 85, 64);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(312, 367);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 45);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(55, 85, 64);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(312, 456);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(55, 85, 64);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(199, 456);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 45);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 85, 64);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(88, 456);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 45);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(141, 241);
            cmbSize.Margin = new Padding(3, 4, 3, 4);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(143, 29);
            cmbSize.TabIndex = 12;
            // 
            // txtStockQty
            // 
            txtStockQty.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStockQty.Location = new Point(141, 372);
            txtStockQty.Margin = new Padding(3, 4, 3, 4);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(143, 29);
            txtStockQty.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(141, 304);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 29);
            txtPrice.TabIndex = 10;
            // 
            // txtTeam
            // 
            txtTeam.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeam.Location = new Point(141, 184);
            txtTeam.Margin = new Padding(3, 4, 3, 4);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(143, 29);
            txtTeam.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(141, 125);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 29);
            txtName.TabIndex = 7;
            // 
            // txtJerseyID
            // 
            txtJerseyID.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtJerseyID.Location = new Point(141, 68);
            txtJerseyID.Margin = new Padding(3, 4, 3, 4);
            txtJerseyID.Name = "txtJerseyID";
            txtJerseyID.ReadOnly = true;
            txtJerseyID.Size = new Size(143, 26);
            txtJerseyID.TabIndex = 6;
            // 
            // lblStockQty
            // 
            lblStockQty.AutoSize = true;
            lblStockQty.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockQty.ForeColor = Color.FromArgb(55, 85, 64);
            lblStockQty.Location = new Point(7, 380);
            lblStockQty.Name = "lblStockQty";
            lblStockQty.Size = new Size(123, 20);
            lblStockQty.TabIndex = 5;
            lblStockQty.Text = "Stock Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(55, 85, 64);
            lblPrice.Location = new Point(71, 312);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.FromArgb(55, 85, 64);
            lblSize.Location = new Point(77, 249);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(40, 20);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam.ForeColor = Color.FromArgb(55, 85, 64);
            lblTeam.Location = new Point(64, 192);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(52, 20);
            lblTeam.TabIndex = 2;
            lblTeam.Text = "Team";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(55, 85, 64);
            lblName.Location = new Point(64, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblJerseyID
            // 
            lblJerseyID.AutoSize = true;
            lblJerseyID.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJerseyID.ForeColor = Color.FromArgb(55, 85, 64);
            lblJerseyID.Location = new Point(48, 68);
            lblJerseyID.Name = "lblJerseyID";
            lblJerseyID.Size = new Size(80, 20);
            lblJerseyID.TabIndex = 0;
            lblJerseyID.Text = "Jersey ID";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(55, 85, 64);
            lblSearch.Location = new Point(545, 131);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(69, 22);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(615, 129);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(143, 29);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 85, 64);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(615, 185);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 45);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(55, 85, 64);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(763, 185);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 45);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvJersey
            // 
            dgvJersey.AllowUserToDeleteRows = false;
            dgvJersey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJersey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJersey.Location = new Point(493, 317);
            dgvJersey.Margin = new Padding(3, 4, 3, 4);
            dgvJersey.Name = "dgvJersey";
            dgvJersey.RowHeadersWidth = 51;
            dgvJersey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJersey.Size = new Size(717, 288);
            dgvJersey.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 85, 64);
            label1.Location = new Point(493, 272);
            label1.Name = "label1";
            label1.Size = new Size(96, 24);
            label1.TabIndex = 18;
            label1.Text = "In-stock";
            // 
            // StockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1245, 699);
            Controls.Add(label1);
            Controls.Add(dgvJersey);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(grpEntry);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StockManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Management";
            Load += StockManagement_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpEntry.ResumeLayout(false);
            grpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJersey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnBack;
        private GroupBox grpEntry;
        private Label lblJerseyID;
        private Label lblStockQty;
        private Label lblPrice;
        private Label lblSize;
        private Label lblTeam;
        private Label lblName;
        private TextBox txtStockQty;
        private TextBox txtPrice;
        private TextBox txtTeam;
        private TextBox txtName;
        private TextBox txtJerseyID;
        private ComboBox cmbSize;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvJersey;
        private Label label1;
    }
}