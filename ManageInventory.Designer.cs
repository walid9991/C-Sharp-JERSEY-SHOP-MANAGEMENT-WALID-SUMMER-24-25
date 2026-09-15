namespace login_2
{
    partial class ManageInventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelFilters = new Panel();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            lblTeam = new Label();
            lblSearch = new Label();
            cboTeam = new ComboBox();
            lblSize = new Label();
            cboSize = new ComboBox();
            lblStock = new Label();
            cboStockStatus = new ComboBox();
            dgvInventory = new DataGridView();
            btnRequestRestock = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panelHeader.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(55, 85, 64);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-2, -3);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1062, 81);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(98, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Inventory";
            // 
            // panelFilters
            // 
            panelFilters.BackColor = Color.FromArgb(55, 85, 64);
            panelFilters.Controls.Add(btnRefresh);
            panelFilters.Controls.Add(txtSearch);
            panelFilters.Controls.Add(lblTeam);
            panelFilters.Controls.Add(lblSearch);
            panelFilters.Controls.Add(cboTeam);
            panelFilters.Controls.Add(lblSize);
            panelFilters.Controls.Add(cboSize);
            panelFilters.Controls.Add(lblStock);
            panelFilters.Controls.Add(cboStockStatus);
            panelFilters.Location = new Point(82, 100);
            panelFilters.Margin = new Padding(3, 4, 3, 4);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(886, 196);
            panelFilters.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(467, 128);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 44);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(415, 77);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(138, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam.ForeColor = SystemColors.ControlLightLight;
            lblTeam.Location = new Point(47, 25);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(61, 23);
            lblTeam.TabIndex = 3;
            lblTeam.Text = "Team";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = SystemColors.ControlLightLight;
            lblSearch.Location = new Point(330, 83);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(83, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "SEARCH";
            // 
            // cboTeam
            // 
            cboTeam.BackColor = SystemColors.InactiveCaption;
            cboTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTeam.FormattingEnabled = true;
            cboTeam.Location = new Point(114, 20);
            cboTeam.Margin = new Padding(3, 4, 3, 4);
            cboTeam.Name = "cboTeam";
            cboTeam.Size = new Size(138, 28);
            cboTeam.TabIndex = 2;
            cboTeam.SelectedIndexChanged += cboTeam_SelectedIndexChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = SystemColors.ControlLightLight;
            lblSize.Location = new Point(47, 77);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 23);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // cboSize
            // 
            cboSize.BackColor = SystemColors.InactiveCaption;
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(114, 72);
            cboSize.Margin = new Padding(3, 4, 3, 4);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(138, 28);
            cboSize.TabIndex = 3;
            cboSize.SelectedIndexChanged += cboSize_SelectedIndexChanged;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = SystemColors.ControlLightLight;
            lblStock.Location = new Point(334, 25);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 23);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // cboStockStatus
            // 
            cboStockStatus.BackColor = SystemColors.InactiveCaption;
            cboStockStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStockStatus.FormattingEnabled = true;
            cboStockStatus.Items.AddRange(new object[] { "All", "In Stock", "Low (≤5)", "Out (0)" });
            cboStockStatus.Location = new Point(415, 25);
            cboStockStatus.Margin = new Padding(3, 4, 3, 4);
            cboStockStatus.Name = "cboStockStatus";
            cboStockStatus.Size = new Size(138, 28);
            cboStockStatus.TabIndex = 4;
            cboStockStatus.SelectedIndexChanged += cboStockStatus_SelectedIndexChanged;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.Location = new Point(82, 392);
            dgvInventory.Margin = new Padding(3, 4, 3, 4);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(886, 251);
            dgvInventory.TabIndex = 5;
            // 
            // btnRequestRestock
            // 
            btnRequestRestock.BackColor = Color.FromArgb(55, 85, 64);
            btnRequestRestock.FlatAppearance.BorderSize = 0;
            btnRequestRestock.FlatStyle = FlatStyle.Flat;
            btnRequestRestock.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequestRestock.ForeColor = SystemColors.ControlLightLight;
            btnRequestRestock.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequestRestock.Location = new Point(210, 663);
            btnRequestRestock.Margin = new Padding(3, 4, 3, 4);
            btnRequestRestock.Name = "btnRequestRestock";
            btnRequestRestock.Size = new Size(243, 59);
            btnRequestRestock.TabIndex = 8;
            btnRequestRestock.Text = "Request Restock";
            btnRequestRestock.UseVisualStyleBackColor = false;
            btnRequestRestock.Click += BtnRequestRestock_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(55, 85, 64);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(82, 664);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 59);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 85, 64);
            panel1.Location = new Point(999, 111);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(45, 593);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 85, 64);
            panel2.Location = new Point(14, 111);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(43, 593);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 85, 64);
            label1.Location = new Point(82, 352);
            label1.Name = "label1";
            label1.Size = new Size(168, 24);
            label1.TabIndex = 13;
            label1.Text = "Stock Available";
            // 
            // ManageInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1057, 752);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnRequestRestock);
            Controls.Add(dgvInventory);
            Controls.Add(panelFilters);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageInventory";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelFilters;
        private Label lblTeam;

        private Button btnRefresh;
        private Button btnRequestRestock;
        private Label lblSearch;
        private ComboBox cboTeam;
        private Label lblSize;
        private ComboBox cboSize;
        private Label lblStock;
        private ComboBox cboStockStatus;

        private DataGridView dgvInventory;

        private TextBox txtSearch;
        private Button btnBack;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
