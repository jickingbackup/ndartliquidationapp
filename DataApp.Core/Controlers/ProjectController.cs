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

    class ProjectController: AbstractController<Project>
    {
        public ProjectController(string collectioname,LiteDB.LiteDatabase dbContext)
            :base(collectioname,dbContext)
        {
        }

        public override Project Get(object id)
        {
            try
            {
                var project = base.Get(id);

                if (project != null)
                {
                    project.Expenses = this.db.GetCollection<Expense>("expenses").FindAll().Where(x => x.ProjectId == project.Id);
                    if (project.Expenses == null)
                        project.Expenses = new List<Expense>();

                }

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
                    project.Expenses = this.db.GetCollection<Expense>("expenses").FindAll().Where(x => x.ProjectId == project.Id);
                    if (project.Expenses == null)
                        project.Expenses = new List<Expense>();
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
