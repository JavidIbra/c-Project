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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
            dataGridView1.InitGrid();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDataSet.spCars' table. You can move, or remove it, as needed.
            this.spCarsTableAdapter.Fill(this.rentACarDataSet.spCars);
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            using (AddCarForm frm1 = new AddCarForm())
            {
                if (frm1.ShowDialog()==DialogResult.OK)
                {
                    this.spCarsTableAdapter.Fill(this.rentACarDataSet.spCars);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using(var frm = new frmSearch())
            {
                frm.ShowDialog();
            }
        }
    }
}
