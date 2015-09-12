using DataApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new DataAppFacade("xxx.db");

            foreach (var item in x.UserController.Get())
            {
                Console.WriteLine("{0} - {1}", item.Username, item.Password);
            }

            foreach (var item in x.CheckController.Get())
            {
                Console.WriteLine("{0} - {1}", item.IssuedOn.ToShortDateString(), item.VoucherNumber);
            }

            foreach (var item in x.CompanyController.Get())
            {
                Console.WriteLine("{0} - {1}", item.Name, item.Description);
            }

            foreach (var item in x.ExpenseController.Get())
            {
                Console.WriteLine("{0} - {1}", item.Date.ToShortDateString(), item.Description);
            }

            foreach (var item in x.ProjectController.Get())
            {
                Console.WriteLine("{0} - {1}", item.Name, item.Description);
            }

            Console.Read();
        }
    }
}
