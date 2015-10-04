using LiteDB;
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
        public bool IsHidden{ get; set; }
        public DateTime IssueDate { get; set; }

        [BsonIgnoreAttribute]
        public IEnumerable<Expense> Expenses { get; set; }
        
    }
}
