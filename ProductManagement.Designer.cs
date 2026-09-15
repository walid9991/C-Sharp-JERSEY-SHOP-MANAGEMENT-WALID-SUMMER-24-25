namespace AdminDashBoard
{
    partial class ProductManagement
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
            lblProductManagement = new Label();
            lblProductName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnShowDetails = new Button();
            btnDeleteProduct = new Button();
            dgvProductList = new DataGridView();
            btnAddProduct = new Button();
            lblProductID = new Label();
            txtProductID = new TextBox();
            btnClear = new Button();
            searchTextBox = new TextBox();
            lblSearch = new Label();
            txtTeamName = new TextBox();
            label1 = new Label();
            txtsize = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // lblProductManagement
            // 
            lblProductManagement.AutoSize = true;
            lblProductManagement.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductManagement.Location = new Point(287, 0);
            lblProductManagement.Name = "lblProductManagement";
            lblProductManagement.Size = new Size(324, 41);
            lblProductManagement.TabIndex = 0;
            lblProductManagement.Text = "Product Management";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(3, 230);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(145, 23);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "PRODUCT NAME";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(483, 230);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 23);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "PRICE";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(483, 285);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 23);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "QUANTITY";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(159, 223);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(187, 30);
            txtProductName.TabIndex = 4;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(593, 223);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(187, 30);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(593, 278);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 30);
            txtQuantity.TabIndex = 6;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // btnShowDetails
            // 
            btnShowDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowDetails.Location = new Point(866, 220);
            btnShowDetails.Margin = new Padding(3, 4, 3, 4);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(176, 42);
            btnShowDetails.TabIndex = 8;
            btnShowDetails.Text = "Update Details";
            btnShowDetails.UseVisualStyleBackColor = true;
            btnShowDetails.Click += btnUpdateDetails_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProduct.Location = new Point(866, 155);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(176, 42);
            btnDeleteProduct.TabIndex = 9;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(3, 421);
            dgvProductList.Margin = new Padding(3, 4, 3, 4);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 24;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(1049, 279);
            dgvProductList.TabIndex = 10;
            dgvProductList.DoubleClick += dgvProductList_DoubleClick;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(866, 87);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(176, 42);
            btnAddProduct.TabIndex = 11;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductID.Location = new Point(8, 174);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(113, 23);
            lblProductID.TabIndex = 12;
            lblProductID.Text = "PRODUCT ID";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(159, 167);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(187, 30);
            txtProductID.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(866, 278);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 42);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(159, 87);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 30);
            searchTextBox.TabIndex = 18;
            searchTextBox.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(8, 87);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(76, 23);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "SEARCH";
            // 
            // txtTeamName
            // 
            txtTeamName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeamName.Location = new Point(159, 278);
            txtTeamName.Margin = new Padding(3, 4, 3, 4);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(187, 30);
            txtTeamName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 285);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 20;
            label1.Text = "TEAM NAME";
            // 
            // txtsize
            // 
            txtsize.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtsize.Location = new Point(593, 167);
            txtsize.Margin = new Padding(3, 4, 3, 4);
            txtsize.Name = "txtsize";
            txtsize.Size = new Size(187, 30);
            txtsize.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(483, 174);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 22;
            label2.Text = "SIZE";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(593, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += SortComboBox;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(483, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 24;
            label3.Text = "SORT";
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(txtsize);
            Controls.Add(label1);
            Controls.Add(txtTeamName);
            Controls.Add(searchTextBox);
            Controls.Add(lblSearch);
            Controls.Add(btnClear);
            Controls.Add(txtProductID);
            Controls.Add(lblProductID);
            Controls.Add(btnAddProduct);
            Controls.Add(dgvProductList);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnShowDetails);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(lblProductManagement);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductManagement";
            Size = new Size(1055, 700);
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductManagement;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label lblSearch;
        private TextBox txtTeamName;
        private Label label1;
        private TextBox txtsize;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
    }
}
