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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDataSet.SubCategory' table. You can move, or remove it, as needed.
            this.subCategoryTableAdapter.Fill(this.contactDataSet.SubCategory);
            // TODO: This line of code loads data into the 'contactDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.contactDataSet.Category);
            // TODO: This line of code loads data into the 'contactDataSet.Product' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'contactDataSet.Product' table. You can move, or remove it, as needed.
        

        }
    }
}
