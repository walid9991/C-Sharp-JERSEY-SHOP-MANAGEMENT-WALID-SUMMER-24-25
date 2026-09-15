using System;
using System.Windows.Forms;

namespace login_2
{
    public partial class RestockDialog : Form
    {
        public int RequestedQty
        {
            get
            {
                try
                {
                    return (int)numQty.Value;
                }
                catch
                {
                    return 1; 
                }
            }
        }

        public RestockDialog(int jerseyId, string size)
        {
            InitializeComponent();

            // Shows which jersey this request is for
            lblInfo.Text = "JerseyID: " + jerseyId + ", Size: " + (size ?? "");

            try
            {
                if (numQty.Minimum < 1)
                    numQty.Minimum = 1;

                if (numQty.Value < numQty.Minimum)
                    numQty.Value = numQty.Minimum;
            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
