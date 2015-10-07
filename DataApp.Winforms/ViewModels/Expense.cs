using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidationApp.ViewModels
{
    //Maps and displays an Expense
    public class ExpenseVM
    {
        public string CompanyName { get; set; }
        public string ORNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public String ExpenseCategory { get; set; }

        public virtual String Project { get; set; }
        public virtual String Check { get; set; }


        public void InjectVM(LiquidationLib.Expense expense)
        {
            this.CompanyName = expense.CompanyName;
            this.ORNumber = expense.ORNumber;
            this.Description = expense.Description;
            this.Amount = expense.Amount;
            this.Date = expense.Date.ToShortDateString();
            this.Project = expense.Project.Name;
            this.Check = expense.Check.VoucherNumber;

            switch (expense.ExpenseCategory)
            {
                case LiquidationLib.Category.Communication:
                    this.ExpenseCategory = "Comunication";
                    break;
                case LiquidationLib.Category.Representation:
                    this.ExpenseCategory = "Representation";
                    break;
                case LiquidationLib.Category.Transportation:
                    this.ExpenseCategory = "Transportation";
                    break;
                case LiquidationLib.Category.Fuel:
                    this.ExpenseCategory = "Fuel";
                    break;
                case LiquidationLib.Category.OfficeSupplies:
                    this.ExpenseCategory = "OfficeSupplies";
                    break;
                case LiquidationLib.Category.OfficeEquipments:
                    this.ExpenseCategory = "OfficeEquipments";
                    break;
                case LiquidationLib.Category.Rental:
                    this.ExpenseCategory = "Rental";
                    break;
                case LiquidationLib.Category.ManPower:
                    this.ExpenseCategory = "ManPower";
                    break;
                case LiquidationLib.Category.Materials:
                    this.ExpenseCategory = "Materials";
                    break;
                case LiquidationLib.Category.CashAdvance:
                    this.ExpenseCategory = "CashAdvance";
                    break;
                case LiquidationLib.Category.Commission:
                    this.ExpenseCategory = "Commission";
                    break;
                case LiquidationLib.Category.ToolsAndEquipments:
                    this.ExpenseCategory = "ToolsAndEquipments";
                    break;
                case LiquidationLib.Category.MISC:
                    this.ExpenseCategory = "MISC";
                    break;
                default:
                    this.ExpenseCategory = "MSC";
                    break;
            }
        }
    }
}
