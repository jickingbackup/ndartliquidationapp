using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public bool IsHidden { get; set; }

        //Navigation Properties
        [BsonIgnoreAttribute]
        public IEnumerable<Expense> Expenses { get; set; }
        
    }
}
