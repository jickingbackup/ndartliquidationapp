using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Controlers
{
    class UserController:IUserController
    {
        LiteDatabase db = DbContextFactory.CreateLiteDBContext();

        public User Get(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            var users = db.GetCollection<User>("user");
            return users.FindAll();
        }

        public int Add(User entity)
        {
            var users = db.GetCollection<User>("user");
            int id = 0;

            Int32.TryParse(users.Insert(entity).ToString(), out id);
            return id;
        }

        public int Update(User entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
