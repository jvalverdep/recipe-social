<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
=======
﻿using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 2fca37766e6b9cb83e4c759ea7c6db315116e106

namespace RecipeSocial.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> 2fca37766e6b9cb83e4c759ea7c6db315116e106
