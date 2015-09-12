using DataApp.Core.Abstracts;
using DataApp.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Controlers
{
    class ExpenseController:AbstractController<Expense>
    {
        //private IController<Check> checksController = null;
        //private IController<Company> companyController = null;
        //private IController<Project> projectController = null;
        

        public ExpenseController(string collectionName , LiteDatabase dbcontext)
            :base(collectionName,dbcontext)
        {
            //this.checksController = controllerFactory.CreateCheckController();
            //this.companyController = controllerFactory.CreateCompanyController();
            //this.projectController = controllerFactory.CreateProjectController();
        }

        //public override IEnumerable<Expense> Get()
        //{
        //    try
        //    {
        //        var expenses = base.Get();

        //        foreach (var expense in expenses)
        //        {
        //            expense.Check = checksController.Get(expense.CheckId);
        //            expense.Company = companyController.Get(expense.CompanyId);
        //            expense.Project = projectController.Get(expense.ProjectId);
        //        }

        //        return expenses;
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
        //}

        //public override Expense Get(object id)
        //{
        //    try
        //    {
        //        var expense = base.Get(id);
        //        expense.Check = checksController.Get(expense.CheckId);
        //        expense.Company = companyController.Get(expense.CompanyId);
        //        expense.Project = projectController.Get(expense.ProjectId);
        //        return expense;
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
        //} 
    }
}

