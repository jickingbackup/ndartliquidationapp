using DataApp.Core.Abstracts;
using DataApp.Core.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Factories
{
    public class ControllerFactory
    {
        public static IUserController CreateIUserController()
        {
            return new UserController();
        }
    }
}
