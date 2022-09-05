using Microsoft.EntityFrameworkCore;
using OperatorMonitor.Data.Abstract;
using OperatorMonitor.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OperatorMonitor.Data.Concrete.EFCore
{
    public class EfRepositoryBase<TEntity, TDBContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TDBContext : DbContext, new()

    {
        private DbContext _dbContext;
        private DbSet<TEntity> _dbSet;

        public EfRepositoryBase()
        {
            _dbContext = new TDBContext();
            _dbSet = _dbContext.Set<TEntity>();
            //_dbContext.Database.Migrate();
        }
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> retVal = _dbSet.AsQueryable();

            if (filter != null) retVal.Where(filter);

            return retVal;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).FirstOrDefault();
        }

        public TEntity Get(int entityId)
        {
            return _dbSet.Find(entityId);
        }

        public bool Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return _dbContext.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(TEntity entity)
        {
            _dbSet.Remove(entity);

            return _dbContext.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(int entityId)
        {
            bool retVal = false;

            TEntity entity = Get(entityId);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                retVal = _dbContext.SaveChanges() > 0 ? true : false;
            }

            return retVal;
        }

        public bool Update(TEntity entity)
        {
            if (_dbSet.Local.Any(p => p == entity))
            {
                TEntity localEntity = _dbSet.Local.First(p => p == entity);

                if (Object.ReferenceEquals(localEntity, entity) == false)
                    localEntity = entity;
            }
            else
            {
                _dbSet.Attach(entity);
            }
            _dbContext.Entry(entity).State = EntityState.Modified;

            return _dbContext.SaveChanges() > 0 ? true : false;
        }
    }
}
