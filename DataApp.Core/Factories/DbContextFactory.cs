using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace DataApp.Core.Factories
{
    class DbContextFactory
    {
        public static LiteDatabase CreateLiteDBContext(string filepath = null)
        {
            if(string.IsNullOrEmpty(filepath) == false)
                return new LiteDatabase(filepath);

            return new LiteDatabase("testdb.db");
        }
    }
}
