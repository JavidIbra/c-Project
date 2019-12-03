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
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void AddModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDataSet1.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.contactDataSet1.Models);
            // TODO: This line of code loads data into the 'contactDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.contactDataSet.Brands);
            // TODO: This line of code loads data into the 'contactDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.contactDataSet.Models);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int brandId = Convert.ToInt32(cmbBrand.SelectedValue);
                string model =txtModel .Text;
                modelsTableAdapter.addModel(model, brandId,Program.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var current = (modelsBindingSource.Current as DataRowView)?.Row as ModelsRow;
            if (current==null)
            {
                return;
            }


            modelsTableAdapter.UpdateModel(txtModel.Text, current.BrandId, current.Id);
            this.modelsTableAdapter.Fill(this.contactDataSet.Models);
            txtModel.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = (dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row as ModelsRow;
            if (current==null)
            {
                return;
            }
            txtModel.Text = current.Name;
            cmbBrand.SelectedValue = current.BrandId;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = (modelsBindingSource.Current as DataRowView)?.Row as ModelsRow;
            if (current==null)
            {
                return;
            }
            var result = MessageBox.Show("silinsin?", "sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result==DialogResult.OK)
            {
                modelsTableAdapter.DeleteDate(current.Id);
                this.modelsTableAdapter.Fill(this.contactDataSet.Models);
                txtModel.Text = "";
            }
            else
            {
                MessageBox.Show("agilli ol");

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //var current = (dataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row as CategoryRow;
            //if (current == null)
            //{
            //    return;

            //}
            //cmbBrand.SelectedValue = current.Id;
            var name = txtModel.Text;
            modelsTableAdapter.FillByName(this.contactDataSet.Models, name, null);
        }
    }
}
