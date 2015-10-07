using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.ViewModels.DataGridViewModels
{
    public class ExpenseViewModel
    {
        Expense expense = null;
        public ExpenseViewModel(Expense expense)
        {
            this.expense = expense;
        }

        public int Id { get { return expense.Id; } }
        public string ORNUmber { get { return expense.ORNUmber; } }
        public string CompanyName { get { return expense.CompanyName; } }
        public string Description { get { return expense.Description; } }
        public decimal Amount { get { return expense.Amount; } }
        public DateTime Date { get { return expense.Date; } }
        public string IsHidden { get { return expense.IsHidden.ToString(); } }
        public string Category { get { return expense.ExpenseCategory.ToString(); } }

        public string CheckVoucher { get { return expense.Check.VoucherNumber; } }
        public string Project { get { return expense.Project.Name; } }
    }
}
