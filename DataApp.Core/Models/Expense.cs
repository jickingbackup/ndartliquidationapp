﻿using LiteDB;
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
        public string CompanyName { get; set; }        
        public string Description { get; set; }
        public decimal Amount{ get; set; }
        public DateTime Date{ get; set; }
        public bool IsHidden{ get; set; }
        public Category ExpenseCategory { get; set; }

        //relations
        public int CheckId { get; set; }
        public int ProjectId { get; set; }

        //Navigation Properties
        [BsonIgnoreAttribute]
        public Check Check { get; set; }
        
        [BsonIgnoreAttribute]
        public Project Project { get; set; }

        public enum Category
        {
            Communication,
            Representation,
            Transportation,
            Fuel,
            OfficeSupplies,
            OfficeEquipments,
            Rental,
            ManPower,
            Materials,
            CashAdvance,
            Commission,
            ToolsAndEquipments,
            MISC
        }
    }


}
