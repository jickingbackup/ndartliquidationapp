using DataApp.Core.Abstracts;
using DataApp.Core.Controlers;
using DataApp.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Factories
{
    public class ControllerFactory
    {
        private LiteDatabase db = null;

        public ControllerFactory(string dbpath =null)
        {
            if (String.IsNullOrEmpty(dbpath) == false)
                this.db = DbContextFactory.CreateLiteDBContext(dbpath);
            else
                this.db = DbContextFactory.CreateLiteDBContext();
        }
        
        public IUserController CreateIUserController()
        {
            return new UserController("users",db);
        }

        public IController<Check> CreateCheckController()
        {
            return new CheckController("checks", db);
        }

        public IController<Company> CreateCompanyController()
        {
            return new CompanyController("companies", db);
        }

        public IController<Expense> CreateExpenseController()
        {
            return new ExpenseController("expenses", db);
        }

        public IController<Project> CreateProjectController()
        {
            return new ProjectController("projects", db);
        }

    }
}
