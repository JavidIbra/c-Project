using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContact.NewFolder1
{
    public partial class SubCategory : Form
    {
        public SubCategory()
        {
            InitializeComponent();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.contactDataSet.Category);
            // TODO: This line of code loads data into the 'contactDataSet.SubCategory' table. You can move, or remove it, as needed.
            this.subCategoryTableAdapter.Fill(this.contactDataSet.SubCategory);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int brandId = Convert.ToInt32(cmbCategory.SelectedValue);
                string category = txtSub.Text;
                subCategoryTableAdapter.AddSub(category, brandId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
