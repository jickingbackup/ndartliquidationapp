using DataApp.Core.Abstracts;
using DataApp.Core.Controlers;
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
            return new UserController("user",db);
        }
    }
}
