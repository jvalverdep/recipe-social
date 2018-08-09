using System;
using RecipeSocial.Domain.Entities;
using System.Collections.Generic;
namespace RecipeSocial.Domain.Services
{
    public interface IRecipeService
    {
        Recipe GetRecipe(int id);
        IEnumerable<Recipe> GetRecipes();
        void InsertRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
        void CommentRecipe(int id, string comment, User user);
    }
}