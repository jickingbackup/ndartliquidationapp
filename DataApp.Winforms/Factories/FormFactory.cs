using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    public class FormFactory
    {
        public static LoginForm CreateLoginForm(MainForm form)
        {
            return new LoginForm(form) { 
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                ShowInTaskbar = false,
                ShowIcon = false,
                ControlBox=false,
                Text = "USER LOGIN"
            };
        }

        public static MainForm CreateMainForm()
        {
            return new MainForm(){
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                Text = "EXPENSE TRACKER"
            };
        }

        public static ProjectsForm CreateProjectsForm(MainForm form)
        {
            return new ProjectsForm(form)
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                ShowInTaskbar = false,
                ShowIcon = false,
                ControlBox = false,
                WindowState=System.Windows.Forms.FormWindowState.Maximized,
                Text = "PROJECTS"
            };
        }

        public static ExpensesForm CreateExpensesForm(MainForm form)
        {
            return new ExpensesForm(form)
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                ShowInTaskbar = false,
                ShowIcon = false,
                ControlBox = false,
                WindowState = System.Windows.Forms.FormWindowState.Maximized,
                Text = "EXPENSES"
            };
        }

        public static ChecksForm CreateChecksForm(MainForm form)
        {
            return new ChecksForm(form)
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                ShowInTaskbar = false,
                ShowIcon = false,
                ControlBox = false,
                WindowState = System.Windows.Forms.FormWindowState.Maximized,
                Text = "CHECKS"
            };
        }

        public static CompaniesForm CreateCompaniesForm(MainForm form)
        {
            return new CompaniesForm(form)
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                ShowInTaskbar = false,
                ShowIcon = false,
                ControlBox = false,
                WindowState = System.Windows.Forms.FormWindowState.Maximized,
                Text="COMPANIES"
            };
        }

        public static ExpenseReportsForm CreateExpenseReportsForm(MainForm form)
        {
            return new ExpenseReportsForm()
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen,
                ShowInTaskbar = false,
                ShowIcon = false,
                ControlBox = false,
                WindowState = System.Windows.Forms.FormWindowState.Maximized,
                Text = "COMPANIES"
            };
        }

        public static void SetDataForm(Form form)
        {

        }
    }
}
