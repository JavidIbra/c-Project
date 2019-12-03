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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            using (CarForm frm = new CarForm())
            {
                frm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
