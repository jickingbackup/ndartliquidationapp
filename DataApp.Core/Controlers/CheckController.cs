﻿using DataApp.Core.Abstracts;
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
    class CheckController:AbstractController<Check>
    {
        public CheckController(string collectionName , LiteDatabase dbcontext)
            :base(collectionName,dbcontext)
        {
        }

        public override IEnumerable<Check> Get()
        {
            try
            {
                var checks = base.Get();

                foreach (var check in checks)
                {
                    check.Expenses = this.db.GetCollection<Expense>("expenses").FindAll().Where(x => x.CheckId == check.Id);

                    if (check.Expenses == null)
                        check.Expenses = new List<Expense>();
                }

                return checks;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Check Get(object id)
        {
            try
            {
                var check = base.Get(id);

                if(check != null)
                {
                    check.Expenses = this.db.GetCollection<Expense>("expenses").FindAll().Where(x => x.CheckId == check.Id);

                    if (check.Expenses == null)
                        check.Expenses = new List<Expense>();
                }

                return check;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
