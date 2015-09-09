using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Wpf
{
    public class ViewInfrastructure
    {
        public View View { get; private set; }

        public ViewModel ViewModel { get; private set; }

        public User Model { get; private set; }

        public ViewInfrastructure(View view, ViewModel viewModel, User model)
        {
            this.View = view;
            this.ViewModel = viewModel;
            this.Model = model;
        }
    }
}
