namespace login_2
{
    partial class RestockDialog
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
            lblInfo = new Label();
            lblQty = new Label();
            numQty = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 12);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(105, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "JerseyID: ..., Size: ...\n";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(12, 44);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(56, 15);
            lblQty.TabIndex = 1;
            lblQty.Text = "Quantity:";
            // 
            // numQty
            // 
            numQty.Location = new Point(80, 40);
            numQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(120, 23);
            numQty.TabIndex = 2;
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(135, 86);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(216, 86);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RestockDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(324, 121);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(numQty);
            Controls.Add(lblQty);
            Controls.Add(lblInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RestockDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Request Restock";
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label lblQty;
        private NumericUpDown numQty;
        private Button btnOk;
        private Button btnCancel;
    }
}