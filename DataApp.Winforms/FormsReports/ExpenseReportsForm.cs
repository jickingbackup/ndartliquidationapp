using DataApp.Core;
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
    public partial class ExpenseReportsForm : Form
    {
        MainForm mainform = null;
        DataAppCore db = null;

        public ExpenseReportsForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
        }

        private void ExpenseReportsForm_Load(object sender, EventArgs e)
        {
            LoadData();

            this.reportViewer1.RefreshReport();
        }

        void LoadData()
        {
            var expenses = new List<ExpenseReportViewModel>();

            foreach (var item in this.db.ExpenseController.Get())
            {
                expenses.Add(new ExpenseReportViewModel(item));
            }

            foreach (var item in expenses)
            {
                ExpenseReportViewModelBindingSource.Add(item);
            }
        }
    }
}
