using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsContact.Data.ContactDataSet;

namespace WindowsFormsContact
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.contactDataSet.Category);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                string category = txtCategory.Text;
            categoryTableAdapter.AddCategory(category);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var current = (categoryBindingSource.Current as DataRowView).Row as CategoryRow;
            if (current==null)
            {
                return;
            }
            categoryTableAdapter.UpdateCategory(txtCategory.Text, current.Id);
            this.categoryTableAdapter.Fill(this.contactDataSet.Category);
            txtCategory.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = (dataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row as CategoryRow;
            if (current==null)
            {
                return;

            }


            txtCategory.Text = current.Name;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = (categoryBindingSource.Current as DataRowView).Row as CategoryRow;
            if (current==null)
            {
                return;
            }
           var result = MessageBox.Show("silinsin?", "sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                categoryTableAdapter.DeletedCategory(current.Id);
                this.categoryTableAdapter.Fill(this.contactDataSet.Category);
                txtCategory.Text = "";
            }
            else
            {
                MessageBox.Show("agilli ol");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = txtCategory.Text;
            categoryTableAdapter.FillByName(this.contactDataSet.Category, name);
        }
    }
}
