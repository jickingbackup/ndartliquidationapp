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
    class CheckController:AbstractController<Check>
    {
        private IController<Company> companyController = ControllerFactory.CreateCompanyController();
        private IController<Expense> expensesController = ControllerFactory.CreateExpenseController();

        public CheckController(string collectionName , LiteDatabase dbcontext)
            :base(collectionName,dbcontext)
        {
            companyController = ControllerFactory.CreateCompanyController();
            expensesController = ControllerFactory.CreateExpenseController();
        }

        public override IEnumerable<Check> Get()
        {
            try
            {
                var checks = base.Get();

                foreach (var item in checks)
                {
                    item.Company = companyController.Get(item.Id);
                    item.Expenses = expensesController.Get().Where(x => x.CheckId == item.Id);
                }

                return checks;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public override Check Get(object id)
        {
            try
            {
                var check = base.Get(id);                
                check.Company = companyController.Get(check.CompanyId);
                check.Expenses = expensesController.Get().Where(x => x.CheckId == check.Id);
                return check;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
