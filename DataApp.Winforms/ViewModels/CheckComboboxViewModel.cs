using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.ViewModels
{
    public class CheckComboboxViewModel
    {
        Check check = null;

        public CheckComboboxViewModel(Check check)
        {
            this.check = check;
        }

        public int Id { get { return check.Id; } }
        public string Name { get { return string.Format("Voucher# {1} [Php {2}] {3}", check.Id,check.VoucherNumber,check.Amount,check.IssueDate.ToShortDateString()); } }
    }
}
