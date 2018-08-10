using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;

namespace RecipeSocial.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> recipeRepository;

        public RecipeService(IRepository<Recipe> repository)
        {
            recipeRepository = repository;
        }

        public void DeleteRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipe(int id)
        {
            return recipeRepository.Get(id);
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return recipeRepository.GetAll();
        }

        public void InsertRecipe(Recipe recipe)
        {
            recipeRepository.Add(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            recipeRepository.Update(recipe);
        }

        public void CommentRecipe(int id, string comment, User user)
        {
            Recipe recipe = recipeRepository.Get(id);

            Comment newComment = new Comment
            {
                Text = comment,
                UserId = user.Id,
                RecipeId = id
            };

            recipe.Comments.Add(newComment);

            recipeRepository.Update(recipe);
        }
    }
}