using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace DataApp.DBMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NDARTDBContext())
            {
                int projectInserts = 0;
                int checkstInserts = 0;
                int expensestInserts = 0;
                
                var projects = db.Projects.ToList();
                var checks = db.Checks.ToList();
                var expenses= db.Expense.ToList();

                //CONVERT DATA
                List<DataApp.Core.Models.Project> newProjects = new List<Core.Models.Project>();
                List<DataApp.Core.Models.Check> newChecks = new List<Core.Models.Check>();
                List<DataApp.Core.Models.Expense> newExpenses = new List<Core.Models.Expense>();

                //MAP PROJECTS
                foreach (var item in projects)
                {
                    var p = new DataApp.Core.Models.Project();
                    p.Id = item.ID;
                    p.IsHidden = item.IsHidden;
                    p.Name = item.Name;

                    newProjects.Add(p);
                }

                //MAP CHECKS
                foreach (var item in checks)
                {
                    var c = new DataApp.Core.Models.Check();
                    c.Amount = item.Amount;
                    c.Id = item.ID;
                    c.IsHidden = item.IsHidden;
                    c.IssueDate = item.IssueDate;
                    c.VoucherNumber = item.VoucherNumber;

                    newChecks.Add(c);
                }

                //MAP EXPENSES
                foreach (var i in expenses)
                {
                    var e = new DataApp.Core.Models.Expense();
                    e.Amount = i.Amount;
                    e.CheckId = i.Check.ID;
                    e.CompanyName = i.CompanyName;
                    e.Date = i.Date;
                    e.Description = i.Description;
                    e.Id = i.ID;
                    e.IsHidden = i.IsHidden;
                    e.ORNUmber = i.ORNumber;
                    e.ProjectId = i.Project.ID;

                    DataApp.Core.Models.Expense.Category temp = DataApp.Core.Models.Expense.Category.MISC;
                    Enum.TryParse<DataApp.Core.Models.Expense.Category>(i.ExpenseCategory.ToString(), true, out temp);
                    e.ExpenseCategory = temp;

                    newExpenses.Add(e);
                }

                Console.WriteLine("projects: {0}", projects.Count);
                Console.WriteLine("checks: {0}", checks.Count);
                Console.WriteLine("expenses: {0}", expenses.Count);

                Console.WriteLine("Inserting data ...");

                //INSERT DATA
                var litedb = new DataApp.Core.DataAppCore();

                foreach (var i in newProjects)
                {
                    //i.Id = 0;
                    litedb.ProjectController.Add(i);

                    projectInserts++;
                }

                foreach (var i in newChecks)
                {
                    litedb.CheckController.Add(i);
                    checkstInserts++;
                }

                foreach (var i in newExpenses)
                {
                    litedb.ExpenseController.Add(i);
                    expensestInserts++;
                }

                Console.WriteLine("Project inserts : {0}", projectInserts);
                Console.WriteLine("Checks inserts : {0}", checkstInserts);
                Console.WriteLine("Expense inserts : {0}", expensestInserts);
            }

            //end
            Console.ReadLine();
        }
    }
}
