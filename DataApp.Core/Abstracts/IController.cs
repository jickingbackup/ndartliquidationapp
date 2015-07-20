using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Abstracts
{
    public interface IController<T> where T : class 
    {
        T Get(object id);
        IEnumerable<T> Get();
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
