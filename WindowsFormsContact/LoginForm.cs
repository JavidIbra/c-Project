using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsContact.Core;

namespace WindowsFormsContact
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //errorProvidercheck
            //emailcheck

            string hash = Extencion.Hash(txtPasword.Text);
            var user =usersTableAdapter1.GetDataByLogin(txtEmail.Text, hash).FirstOrDefault();

            if (user==null)
            {
                MessageBox.Show("bele user yoxdur", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            Program.UserId = user.Id;
            switch (user.RoleId)                
            {
                case 1:
                    using (MainForm frm = new MainForm())
                    {
                        frm.ShowDialog();
                    }
                    break;
                case 2:
                    using (UserForm frm = new UserForm())
                    {
                        frm.ShowDialog();
                    }
                    break;
              
                default:
                    MessageBox.Show("bele rol yoxdur", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    break;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
