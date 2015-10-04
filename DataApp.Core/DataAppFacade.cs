using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core
{
    /// <summary>
    /// Data App facade.
    /// </summary>
    public class DataAppCore
    {

        public IUserController UserController { get; set; }
        public IController<Check> CheckController { get; set; }
        public IController<Expense> ExpenseController { get; set; }
        public IController<Project> ProjectController { get; set; }

        public LiteDB.LiteDatabase db = DbContextFactory.CreateLiteDBContext();

        private ControllerFactory controllerFactory = null;

        public DataAppCore(string dbpath = null)
        {
            if(string.IsNullOrEmpty(dbpath) == false)
                this.controllerFactory = new ControllerFactory(dbpath);
            else
                this.controllerFactory = new ControllerFactory();

            this.UserController = controllerFactory.CreateIUserController();
            this.CheckController = controllerFactory.CreateCheckController();
            this.ExpenseController = controllerFactory.CreateExpenseController();
            this.ProjectController = controllerFactory.CreateProjectController();

            Seed();
        }

        private void Seed()
        {
            //set default data here
            User rootUser = new User() { 
                Id = 999, 
                IsActive = true, 
                Username = "root",
                Password = "toor",
                Token = ""
            };


            

            if (this.UserController.Get(rootUser.Id) == null)
                this.UserController.Add(rootUser);

        }
    }
}
