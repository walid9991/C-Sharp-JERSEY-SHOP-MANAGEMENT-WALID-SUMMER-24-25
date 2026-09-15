namespace login_2
{
    partial class SellProduct
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellProduct));
            panelHeader = new Panel();
            TitleLabel = new Label();
            Logoutbtn = new Button();
            panelsearch = new Panel();
            comboBox1 = new ComboBox();
            labelsort = new Label();
            searchTextBox = new TextBox();
            labelsearch = new Label();
            ProcessToSaleBtn = new Button();
            button2 = new Button();
            dgvProduct = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            dgvCart = new DataGridView();
            JerseyID = new DataGridViewTextBoxColumn();
            JerseyName = new DataGridViewTextBoxColumn();
            TeamName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            JerseyQuantity = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            totalpricelbl = new Label();
            panelHeader.SuspendLayout();
            panelsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.RosyBrown;
            panelHeader.Controls.Add(TitleLabel);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 60);
            panelHeader.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(378, 14);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(387, 33);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "WELCOME TO THE SELL PAGE";
            // 
            // Logoutbtn
            // 
            Logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.Location = new Point(1070, 12);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(100, 35);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "BACK";
            Logoutbtn.UseVisualStyleBackColor = true;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // panelsearch
            // 
            panelsearch.BackColor = Color.Teal;
            panelsearch.Controls.Add(comboBox1);
            panelsearch.Controls.Add(labelsort);
            panelsearch.Controls.Add(searchTextBox);
            panelsearch.Controls.Add(labelsearch);
            panelsearch.Location = new Point(0, 66);
            panelsearch.Name = "panelsearch";
            panelsearch.Size = new Size(1200, 69);
            panelsearch.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += SortCombobox;
            // 
            // labelsort
            // 
            labelsort.AutoSize = true;
            labelsort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsort.Location = new Point(300, 20);
            labelsort.Name = "labelsort";
            labelsort.Size = new Size(38, 20);
            labelsort.TabIndex = 2;
            labelsort.Text = "Sort";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(80, 18);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(200, 27);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += productGridSearch;
            // 
            // labelsearch
            // 
            labelsearch.AutoSize = true;
            labelsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsearch.Location = new Point(20, 20);
            labelsearch.Name = "labelsearch";
            labelsearch.Size = new Size(63, 23);
            labelsearch.TabIndex = 0;
            labelsearch.Text = "Search";
            // 
            // ProcessToSaleBtn
            // 
            ProcessToSaleBtn.AutoSize = true;
            ProcessToSaleBtn.BackColor = Color.Aqua;
            ProcessToSaleBtn.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcessToSaleBtn.Location = new Point(1050, 593);
            ProcessToSaleBtn.Name = "ProcessToSaleBtn";
            ProcessToSaleBtn.Size = new Size(138, 45);
            ProcessToSaleBtn.TabIndex = 6;
            ProcessToSaleBtn.Text = "Proceed to sale";
            ProcessToSaleBtn.UseVisualStyleBackColor = false;
            ProcessToSaleBtn.Click += ProcessToSaleBtn_work;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1058, 160);
            button2.Name = "button2";
            button2.Size = new Size(130, 40);
            button2.TabIndex = 7;
            button2.Text = "ADD TO CART";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddToCart_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.Teal;
            dgvProduct.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(0, 141);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1036, 255);
            dgvProduct.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1058, 226);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 10;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += removebtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCart);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 176);
            panel1.TabIndex = 11;
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = Color.MistyRose;
            dgvCart.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { JerseyID, JerseyName, TeamName, UnitPrice, Size, JerseyQuantity });
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(0, 34);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1200, 142);
            dgvCart.TabIndex = 1;
            // 
            // JerseyID
            // 
            JerseyID.HeaderText = "JerseyID";
            JerseyID.MinimumWidth = 6;
            JerseyID.Name = "JerseyID";
            JerseyID.ReadOnly = true;
            JerseyID.Width = 200;
            // 
            // JerseyName
            // 
            JerseyName.HeaderText = "Name";
            JerseyName.MinimumWidth = 6;
            JerseyName.Name = "JerseyName";
            JerseyName.ReadOnly = true;
            JerseyName.Width = 200;
            // 
            // TeamName
            // 
            TeamName.HeaderText = "Team";
            TeamName.MinimumWidth = 6;
            TeamName.Name = "TeamName";
            TeamName.ReadOnly = true;
            TeamName.Width = 200;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 200;
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            Size.Width = 200;
            // 
            // JerseyQuantity
            // 
            JerseyQuantity.HeaderText = "Quantity";
            JerseyQuantity.MinimumWidth = 6;
            JerseyQuantity.Name = "JerseyQuantity";
            JerseyQuantity.Width = 200;
            // 
            // label1
            // 
            label1.BackColor = Color.LightPink;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1200, 34);
            label1.TabIndex = 0;
            label1.Text = "         ITEM CART";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 598);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 13;
            label2.Text = "Total Price:";
            // 
            // totalpricelbl
            // 
            totalpricelbl.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalpricelbl.Location = new Point(123, 598);
            totalpricelbl.Name = "totalpricelbl";
            totalpricelbl.Size = new Size(254, 27);
            totalpricelbl.TabIndex = 14;
            // 
            // SellProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1200, 656);
            Controls.Add(totalpricelbl);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(dgvProduct);
            Controls.Add(panelsearch);
            Controls.Add(button2);
            Controls.Add(ProcessToSaleBtn);
            Controls.Add(Logoutbtn);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SellProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SELL PRODUCT DASHBOARD";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelsearch.ResumeLayout(false);
            panelsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label TitleLabel;
        private Button Logoutbtn;
        private Panel panelsearch;
        private ComboBox comboBox1;
        private Label labelsort;
        private TextBox searchTextBox;
        private Label labelsearch;
        private Button ProcessToSaleBtn;
        private Button button2;
        private DataGridView dgvProduct;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvCart;
        private Label label2;
        private Label totalpricelbl;
        private DataGridViewTextBoxColumn JerseyID;
        private DataGridViewTextBoxColumn JerseyName;
        private DataGridViewTextBoxColumn TeamName;
        private DataGridViewTextBoxColumn UnitPrice;
        private new DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn JerseyQuantity;
    }
}
