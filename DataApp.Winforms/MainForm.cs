using DataApp.Core;
using DataApp.Core.Models;
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
    public partial class MainForm : Form
    {
        private User currentUser = null;
        private DataAppCore dataAppCore = null;

        //child forms
        ProjectsForm projectForm = null;
        ExpensesForm expensesForm = null;

        public MainForm()
        {
            InitializeComponent();
            this.dataAppCore = DataAppFactory.Create();
        }

        #region CUSTOM CODE
        
        private void SignOutUser()
        {
            if (currentUser == null)
                return;

            this.dataAppCore.UserController.Logout(currentUser.Id);
            this.currentUser = null;

            //clear all mdi children
        }

        private void DisplayLoginForm()
        {
            if (currentUser == null)
            {
                using (var loginForm = FormFactory.CreateLoginForm(this))
                {
                    this.Hide();
                    loginForm.ShowDialog();
                }
            }
        }

        void DisplayProjectsForm()
        {
            if (projectForm == null || projectForm.IsDisposed)
            {
                this.projectForm = FormFactory.CreateProjectsForm(this);
                projectForm.MdiParent = this;
            }
            projectForm.Show();
        }

        void DisplayExpensesForm()
        {
            if (expensesForm == null || expensesForm.IsDisposed)
            {
                this.expensesForm = FormFactory.CreateExpensesForm(this);
                expensesForm.MdiParent = this;
            }
            expensesForm.Show();
        }

        void HideAllForm()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }
        }

        //ExpensesForm
        #endregion

        #region EVENTS
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayLoginForm();
        }

        private void lognoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignOutUser();
            DisplayLoginForm();
        } 
        #endregion


        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForm();
            DisplayProjectsForm();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForm();
            DisplayExpensesForm();
        }
    }
}
