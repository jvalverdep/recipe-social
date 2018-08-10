using RecipeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RecipeSocial.Domain.Database
{
    public interface IRecipeTagRepository 
    {
        RecipeTag Get(long id);

        ICollection<RecipeTag> GetAll();

        ICollection<RecipeTag> Find(Expression<Func<RecipeTag, bool>> predicate);

        void Add(RecipeTag entity);

        void AddRange(IEnumerable<RecipeTag> entities);

        void Remove(RecipeTag entity);

        void RemoveRange(IEnumerable<RecipeTag> entities);

        void SaveChanges();
    }
}
