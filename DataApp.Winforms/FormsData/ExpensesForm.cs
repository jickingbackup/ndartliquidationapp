using DataApp.Core;
using DataApp.Core.Models;
using DataApp.Winforms.ViewModels;
using DataApp.Winforms.ViewModels.DataGridViewModels;
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
    public partial class ExpensesForm : Form
    {
        MainForm mainform = null;
        DataAppCore db = null;
        Expense currentExpense = null; 

        public ExpensesForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
            currentExpense = new Expense();
            //set data grid settings
            ControlFactory.SetDataGridSettings(this.dataGridView1);
        }

        #region CUSTOM CODE

        private void InitializeComboboxes()
        {
            comboBoxDetailsProject.ValueMember = "Id";
            comboBoxDetailsProject.DisplayMember = "Name";
            comboBoxDetailsProject.DataSource = db.ProjectController.Get().ToList();

            List<CheckComboboxViewModel> checkComboData = new List<CheckComboboxViewModel>();

            foreach (var i in db.CheckController.Get())
            {
                checkComboData.Add(new CheckComboboxViewModel(i));
            }

            comboBoxDetailsCheck.ValueMember = "Id";
            comboBoxDetailsCheck.DisplayMember = "Name";
            comboBoxDetailsCheck.DataSource = checkComboData;

            List<string> categories = new List<string>() {            
                "Communication",
            "Representation",
            "Transportation",
            "Fuel",
            "OfficeSupplies",
            "OfficeEquipments",
            "Rental",
            "ManPower",
            "Materials",
            "CashAdvance",
            "Commission",
            "ToolsAndEquipments",
            "MISC" };
            comboBoxDetailsCategory.DataSource = categories;
        }

        #region SEARCH
        void LoadDataToGrid(string message = null)
        {
            //TODO: check filters
            int projectID = Convert.ToInt32(numericUpDownId.Value);
            bool includeHiddenProjects = checkBoxIncludeHidden.Checked;
            //string projectName = textBoxFilterName.Text;


            var rawDataList = db.ExpenseController.Get().ToList();

            if (projectID > 0)
            {
                rawDataList = rawDataList.Where(x => x.Id == projectID).ToList();
            }

            //if (String.IsNullOrEmpty(projectName) == false)
            //{
            //    projectName = projectName.ToLower();
            //    rawDataList = rawDataList.Where(x => x.ORNUmber.ToLower() == projectName).ToList();
            //}

            if (includeHiddenProjects == false)
            {
                rawDataList = rawDataList.Where(x => x.IsHidden == false).ToList();
            }

            List<ExpenseViewModel> result = new List<ExpenseViewModel>();

            foreach (var item in rawDataList)
            {
                result.Add(new ExpenseViewModel(item));
            }

            dataGridView1.DataSource = result;

            if (message != null)
            {
                mainform.WriteStatusBar(message);
                return;
            }
            mainform.WriteStatusBar(String.Format("Total Rows : {0}", result.Count));
        }

        void ResetSearchFilters()
        {
            //this.textBoxFilterName.Text = "";
            this.numericUpDownId.Value = 0;
            this.checkBoxIncludeHidden.Checked = false;


        }

        #endregion

        #region UPDATE

        void ResetDetailsPane()
        {
            textBoxDetailsDescription.Text = "";
            numericUpDownDetailsID.Value = 0;
            textBoxDetailsDescription.Text = "";
            textBoxDetailsORNumber.Text = "";

            currentExpense = new Expense();

            buttonDetailsUpdate.Enabled = false;
            buttonDetailsDelete.Enabled = false;
            buttonDetailsAdd.Enabled = true;
        }

        void MapObjectToControls()
        {
            if (currentExpense != null)
            {
                numericUpDownDetailsID.Value = currentExpense.Id;
                textBoxDetailsORNumber.Text = currentExpense.ORNUmber;
                textBoxDetailsDescription.Text = currentExpense.Description;
                textBoxDetailsCompany.Text = currentExpense.CompanyName;
                numericUpDownDetailsAmount.Value = currentExpense.Amount;
                dateTimePickerDetailsDate.Value = currentExpense.Date;
                comboBoxDetailsProject.SelectedValue = currentExpense.ProjectId;
                comboBoxDetailsCheck.SelectedValue = currentExpense.CheckId;
                comboBoxDetailsCategory.SelectedItem = currentExpense.ExpenseCategory.ToString();
            }
        }

        void MapControlsToObject()
        {
            currentExpense.Id = Convert.ToInt32(numericUpDownDetailsID.Value);
            currentExpense.ORNUmber = textBoxDetailsORNumber.Text;
        }


        private void TogleUpdateButtons()
        {
            if (tabControl1.SelectedTab.Name == "tabPageDetails")
            {
                if (currentExpense.Id == 0)
                {
                    buttonDetailsUpdate.Enabled = false;
                    buttonDetailsDelete.Enabled = false;
                    buttonDetailsAdd.Enabled = true;
                }
                else
                {
                    buttonDetailsUpdate.Enabled = true;
                    buttonDetailsDelete.Enabled = true;
                    buttonDetailsAdd.Enabled = false;
                }
            }
        }

        private void SaveDataToDB(bool isUpdate = false)
        {
            try
            {
                if (isUpdate == false)
                    currentExpense = new Expense();

                //map controls to object
                MapControlsToObject();

                //validate
                if (string.IsNullOrEmpty(currentExpense.ORNUmber))
                {
                    MessageBox.Show("Please check empty input fields.");
                    return;
                }

                bool result = false;

                if (isUpdate == false)
                    result = db.ExpenseController.Add(currentExpense);
                else
                    result = db.ExpenseController.Update(currentExpense);

                if (result)
                {
                    if (isUpdate == false)
                        currentExpense = db.ExpenseController.Get(currentExpense.Id);

                    //map 
                    MapObjectToControls();
                    TogleUpdateButtons();
                    mainform.WriteStatusBar("Record saved...");
                }
                else
                {
                    mainform.WriteStatusBar("Saving failed...");
                    MessageBox.Show("Saving failed...");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DeleteObject()
        {
            if (currentExpense != null)
                currentExpense.IsHidden = true;

            if (db.ExpenseController.Update(currentExpense))
                mainform.WriteStatusBar("Record saved...");
            else
                mainform.WriteStatusBar("Saving failed...");
        }

        private void EditSelectedObject()
        {
            if (this.contextMenuStripGridView.Items[0].Selected)
            {
                int selectedRowId = 0;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int.TryParse(row.Cells[0].Value.ToString(), out selectedRowId);
                }

                //fetch data
                this.currentExpense = db.ExpenseController.Get(selectedRowId);

                MapObjectToControls();
                tabControl1.SelectedIndex = 1;
            }
        }
        #endregion

        #endregion

        #region EVENTS

        #region SEARCH
        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            InitializeComboboxes();
            LoadDataToGrid();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            ResetSearchFilters();
        }

        #endregion

        #region UPDATE
        private void buttonDetailsSaveChanges_Click(object sender, EventArgs e)
        {
            SaveDataToDB();
            LoadDataToGrid("Updated Record");
        }

        private void buttonDetailsReset_Click(object sender, EventArgs e)
        {
            ResetDetailsPane();
        }

        private void buttonDetailsDelete_Click(object sender, EventArgs e)
        {
            DeleteObject();
            LoadDataToGrid("Updated Record");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TogleUpdateButtons();
        }

        private void buttonDetailsUpdate_Click(object sender, EventArgs e)
        {
            SaveDataToDB(true);
            LoadDataToGrid("Updated Record");
        }
        #endregion


        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            EditSelectedObject();
        }
        #endregion
    }
}
