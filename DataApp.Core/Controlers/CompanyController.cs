using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Controlers
{
    class CompanyController:AbstractController<Company>
    {
        //private IController<Check> checksController = null;
        //private IController<Expense> expensesController = null;


        public CompanyController(string collectionName , LiteDatabase dbcontext)
            :base(collectionName,dbcontext)
        {
            //checksController = controllerFactory.CreateCheckController();
            //expensesController = controllerFactory.CreateExpenseController();                
        }

        //public override IEnumerable<Company> Get()
        //{
        //    try
        //    {
        //        var companies = base.Get();

        //        foreach (var company in companies)
        //        {
        //            company.Checks = checksController.Get().Where(x => x.CompanyId == company.Id);
        //            company.Expenses = expensesController.Get().Where(x => x.CompanyId == company.Id);
        //        }

        //        return companies;
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
        //}

        //public override Company Get(object id)
        //{
        //    try
        //    {
        //        var company = base.Get(id);

        //        company.Checks = checksController.Get().Where(x => x.CompanyId == company.Id);
        //        company.Expenses = expensesController.Get().Where(x => x.CompanyId == company.Id);
 
        //        return company;
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
        //}

    }
}
