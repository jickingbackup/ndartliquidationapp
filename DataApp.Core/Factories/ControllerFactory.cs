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
        private static LiteDatabase db = DbContextFactory.CreateLiteDBContext();

        public static IUserController CreateIUserController()
        {
            return new UserController("users",db);
        }

        public static IController<Check> CreateCheckController()
        {
            return new CheckController("checks", db);
        }

        public static IController<Company> CreateCompanyController()
        {
            return new CompanyController("companies", db);
        }

        public static IController<Expense> CreateExpenseController()
        {
            return new ExpenseController("expenses", db);
        }

        public static IController<Project> CreateProjectController()
        {
            return new ProjectController("projects", db);
        }

    }
}
