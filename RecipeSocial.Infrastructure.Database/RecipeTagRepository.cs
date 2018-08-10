using System;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database
{
    public class RecipeTagRepository : IRecipeTagRepository 
    {
        protected readonly DbContext Context;
        protected readonly DbSet<RecipeTag> Set;
    
        public RecipeTagRepository(DbContext context)
        {
            Context = context;
            Set = Context.Set<RecipeTag>();
        }
        public void Add(RecipeTag entity)
        {
            Set.AddAsync(entity);
        }

        public void AddRange(IEnumerable<RecipeTag> entities)
        {
            Set.AddRangeAsync(entities);
        }
        public ICollection<RecipeTag> Find(Expression<Func<RecipeTag, bool>> predicate)
        {
            return Set.Where(predicate).ToList();
        }
        public RecipeTag Get(long id)
        {
            return Set.Find(id);
        }
        public ICollection<RecipeTag> GetAll()
        {
            return Set.ToList();
        }
        public void Remove(RecipeTag entity)
        {
            Set.Remove(entity);
        }
        public void RemoveRange(IEnumerable<RecipeTag> entities)
        {
            Set.RemoveRange(entities);
        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }

    }
}
