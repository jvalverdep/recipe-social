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
        private IRepository<Recipe> repository;
        private IRecipeTagRepository repositoryRecipeTag;
        private IRepository<Tag> repositoryTag;
        public RecipeService(IRepository<Recipe> repository,IRepository<Tag> repositoryTag,IRecipeTagRepository repositoryRecipeTag)
        {
            this.repositoryRecipeTag = repositoryRecipeTag;
            this.repository = repository;
            this.repositoryTag = repositoryTag;
        }
        public ICollection<Recipe> SearchRecipesByTag(string tagName)
        {
            Tag recipeTag = repositoryTag.Find(tag => tag.Name == tagName).First();

            ICollection<RecipeTag> recipeTags= repositoryRecipeTag.Find(x => x.TagId == recipeTag.Id);
            ICollection<int> recipeIds = recipeTags.Select(x => x.RecipeId).ToList();

            ICollection<Recipe> recipes = repository.Find(recipe => recipeIds.Contains(recipe.Id));

            return recipes;
        }
        public ICollection<Recipe> GetRecipes()
        {
            return repository.GetAll();
        }
         public Recipe GetRecipe(int id)
        {
            return repository.Get(id);
        }



    }
}
