using RecipeSocial.Domain.Entities.Template;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RecipeSocial.Domain.Database
{
    public interface IRepository<T> where T : Base
    {
        Task<T> GetAsync(long id);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
