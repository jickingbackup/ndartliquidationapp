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
        public static LiteDatabase CreateLiteDBContext()
        {
            return new LiteDatabase("testdb.db");
        }
    }
}
