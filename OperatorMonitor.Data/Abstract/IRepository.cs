using OperatorMonitor.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OperatorMonitor.Data.Abstract
{
    public interface IRepository<TEntity>
        where TEntity:IEntity
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity Get(int entityId);
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(int entityId);
    }
}
