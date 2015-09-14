using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.ViewModels.DataGridViewModels
{
    public class ProjectViewModel
    {
        private Project project = null;

        public int Id { get { return project.Id; } }
        public string Name { get { return project.Name; } }
        public string Description { get { return project.Description; } }
        public string Hidden { get { return project.IsHidden ? "yes" : "no"; } }
        

        public ProjectViewModel(Project project)
        {
            this.project = project;
        }

    }
}
