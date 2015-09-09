using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Wpf
{
    public class ViewFactory
    {
        public ViewInfrastructure Create()
        {
            User model = new User();
            ViewModel viewModel = new ViewModel(model);
            View view = new View();

            return new ViewInfrastructure(view, viewModel, model);
        }
    }
}
