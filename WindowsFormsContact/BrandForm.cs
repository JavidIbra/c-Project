using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContact
{
    public partial class BrandForm : Form
    {
        public BrandForm()
        {
            InitializeComponent();
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.contactDataSet.Brands);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
              
                string brand = txtBrand.Text;
                brandsTableAdapter.AddBrand(brand, Program.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        //private void brandsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.brandsBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.contactDataSet);

        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    var current = (brandsBindingSource.Current as DataRowView)?.Row as BrandsFormRow;
        //    if (current == null)
        //    {
        //        return;
        //    }
        //    brandsTableAdapter.Updatebrand(txtBrand.Text, current.Id);
        //    this.brandsTableAdapter.Fill(this.contactDataSet.Brands);
        //    txtBrand.Text = "";
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    var current = (brandsBindingSource.Current as DataRowView)?.Row as BrandsFormRow;
        //}

        private void bntSearch_Click(object sender, EventArgs e)
        {
            var name = txtBrand.Text;
            brandsTableAdapter.FillByName(this.contactDataSet.Brands, name);
        }

        //private void brandsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var current = (brandsDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row as brandsRow;
        //    if (current == null)
        //    {
        //        return;

        //    }


        //    txtBrand.Text = current.Name;
        //}
    }
}
