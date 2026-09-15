namespace login_2
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            panel2 = new Panel();
            Showpass = new CheckBox();
            panel5 = new Panel();
            panel4 = new Panel();
            Login = new Label();
            groupBox1 = new GroupBox();
            txtpassword = new TextBox();
            label4 = new Label();
            txtuserID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 85, 64);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 648);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Showpass);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(txtpassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtuserID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(67, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 466);
            panel2.TabIndex = 0;
            // 
            // Showpass
            // 
            Showpass.AutoSize = true;
            Showpass.Font = new Font("Cambria", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Showpass.ForeColor = Color.FromArgb(55, 85, 64);
            Showpass.Location = new Point(18, 322);
            Showpass.Name = "Showpass";
            Showpass.Size = new Size(138, 21);
            Showpass.TabIndex = 13;
            Showpass.Text = "Show Password";
            Showpass.UseVisualStyleBackColor = true;
            Showpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(477, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(419, 466);
            panel5.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(30, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 60);
            panel4.TabIndex = 11;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(55, 85, 64);
            Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonFace;
            Login.Location = new Point(18, 374);
            Login.Name = "Login";
            Login.Size = new Size(344, 33);
            Login.TabIndex = 10;
            Login.Text = "SIGN IN";
            Login.TextAlign = ContentAlignment.MiddleCenter;
            Login.Click += Login_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(540, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Location = new Point(18, 282);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(344, 27);
            txtpassword.TabIndex = 6;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(55, 85, 64);
            label4.Location = new Point(18, 251);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtuserID
            // 
            txtuserID.BorderStyle = BorderStyle.FixedSingle;
            txtuserID.Location = new Point(18, 180);
            txtuserID.Name = "txtuserID";
            txtuserID.Size = new Size(344, 27);
            txtuserID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(55, 84, 64);
            label3.Location = new Point(18, 149);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 3;
            label3.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 85, 64);
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(283, 40);
            label2.TabIndex = 2;
            label2.Text = "WELCOME BACK!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 85, 64);
            label1.Location = new Point(195, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 85, 64);
            panel3.Location = new Point(3, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(21, 58);
            panel3.TabIndex = 0;
            // 
            // LoginPage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 648);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN PAGE";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Login;
        private GroupBox groupBox1;
        private TextBox txtpassword;
        private Label label4;
        private TextBox txtuserID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox Showpass;
    }
}
