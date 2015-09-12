using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Models
{
    public class Check
    {
        public int Id { get; set; }
        public String VoucherNumber { get; set; }
        public Decimal Amount { get; set; }
        public DateTime IssuedOn{ get; set; }
        public bool IsHidden{ get; set; }

        //relations
        public int  CompanyId{ get; set; }

        public Company Company { get; set; }

        //collections
        public List<Expense> Expenses { get; set; }
        
    }
}
