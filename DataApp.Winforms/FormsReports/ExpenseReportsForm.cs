using DataApp.Core;
using DataApp.Winforms.ViewModels;
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
        FilterMethod filterMethod = FilterMethod.checks;
        bool isLoaded = false;

        public ExpenseReportsForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
        }

        private void ExpenseReportsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            InitializeComboboxes();
            this.reportViewer1.RefreshReport();
            isLoaded = true;
        }

        void LoadData()
        {
            long maxRows = 0;
            long counter = 0;
            var expenses = new List<ExpenseReportViewModel>();
            var rawExpenses = this.db.ExpenseController.Get().ToList();

            ExpenseReportViewModelBindingSource.Clear();
            long.TryParse(numericUpDownMaxRows.Value.ToString(), out maxRows);

            //filter here.
            if (isLoaded)
            {
                switch (this.filterMethod)
                {
                    case FilterMethod.checks:
                        rawExpenses = rawExpenses
                            .Where(e =>
                                e.CheckId == (int)comboBoxChecks.SelectedValue
                                ).ToList();
                        break;
                    case FilterMethod.date:
                        rawExpenses = rawExpenses
                            .Where(e =>
                                e.Date.Date <= dateTimePickerMinDate.Value.Date
                                && e.Date.Date >= dateTimePickerMaxDate.Value.Date
                                ).ToList();
                        break;
                    case FilterMethod.project:
                        rawExpenses = rawExpenses
                            .Where(e =>
                                e.ProjectId == (int)comboBoxProject.SelectedValue
                                ).ToList();
                        break;
                    case FilterMethod.all:
                        rawExpenses = rawExpenses
                            .Where(e =>
                                e.CheckId == (int)comboBoxChecks.SelectedValue
                                && e.ProjectId == (int)comboBoxProject.SelectedValue
                                && (e.Date.Date <= dateTimePickerMinDate.Value.Date
                                    && e.Date.Date >= dateTimePickerMaxDate.Value.Date)
                                ).ToList();
                        break;
                    default:
                        break;
                }
            }

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
            var projects = this.db.ProjectController.Get().ToList();

            //set projects
            comboBoxProject.DisplayMember = "Name";
            comboBoxProject.ValueMember = "Id";
            comboBoxProject.DataSource = projects;
            //set checks
            List<CheckComboboxViewModel> checkComboData = new List<CheckComboboxViewModel>();
            foreach (var i in db.CheckController.Get())
            {
                checkComboData.Add(new CheckComboboxViewModel(i));
            }
            comboBoxChecks.ValueMember = "Id";
            comboBoxChecks.DisplayMember = "Name";
            comboBoxChecks.DataSource = checkComboData;

            //set filter combo box
            comboBoxFilterMethod.SelectedIndex = 0;
            comboBoxProject.SelectedIndex = 0;
            comboBoxChecks.SelectedIndex = 0;
        }

        private void ExpenseReportsForm_Activated(object sender, EventArgs e)
        {
            if(isLoaded)
                InitializeComboboxes();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public enum FilterMethod
        {
            checks, date, project,all
        }

        private void comboBoxFilterMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterMethod.Text.ToLower() == "check")
            {
                this.filterMethod = FilterMethod.checks;
                //enable controls
                comboBoxChecks.Enabled = true;
                //disable cotrols
                dateTimePickerMaxDate.Enabled = false;
                dateTimePickerMinDate.Enabled = false;
                comboBoxProject.Enabled = false;
            }

            if (comboBoxFilterMethod.Text.ToLower() == "date")
            {
                this.filterMethod = FilterMethod.date;
                //enable controls
                dateTimePickerMaxDate.Enabled = true;
                dateTimePickerMinDate.Enabled = true;
                //disable cotrols
                comboBoxChecks.Enabled = false;
                comboBoxProject.Enabled = false;
            }

            if (comboBoxFilterMethod.Text.ToLower() == "project")
            {
                this.filterMethod = FilterMethod.project;
                //enable controls
                comboBoxProject.Enabled = true;
                //disable cotrols
                comboBoxChecks.Enabled = false;
                dateTimePickerMaxDate.Enabled = false;
                dateTimePickerMinDate.Enabled = false;
            }

            if (comboBoxFilterMethod.Text.ToLower() == "all")
            {
                this.filterMethod = FilterMethod.all;
                //enable controls
                comboBoxProject.Enabled = true;
                comboBoxChecks.Enabled = true;
                dateTimePickerMaxDate.Enabled = true;
                dateTimePickerMinDate.Enabled = true;
            }
        }
    }
}
