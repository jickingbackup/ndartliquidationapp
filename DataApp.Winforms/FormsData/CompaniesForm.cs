using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    public partial class CompaniesForm : Form
    {
        MainForm mainform = null;

        public CompaniesForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
        }
    }
}