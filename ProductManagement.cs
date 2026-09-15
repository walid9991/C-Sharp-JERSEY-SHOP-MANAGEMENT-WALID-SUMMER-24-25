
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using WFA_Sample_A;

namespace AdminDashBoard
{
    public partial class ProductManagement : UserControl
    {
        
        private DataAccess da { get; set; }

       private DataTable dt=new DataTable();
       
        private string? Sql { get; set; }
        
        public ProductManagement()
        {
            InitializeComponent();
            this.da = new DataAccess();
            PopulateGridView();
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Size");
            comboBox1.Items.Add("JerseyID");
            comboBox1.SelectedIndex = 0;

        }

        private void ClearAll()
        {
            this.txtProductName.Clear();
            this.txtProductID.Clear();
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.txtTeamName.Clear();
            this.txtsize.Clear();

        }
        private void PopulateGridView(string sql = "select * from Jersey;")
        {
            try
            {

                dt = da.ExecuteQueryTable("SELECT * FROM [dbo].[Jersey];");
                dgvProductList.DataSource = dt;
                dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "LoadJerseyDbTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                this.Sql = "insert into Jersey(JerseyID, Name, Team, Size, Price, [Stock Quantity]) " +
                           "values('" + this.txtProductID.Text + "', '" + this.txtProductName.Text + "', " +
                           "'" + this.txtTeamName.Text + "', '" + this.txtsize.Text + "', " + 
                           this.txtPrice.Text + ", " + this.txtQuantity.Text + ");";

                int count = this.da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                { 
                    MessageBox.Show(" Product Added Successfully!"); 
                }
                    
                else
                {
                    MessageBox.Show(" Failed to Add Product.");
                }
                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvProductList.CurrentRow != null)
            {
                this.txtProductID.Text = this.dgvProductList.CurrentRow.Cells["JerseyID"].Value.ToString();
                this.txtProductName.Text = this.dgvProductList.CurrentRow.Cells["Name"].Value.ToString();
                this.txtTeamName.Text = this.dgvProductList.CurrentRow.Cells["Team"].Value.ToString();
                this.txtsize.Text = this.dgvProductList.CurrentRow.Cells["Size"].Value.ToString();
                this.txtPrice.Text = this.dgvProductList.CurrentRow.Cells["Price"].Value.ToString();
                this.txtQuantity.Text = this.dgvProductList.CurrentRow.Cells["Stock Quantity"].Value.ToString();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.txtProductID.Text;
                this.Sql = "delete from Jersey where JerseyID = '" + id + "';";

                int count = this.da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(" Product Deleted Successfully!");
                }
                   
                else
                {
                    MessageBox.Show(" Failed to Delete Product.");
                }
                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          try
          {
                if(dt.Rows.Count == 0)
                {
                    return;
                }
                string column = "";
                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() != null)
                {
                    column = comboBox1.SelectedItem.ToString()?? " ";
                }
                string searchText = searchTextBox.Text.Trim();
                searchText = searchText.Replace("'", "''");
                DataView view = dt.DefaultView;
                if (string.IsNullOrEmpty(searchText))
                {
                    view.RowFilter = "";
                }


                else
                {

                    if (column == "JerseyID")
                    {
                        view.RowFilter = "Convert(" + column + ", 'System.String') LIKE '%" + searchText + "%'";
                    }
                    else
                    {

                        view.RowFilter = column + " LIKE '%" + searchText + "%'";
                    }
                }
                dgvProductList.DataSource = view;
          }
            catch (Exception ex)
            {
                
                MessageBox.Show("Oops! Something went wrong!!\n\nDetails: " + ex.Message,
                                "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "update Jersey " +
                        "set Name = '" + this.txtProductName.Text + "', " +
                        "Team = '" + this.txtTeamName.Text + "', " +
                        "Size = '" + this.txtsize.Text + "', " +
                        "Price = " + this.txtPrice.Text + ", " +
                        "[Stock Quantity] = " + this.txtQuantity.Text + " " +
                        "where JerseyID = '" + this.txtProductID.Text + "';";

                int count = this.da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(" Product Updated Successfully!");
                }
                    
                else
                {
                    MessageBox.Show(" Failed to Update Product.");
                }
                    

                PopulateGridView();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SortComboBox(object sender, EventArgs e)
        {
            string column = comboBox1.SelectedItem?.ToString() ?? ""; // "Name", "Team", or "JerseyID"

            DataView dv = dt.DefaultView;
            dv.Sort = column + " ASC";

            dgvProductList.DataSource = dv;
        }
    }
}
