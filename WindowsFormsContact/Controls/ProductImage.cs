using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContact.Controls
{
    public partial class ProductImage : UserControl
    {
        public ProductImage()
        {
            InitializeComponent();
        }

        decimal price;
       new public string ProductName {
            get 
            {
                return label1.Text;
            }
            set
            {
                label1.Text=value;
            }
        
        }

        public decimal Price { 
            get 
            {
                return price;
            }
            set
            {
                price = value;
                lblPrice.Text = $"{value :0.00}₼";
            }
        }

        public Image Picture { 
            get 
            {

                return picture.Image;
            }
            set
            {
                picture.Image = value;
            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
