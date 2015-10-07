using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.ViewModels.DataGridViewModels
{
    public class CheckViewModel
    {
        Check check = null;

        public CheckViewModel(Check check)
        {
            this.check = check;
        }

        public int Id { get { return check.Id; } }
        public String VoucherNumber { get { return check.VoucherNumber; } }
        public Decimal Amount { get { return check.Amount; } }
        public String IsHidden { get { return check.IsHidden.ToString(); } }
        public DateTime IssueDate { get { return check.IssueDate; } }
    }
}
