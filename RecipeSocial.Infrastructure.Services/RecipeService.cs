using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeSocial.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
        private IRepository<Recipe> recipeRepository;
        private IRecipeTagRepository repositoryRecipeTag;
        private IRepository<Tag> repositoryTag;
        public RecipeService(IRepository<Recipe> recipeRepository, IRepository<Tag> repositoryTag, IRecipeTagRepository repositoryRecipeTag)
        {
            this.repositoryRecipeTag = repositoryRecipeTag;
            this.recipeRepository = recipeRepository;
            this.repositoryTag = repositoryTag;
        }
        public ICollection<Recipe> SearchRecipesByTag(string tagName)
        {
            Tag recipeTag = repositoryTag.Find(tag => tag.Name == tagName).First();

            ICollection<RecipeTag> recipeTags = repositoryRecipeTag.Find(x => x.TagId == recipeTag.Id);
            ICollection<int> recipeIds = recipeTags.Select(x => x.RecipeId).ToList();

            ICollection<Recipe> recipes = recipeRepository.Find(recipe => recipeIds.Contains(recipe.Id));

            return recipes;
        }
        public ICollection<Recipe> GetRecipes()
        {
            return recipeRepository.GetAll();
        }
        public Recipe GetRecipe(int id)
        {
            return recipeRepository.Get(id);
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