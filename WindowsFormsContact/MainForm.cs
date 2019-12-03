using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsContact.NewFolder1;

namespace WindowsFormsContact
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            using (AddCategoryForm frm = new AddCategoryForm())
            {
                frm.ShowDialog();
            }
        }

        private void btnModels_Click(object sender, EventArgs e)
        {
            using (s frm = new s())
            {
                frm.ShowDialog();
            }
        }

     

        private void btnBrand_Click(object sender, EventArgs e)
        {
            using (BrandForm frm = new BrandForm())
            {
                frm.ShowDialog();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnForUser_Click(object sender, EventArgs e)
        {
            using (UserForm frm = new UserForm())
            {
                frm.ShowDialog();
            }
        }



        private void btnSbCategry_Click(object sender, EventArgs e)
        {
            using (var frm=new SubCategory() )
            {
                frm.ShowDialog();
            }
        }
    }
}
