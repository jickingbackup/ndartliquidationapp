using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core
{
    public class DataAppFacade
    {
        public IUserController UserController { get; set; }

        public DataAppFacade()
        {
            this.UserController = ControllerFactory.CreateIUserController();
        }
    }
}
