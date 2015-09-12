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
            var x = new DataAppCore("xxx.db");

            foreach (var item in x.UserController.Get())
            {
                Console.WriteLine("USER: {0} - {1}", item.Username, item.Password);
            }

            foreach (var item in x.CheckController.Get())
            {
                Console.WriteLine("CHECKS: {0} - {1}", item.IssuedOn.ToShortDateString(), item.VoucherNumber);
            }

            foreach (var item in x.CompanyController.Get())
            {
                Console.WriteLine("COMPANY: {0} - {1}", item.Name, item.Description);
            }

            foreach (var item in x.ExpenseController.Get())
            {
                Console.WriteLine("EXPENSE {0} - {1}", item.Date.ToShortDateString(), item.Description);
            }


            Console.Read();
        }
    }
}
