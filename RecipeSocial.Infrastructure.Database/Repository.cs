using System;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RecipeSocial.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        protected readonly DbContext Context;
        protected readonly DbSet<T> Set;
        public Repository(DbContext context)
        {
            Context = context;
            Set = Context.Set<T>();
        }

        public void Add(T entity)
        {
            Set.AddAsync(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Set.AddRangeAsync(entities);
        }

        public ICollection<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Set.Where(predicate).ToList();
        }

        public T Get(int id, params Expression<Func<T, object>>[] includes)
        {
            var query = Set.Where(x => x.Id == id);

            if (includes != null)
            {
                query = AddMultipleIncludes(query, includes);
            }

            return query.FirstOrDefault();
        }

        public ICollection<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            var query = Set.AsQueryable();

            if (includes != null)
            {
                query = AddMultipleIncludes(query, includes);
            }

            return query.ToList();
        }

        public void Remove(T entity)
        {
            Set.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Set.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        private IQueryable<T> AddMultipleIncludes(IQueryable<T> query, params Expression<Func<T, object>>[] includes)
        {
            var newQuery = query;
            if (includes != null)
            {
                newQuery = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return newQuery;
        }
    }
}
