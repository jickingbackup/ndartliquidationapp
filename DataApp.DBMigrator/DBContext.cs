
namespace DataApp.DBMigrator
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class DAL : IDisposable
    {
        NDARTDBContext context = null;

        public IRepository<Project> Projects { get { return new AbstractRepository<Project>(context); } }
        public IRepository<Check> Checks { get { return new AbstractRepository<Check>(context); } }
        public IRepository<Expense> Expenses { get { return new AbstractRepository<Expense>(context); } }

        public DAL()
        {
            this.context = new NDARTDBContext();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }


    public class NDARTDBContext : DbContext, IDisposable
    {
        public NDARTDBContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Check> Checks { get; set; }



        #region IDisposable Members

        void IDisposable.Dispose()
        {
            base.Dispose();
        }

        #endregion
    }


    public class Entity
    {
        public int ID { get; set; }
        public bool IsHidden { get; set; }
    }

    public class Project : Entity
    {
        public String Name { get; set; }

        public virtual IEnumerable<Expense> Expenses { get; set; }


    }

    public class Expense : Entity
    {
        public string CompanyName { get; set; }
        public string ORNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Category ExpenseCategory { get; set; }

        public virtual Project Project { get; set; }
        public virtual Check Check { get; set; }

    }

    public class Check : Entity
    {
        public decimal Amount { get; set; }
        public string VoucherNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public virtual IEnumerable<Expense> Expenses { get; set; }
    }


    public enum Category
    {
        Communication, Representation, Transportation, Fuel, OfficeSupplies, OfficeEquipments, Rental, ManPower, Materials, CashAdvance, Commission, ToolsAndEquipments, MISC
    }

    public interface IRepository<T> : IDisposable
    {
        //T GetByID(object id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }

    internal class AbstractRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected NDARTDBContext dbContext = null;

        public AbstractRepository()
        {
            NDARTDBContext dbContext = new NDARTDBContext();
            this.dbContext = dbContext;
        }

        public AbstractRepository(NDARTDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region IRepository<T> Members

        public virtual TEntity GetByID(object id)
        {
            try
            {
                var entity = this.dbContext.Set<TEntity>().Find();
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            try
            {
                IQueryable<TEntity> entities = this.dbContext.Set<TEntity>();

                if (filter != null)
                {
                    entities = entities.Where(filter);
                }

                return entities.ToList();
            }
            catch
            {
                throw;
            }
        }

        public virtual bool Add(TEntity entity)
        {
            bool isSuccess = false;

            try
            {
                dbContext.Set<TEntity>().Add(entity);
                dbContext.SaveChanges();
                isSuccess = true;
            }
            catch
            {
                throw;
            }

            return isSuccess;
        }

        public virtual bool Update(TEntity entity)
        {
            bool isSuccess = false;

            try
            {
                this.dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                this.dbContext.SaveChanges();
                isSuccess = true;
            }
            catch
            {
                throw;
            }

            return isSuccess;
        }

        public virtual bool Delete(TEntity entity)
        {
            bool isSuccess = false;

            try
            {
                this.dbContext.Set<TEntity>().Remove(entity);
                this.dbContext.SaveChanges();
                isSuccess = true;
            }
            catch
            {
                throw;
            }

            return isSuccess;
        }

        #endregion

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }

}
