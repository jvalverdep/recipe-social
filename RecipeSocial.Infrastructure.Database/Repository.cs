using System;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        public async Task AddAsync(T entity)
        {
            await Set.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Set.AddRangeAsync(entities);
        }

        public async Task<ICollection<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await Set.Where(predicate).ToListAsync();
        }

        public async Task<T> GetAsync(long id)
        {
            return await Set.FindAsync(id);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await Set.ToListAsync();
        }

        public void Remove(T entity)
        {
            Set.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Set.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
