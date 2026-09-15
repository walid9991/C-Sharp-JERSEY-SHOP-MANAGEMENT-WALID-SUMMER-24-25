namespace EmployeeDashboard
{
    partial class EmployeeControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeControl3));
            panel1 = new Panel();
            lblEmpID = new Label();
            lblEmpName = new Label();
            lblCusName = new Label();
            lblProductID = new Label();
            lblGmail = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblWelcome = new Label();
            lblProductQuantity = new Label();
            txtEmpID = new TextBox();
            lblDate = new Label();
            txtEmpName = new TextBox();
            txtCusName = new TextBox();
            txtGmail = new TextBox();
            txtProductID = new TextBox();
            txtProductQuantity = new TextBox();
            PurchaseDate = new DateTimePicker();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnReset = new Button();
            bbtnLogout = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            dgvCustomerInfo = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txttotalprice = new TextBox();
            emailerror = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Location = new Point(-8, 1);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 908);
            panel1.TabIndex = 0;
            // 
            // lblEmpID
            // 
            lblEmpID.AutoSize = true;
            lblEmpID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpID.ForeColor = SystemColors.ControlLightLight;
            lblEmpID.Location = new Point(770, 154);
            lblEmpID.Margin = new Padding(4, 0, 4, 0);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(132, 23);
            lblEmpID.TabIndex = 1;
            lblEmpID.Text = "Employee ID:";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpName.ForeColor = SystemColors.ControlLightLight;
            lblEmpName.Location = new Point(767, 209);
            lblEmpName.Margin = new Padding(4, 0, 4, 0);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(165, 23);
            lblEmpName.TabIndex = 3;
            lblEmpName.Text = "Employee Name:";
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusName.ForeColor = SystemColors.ControlLightLight;
            lblCusName.Location = new Point(767, 256);
            lblCusName.Margin = new Padding(4, 0, 4, 0);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(162, 23);
            lblCusName.TabIndex = 4;
            lblCusName.Text = "Customer Name:";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductID.ForeColor = SystemColors.ControlLightLight;
            lblProductID.Location = new Point(165, 136);
            lblProductID.Margin = new Padding(4, 0, 4, 0);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(113, 23);
            lblProductID.TabIndex = 5;
            lblProductID.Text = "Product ID:";
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmail.ForeColor = SystemColors.ControlLightLight;
            lblGmail.Location = new Point(770, 304);
            lblGmail.Margin = new Padding(4, 0, 4, 0);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(70, 23);
            lblGmail.TabIndex = 6;
            lblGmail.Text = "Gmail:";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Cambria", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlLightLight;
            lblWelcome.Location = new Point(187, 38);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(426, 40);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome to Sell Dashboard";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductQuantity.ForeColor = SystemColors.ControlLightLight;
            lblProductQuantity.Location = new Point(165, 188);
            lblProductQuantity.Margin = new Padding(4, 0, 4, 0);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(172, 23);
            lblProductQuantity.TabIndex = 8;
            lblProductQuantity.Text = "Product Quantity:";
            // 
            // txtEmpID
            // 
            txtEmpID.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmpID.Location = new Point(955, 154);
            txtEmpID.Margin = new Padding(4, 5, 4, 5);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.ReadOnly = true;
            txtEmpID.Size = new Size(188, 27);
            txtEmpID.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(165, 329);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(148, 23);
            lblDate.TabIndex = 10;
            lblDate.Text = "Purchase Date:";
            // 
            // txtEmpName
            // 
            txtEmpName.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmpName.Location = new Point(955, 205);
            txtEmpName.Margin = new Padding(4, 5, 4, 5);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.ReadOnly = true;
            txtEmpName.Size = new Size(264, 27);
            txtEmpName.TabIndex = 11;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(955, 252);
            txtCusName.Margin = new Padding(4, 5, 4, 5);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(264, 27);
            txtCusName.TabIndex = 12;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(956, 300);
            txtGmail.Margin = new Padding(4, 5, 4, 5);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(263, 27);
            txtGmail.TabIndex = 13;
            txtGmail.TextChanged += txtGmail_TextChanged;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(336, 132);
            txtProductID.Margin = new Padding(4, 5, 4, 5);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(187, 27);
            txtProductID.TabIndex = 14;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(336, 188);
            txtProductQuantity.Margin = new Padding(4, 5, 4, 5);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.ReadOnly = true;
            txtProductQuantity.Size = new Size(187, 27);
            txtProductQuantity.TabIndex = 15;
            // 
            // PurchaseDate
            // 
            PurchaseDate.Location = new Point(336, 325);
            PurchaseDate.Margin = new Padding(4, 5, 4, 5);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(265, 27);
            PurchaseDate.TabIndex = 16;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlLightLight;
            lblPrice.Location = new Point(165, 240);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(139, 23);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Product Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(336, 240);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(188, 27);
            txtPrice.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(1020, 840);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(264, 52);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "CONFIRM SALE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnConfirmSale_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.MediumSeaGreen;
            btnReset.FlatAppearance.BorderSize = 2;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(324, 381);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 52);
            btnReset.TabIndex = 21;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // bbtnLogout
            // 
            bbtnLogout.BackColor = Color.MediumSeaGreen;
            bbtnLogout.FlatAppearance.BorderSize = 2;
            bbtnLogout.FlatStyle = FlatStyle.Flat;
            bbtnLogout.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bbtnLogout.ForeColor = SystemColors.ControlLightLight;
            bbtnLogout.Location = new Point(183, 381);
            bbtnLogout.Margin = new Padding(4, 5, 4, 5);
            bbtnLogout.Name = "bbtnLogout";
            bbtnLogout.Size = new Size(111, 52);
            bbtnLogout.TabIndex = 22;
            bbtnLogout.Text = "BACK";
            bbtnLogout.UseVisualStyleBackColor = false;
            bbtnLogout.Click += btnback_Click;
            // 
            // dgvCustomerInfo
            // 
            dgvCustomerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerInfo.Location = new Point(183, 443);
            dgvCustomerInfo.Margin = new Padding(4, 5, 4, 5);
            dgvCustomerInfo.Name = "dgvCustomerInfo";
            dgvCustomerInfo.RowHeadersWidth = 51;
            dgvCustomerInfo.Size = new Size(1101, 388);
            dgvCustomerInfo.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1059, -38);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(165, 284);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 26;
            label1.Text = "Total Price:";
            // 
            // txttotalprice
            // 
            txttotalprice.Location = new Point(336, 284);
            txttotalprice.Margin = new Padding(4, 5, 4, 5);
            txttotalprice.Name = "txttotalprice";
            txttotalprice.ReadOnly = true;
            txttotalprice.Size = new Size(188, 27);
            txttotalprice.TabIndex = 27;
            // 
            // emailerror
            // 
            emailerror.AutoSize = true;
            emailerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailerror.ForeColor = Color.Red;
            emailerror.Location = new Point(956, 341);
            emailerror.Name = "emailerror";
            emailerror.Size = new Size(0, 23);
            emailerror.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(461, 381);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(111, 52);
            button1.TabIndex = 29;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += removebtn_Click;
            // 
            // EmployeeControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 85, 65);
            ClientSize = new Size(1312, 906);
            Controls.Add(button1);
            Controls.Add(emailerror);
            Controls.Add(txttotalprice);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvCustomerInfo);
            Controls.Add(bbtnLogout);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(PurchaseDate);
            Controls.Add(txtProductQuantity);
            Controls.Add(txtProductID);
            Controls.Add(txtGmail);
            Controls.Add(txtCusName);
            Controls.Add(txtEmpName);
            Controls.Add(lblDate);
            Controls.Add(txtEmpID);
            Controls.Add(lblProductQuantity);
            Controls.Add(lblGmail);
            Controls.Add(lblProductID);
            Controls.Add(lblCusName);
            Controls.Add(lblEmpName);
            Controls.Add(lblEmpID);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeeControl3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblGmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.DateTimePicker PurchaseDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button bbtnLogout;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private TextBox txttotalprice;
        private Label emailerror;
        private Button button1;
    }
}

