using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTASKImportant.Core
{
   static partial class Extension
    {
        static public void InitGrid(this DataGridView  gridView)
        {

            gridView.AllowUserToAddRows = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (var column in gridView.Columns)
            {
                if (column is DataGridViewTextBoxColumn)
                {
                    (column as DataGridViewTextBoxColumn).ReadOnly = true;

                    if ((column as DataGridViewTextBoxColumn).HeaderText.Contains("Id"))
                    {
                        (column as DataGridViewTextBoxColumn).Visible = false;
                    }
                }

            }

        }

        static public int? GetId(this ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
                return null;

            return Convert.ToInt32(comboBox.SelectedValue);
        }

    }
}
