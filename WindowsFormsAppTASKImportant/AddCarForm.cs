using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTASKImportant.Core;

namespace WindowsFormsAppTASKImportant
{
    public partial class AddCarForm : Form
    {
        private object carsTableAdapter;

        public AddCarForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int modelId = Convert.ToInt32(cmbModel.SelectedValue);
                int fuelId = Convert.ToInt32(cmbFuel.SelectedValue);
                int winId = Convert.ToInt32(cmbWin.SelectedValue);
                int typeId = Convert.ToInt32(cmbType.SelectedValue);
                int engineId = Convert.ToInt32(cmbEngine.SelectedValue);


                carsTableAdapter1.AddCar(modelId, fuelId, winId, typeId, engineId, winId);
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
               
            }
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Model' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSet.Engine' table. You can move, or remove it, as needed.
            this.engineTableAdapter.Fill(this.dataSet.Engine);
            // TODO: This line of code loads data into the 'dataSet.Fuel' table. You can move, or remove it, as needed.
            this.fuelTableAdapter.Fill(this.dataSet.Fuel);
            // TODO: This line of code loads data into the 'rentACarDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.dataSet.Type);
            // TODO: This line of code loads data into the 'rentACarDataSet.Win' table. You can move, or remove it, as needed.
            this.winTableAdapter.Fill(this.dataSet.Win);
            // TODO: This line of code loads data into the 'rentACarDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.dataSet.Brand);
            // TODO: This line of code loads data into the 'rentACarDataSet.Fuel' table. You can move, or remove it, as needed.
            this.fuelTableAdapter.Fill(this.dataSet.Fuel);
            // TODO: This line of code loads data into the 'rentACarDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.dataSet.Type);
            // TODO: This line of code loads data into the 'rentACarDataSet.Win' table. You can move, or remove it, as needed.
            this.winTableAdapter.Fill(this.dataSet.Win);

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? brandId = cmbBrand.GetId();
            if (brandId.HasValue)
            {
                this.modelTableAdapter.FillByBrandId(this.dataSet.Model, brandId.Value);
            }
            
        }
    }
}
