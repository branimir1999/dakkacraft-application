using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftDAL.Repositories
{
    // https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public void AddEntity(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            //throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetEntities()
        {
            return Context.Set<TEntity>().ToList();
            //throw new NotImplementedException();
        }

        public TEntity GetEntityById(int entityId)
        {
            return Context.Set<TEntity>().Find(entityId);
            //throw new NotImplementedException();
        }

        public void RemoveEntity(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            //throw new NotImplementedException();
        }
        public void Save()
        {
            Context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
            //throw new NotImplementedException();
        }


        // Is this necessary?
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
