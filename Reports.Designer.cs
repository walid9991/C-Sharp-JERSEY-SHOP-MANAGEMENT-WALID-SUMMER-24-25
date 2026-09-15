namespace AdminDashBoard
{
    partial class Reports
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
            lblTotalSales = new Label();
            lblTotalInventory = new Label();
            lblReports = new Label();
            lblTotalProducts = new Label();
            dgvReportsList = new DataGridView();
            txtSales = new TextBox();
            txttotalSold = new TextBox();
            txtInventory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportsList).BeginInit();
            SuspendLayout();
            // 
            // lblTotalSales
            // 
            lblTotalSales.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(47, 129);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(237, 31);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "Total Sales";
            // 
            // lblTotalInventory
            // 
            lblTotalInventory.AutoSize = true;
            lblTotalInventory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInventory.Location = new Point(47, 271);
            lblTotalInventory.Name = "lblTotalInventory";
            lblTotalInventory.Size = new Size(189, 31);
            lblTotalInventory.TabIndex = 1;
            lblTotalInventory.Text = "Total Inventory  ";
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.Location = new Point(367, 0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(128, 41);
            lblReports.TabIndex = 3;
            lblReports.Text = "Reports";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(47, 201);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(240, 31);
            lblTotalProducts.TabIndex = 4;
            lblTotalProducts.Text = "Total Sold Products   ";
            // 
            // dgvReportsList
            // 
            dgvReportsList.BackgroundColor = Color.SkyBlue;
            dgvReportsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportsList.GridColor = Color.DarkSeaGreen;
            dgvReportsList.Location = new Point(0, 387);
            dgvReportsList.Margin = new Padding(3, 4, 3, 4);
            dgvReportsList.Name = "dgvReportsList";
            dgvReportsList.RowHeadersWidth = 51;
            dgvReportsList.RowTemplate.Height = 24;
            dgvReportsList.Size = new Size(1073, 213);
            dgvReportsList.TabIndex = 5;
            // 
            // txtSales
            // 
            txtSales.BorderStyle = BorderStyle.FixedSingle;
            txtSales.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSales.Location = new Point(290, 136);
            txtSales.Name = "txtSales";
            txtSales.ReadOnly = true;
            txtSales.Size = new Size(205, 27);
            txtSales.TabIndex = 6;
            txtSales.TextChanged += txtSales_TextChanged;
            // 
            // txttotalSold
            // 
            txttotalSold.BorderStyle = BorderStyle.FixedSingle;
            txttotalSold.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttotalSold.Location = new Point(290, 205);
            txttotalSold.Name = "txttotalSold";
            txttotalSold.ReadOnly = true;
            txttotalSold.Size = new Size(205, 27);
            txttotalSold.TabIndex = 7;
            // 
            // txtInventory
            // 
            txtInventory.BorderStyle = BorderStyle.FixedSingle;
            txtInventory.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInventory.Location = new Point(290, 278);
            txtInventory.Name = "txtInventory";
            txtInventory.ReadOnly = true;
            txtInventory.Size = new Size(205, 27);
            txtInventory.TabIndex = 8;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            Controls.Add(txtInventory);
            Controls.Add(txttotalSold);
            Controls.Add(txtSales);
            Controls.Add(dgvReportsList);
            Controls.Add(lblTotalProducts);
            Controls.Add(lblReports);
            Controls.Add(lblTotalInventory);
            Controls.Add(lblTotalSales);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reports";
            Size = new Size(1076, 600);
            ((System.ComponentModel.ISupportInitialize)dgvReportsList).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalInventory;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.DataGridView dgvReportsList;
        private TextBox txtSales;
        private TextBox txttotalSold;
        private TextBox txtInventory;
    }
}
