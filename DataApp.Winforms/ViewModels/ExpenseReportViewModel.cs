using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms
{
    public class ExpenseReportViewModel
    {
        Expense expense = null;
        public ExpenseReportViewModel(Expense data)
        {
            this.expense = data;
        }

        public DateTime Date { get { return this.expense.Date; } }
        public String ORNumber { get { return this.expense.ORNUmber; } }
        public String Company { get { return this.expense.CompanyName; } }
        public String Category { get { return this.expense.ExpenseCategory.ToString(); } }
        public Decimal Ammount { get { return this.expense.Amount; } }

    }
}
