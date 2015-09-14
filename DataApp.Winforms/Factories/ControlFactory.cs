using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    class ControlFactory
    {
        public static void SetDataGridSettings(DataGridView control)
        {
            control.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            control.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            //control.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            control.MultiSelect = false;
            control.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            control.ShowEditingIcon = false;
            //control.StandardTab = true;
            
        }
    }
}
