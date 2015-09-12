using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public bool IsHidden { get; set; }

        //collections
        public List<Check> Checks { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
