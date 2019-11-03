﻿using DAL.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class BasicRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DbSet<TEntity> _entities;

        public BasicRepository(TradingCompanyContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entities.SingleOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            return (await _entities.AddAsync(entity)).Entity;
        }

        public virtual TEntity Add(TEntity entity)
        {
            return _entities.Add(entity).Entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            return _entities.Update(entity).Entity;
        }

        public virtual void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }
    }
}
