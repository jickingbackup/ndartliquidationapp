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
            long maxRows = 0;
            long counter = 0;
            var expenses = new List<ExpenseReportViewModel>();
            var rawExpenses = this.db.ExpenseController.Get();

            ExpenseReportViewModelBindingSource.Clear();
            long.TryParse(numericUpDownMaxRows.Value.ToString(), out maxRows);
            //filter here.


            foreach (var item in rawExpenses)
            {
                if (counter >= maxRows)
                    break;
                expenses.Add(new ExpenseReportViewModel(item));
                counter++;
            }

            foreach (var item in expenses)
            {
                ExpenseReportViewModelBindingSource.Add(item);
            }

            reportViewer1.RefreshReport();
        }

        private void InitializeComboboxes()
        {
            //throw new NotImplementedException();
        }

        private void ExpenseReportsForm_Activated(object sender, EventArgs e)
        {
            InitializeComboboxes();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}
