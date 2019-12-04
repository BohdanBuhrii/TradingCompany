using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, int skip = 0, int take = int.MaxValue);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        TEntity GetById(int id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, int skip = 0, int take = int.MaxValue);

        IEnumerable<TEntity> GetAll();


        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(int id);
    }
}
