using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class BasicRepository<TEntity> : IRepository<TEntity>
    {
        private readonly string _tableName;

        public BasicRepository()
        {

        }

        public BasicRepository(string tableName)
        {
            this._tableName = tableName;
        }

        public TEntity Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(ulong id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
