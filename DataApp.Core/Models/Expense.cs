using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Models
{
    public class Expense
    {
        public int Id{ get; set; }
        public string ORNUmber { get; set; }
        public string Description { get; set; }
        public decimal Amount{ get; set; }
        public DateTime Date{ get; set; }
        public bool IsHidden{ get; set; }


        //relations
        public int CheckId { get; set; }
        public int CompanyId { get; set; }
        public int ProjectId { get; set; }

        public Check Check { get; set; }
        public Company Company { get; set; }
        public Project Project { get; set; }
    }
}
