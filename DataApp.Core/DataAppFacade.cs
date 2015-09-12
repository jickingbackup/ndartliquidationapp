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
    public class DataAppFacade
    {
        public IUserController UserController { get; set; }

        public DataAppFacade()
        {
            this.UserController = ControllerFactory.CreateIUserController();

            Seed();
        }

        private void Seed()
        {
            //set default data here
            User rootUser = new User() { Id = 999, IsActive = true, Username = "root", Password = "toor", Token = "" };

            if (this.UserController.Get(rootUser.Id) == null)
                this.UserController.Add(rootUser);


        }
    }
}
