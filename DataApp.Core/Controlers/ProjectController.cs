using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Controlers
{
    /// <summary>
    /// Congcrete controller for project.
    /// Attach navigation properties.
    /// </summary>
    class ProjectController: AbstractController<Project>
    {
        private IController<Expense> expensesController = ControllerFactory.CreateExpenseController();

        public ProjectController(string collectioname,LiteDB.LiteDatabase dbContext)
            :base(collectioname,dbContext)
        {

        }

        public override Project Get(object id)
        {
            try
            {
                var project = base.Get(id);
                project.Expenses = expensesController.Get().Where(x => x.ProjectId == project.Id);
                return project;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public override IEnumerable<Project> Get()
        {
            try
            {
                var projects = base.Get();
                foreach (var project in projects)
                {
                    project.Expenses = expensesController.Get().Where(x => x.ProjectId == project.Id);

                }
                return projects;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
