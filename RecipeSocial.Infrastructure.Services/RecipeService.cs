using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using System.Linq;
using System.Text;

namespace RecipeSocial.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> recipeRepository;
        private IRecipeTagRepository recipeTagRepository;
        private IRepository<Tag> tagRepository;
        public RecipeService(IRepository<Recipe> repository, IRepository<Tag> tagRepository, IRecipeTagRepository recipeTagRepository)
        {
            this.recipeRepository = repository;
            this.tagRepository = tagRepository;
            this.recipeTagRepository = recipeTagRepository;
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
        public ICollection<Recipe> SearchRecipesByTag(string tagName)
        {
            Tag tag = tagRepository.Find(t => t.Name == tagName).First();

            ICollection<RecipeTag> recipeTags= recipeTagRepository.Find(x => x.TagId == tag.Id);
            ICollection<int> recipeIds = recipeTags.Select(x => x.RecipeId).ToList();

            ICollection<Recipe> recipes = recipeRepository.Find(recipe => recipeIds.Contains(recipe.Id));

            return recipes;
        }
    }
}
