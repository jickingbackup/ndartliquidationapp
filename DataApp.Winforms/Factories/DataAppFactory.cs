using DataApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms
{
    static class DataAppFactory
    {
        public static DataAppFacade Create()
        {
            return new DataAppFacade();
        }
    }
}
