using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Abstracts
{
    internal abstract class AbstractController<T> : IController<T> where T : class,new()
    {
        protected string collectionName = string.Empty;
        protected LiteDatabase db = null;
        protected LiteCollection<T> collection = null;

        public AbstractController( string collectionName, LiteDatabase dbcontext )
        {
            this.collectionName = collectionName;
            db = dbcontext;
            collection = db.GetCollection<T>(collectionName);
        }

        #region IController
        /// <summary>
        /// TODO: add checking|validation on child classes
        /// </summary>
        public virtual bool Add(T entity)
        {
            try
            {
                if (this.collection.Insert(entity) != null)
                    return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// TODO: add checking|validation on child classes
        /// </summary>
        public virtual bool Delete(object id)
        {
            try
            {
                if(this.collection.Delete(Query.EQ("Id", (int)id)) > 0)
                    return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// TODO: add checking|validation on child classes
        /// </summary>
        public virtual bool Update(T entity)
        {
            try
            {
                return this.collection.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region READ
        public virtual List<T> Get()
        {
            try
            {
                List<T> result = new List<T>();

                foreach (var item in this.collection.FindAll())
                {
                    result.Add(item);
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T Get(object id)
        {
            try
            {
                return collection.FindOne(Query.EQ("Id", (int)id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #endregion

    }
}
