using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTASKImportant
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapterSearch.Fill(this.rentACarDataSet.Cars);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //this.carsTableAdapterSearch
            //this.carsTableAdapterSearch.Search(rentACarDataSet.Cars, Convert.ToInt32(txtSearch.Text));
            //dgvSearch.DataSource = rentACarDataSet.Cars.Where(x => x.BrandName.Contains(txtSearch.Text)).ToList();
        }
    }
}
