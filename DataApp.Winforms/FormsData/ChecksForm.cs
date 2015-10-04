using DataApp.Core;
using DataApp.Core.Models;
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
    public partial class ChecksForm : Form
    {
        MainForm mainform = null;
        DataAppCore db = null;
        Check currentCheck = null; 

        public ChecksForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
            db = mainform.DataAppCore;
            currentCheck = new Check();
            //set data grid settings
            ControlFactory.SetDataGridSettings(this.dataGridView1);
        }

        #region CUSTOM CODE

        #region SEARCH
        void LoadDataToGrid(string message = null)
        {
            //TODO: check filters
            int checkID = Convert.ToInt32(numericUpDownId.Value);
            bool includeHiddenChecks = checkBoxIncludeHidden.Checked;
            string voucher = textBoxFilterName.Text;


            var rawDataList = db.CheckController.Get().ToList();

            if (checkID > 0)
            {
                rawDataList = rawDataList.Where(x => x.Id == checkID).ToList();
            }

            if (String.IsNullOrEmpty(voucher) == false)
            {
                voucher = voucher.ToLower();
                rawDataList = rawDataList.Where(x => x.VoucherNumber.ToLower() == voucher).ToList();
            }

            if (includeHiddenChecks == false)
            {
                rawDataList = rawDataList.Where(x => x.IsHidden == false).ToList();
            }

            List<CheckViewModel> result = new List<CheckViewModel>();

            foreach (var item in rawDataList)
            {
                result.Add(new CheckViewModel(item));
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
            this.textBoxFilterName.Text = "";
            this.numericUpDownId.Value = 0;
            this.numericUpDownMaxRow.Value = 100;
            this.checkBoxIncludeHidden.Checked = false;


        }

        #endregion

        #region UPDATE

        void ResetDetailsPane()
        {
            //textBoxDetailsDescription.Text = "";
            //numericUpDownDetailsID.Value = 0;
            //textBoxDetailsDescription.Text = "";
            //textBoxDetailsName.Text = "";
            numericUpDownDetailsID.Value = 0;
            textBoxVoucherNumber.Text = "";
            numericUpDownAmount.Value = 0;
            dateTimePickerIssuedOn.Value = DateTime.Now;


            currentCheck = new Check();

            buttonDetailsUpdate.Enabled = false;
            buttonDetailsDelete.Enabled = false;
            buttonDetailsAdd.Enabled = true;
        }

        void MapObjectToControls()
        {
            if (currentCheck != null)
            {
                numericUpDownDetailsID.Value = currentCheck.Id;
                textBoxVoucherNumber.Text = currentCheck.VoucherNumber;
                numericUpDownAmount.Value = currentCheck.Amount;
                dateTimePickerIssuedOn.Value = currentCheck.IssueDate;
            }
        }

        void MapControlsToObject()
        {
            currentCheck.Id = Convert.ToInt32(numericUpDownDetailsID.Value);
            currentCheck.VoucherNumber = textBoxVoucherNumber.Text;
            currentCheck.Amount = numericUpDownAmount.Value;
            currentCheck.IssueDate = dateTimePickerIssuedOn.Value;
        }


        private void TogleUpdateButtons()
        {
            if (tabControl1.SelectedTab.Name == "tabPageDetails")
            {
                if (currentCheck.Id == 0)
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
                    currentCheck = new Check();

                //map controls to object
                MapControlsToObject();

                //validate
                if (string.IsNullOrEmpty(currentCheck.VoucherNumber) || currentCheck.Amount == 0 || currentCheck.IssueDate == null)
                {
                    MessageBox.Show("Please check empty input fields.");
                    return;
                }

                bool result = false;

                if (isUpdate == false)
                    result = db.CheckController.Add(currentCheck);
                else
                    result = db.CheckController.Update(currentCheck);

                if (result)
                {
                    if (isUpdate == false)
                        currentCheck = db.CheckController.Get(currentCheck.Id);

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
            if (currentCheck != null)
                currentCheck.IsHidden = true;

            if (db.CheckController.Update(currentCheck))
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
                this.currentCheck = db.CheckController.Get(selectedRowId);

                MapObjectToControls();
                tabControl1.SelectedIndex = 1;
            }
        }
        #endregion

        #endregion

        #region EVENTS

        #region SEARCH
        private void ChecksForm_Load(object sender, EventArgs e)
        {
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
