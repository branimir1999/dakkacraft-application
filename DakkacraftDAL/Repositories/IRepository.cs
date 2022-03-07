using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftDAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetEntities();
        TEntity GetEntityById(int entityId);
        void AddEntity(TEntity entity);
        void RemoveEntity(TEntity entity);
        void Save();
    }
}
