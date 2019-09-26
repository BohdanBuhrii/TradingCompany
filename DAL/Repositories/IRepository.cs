using System.Collections.Generic;

namespace DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity Get(ulong id);

        IEnumerable<TEntity> GetAll();

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}
