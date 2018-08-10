﻿using RecipeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSocial.Domain.Services
{
    public interface IRecipeService
    {
        Recipe GetRecipe(int id);
        IEnumerable<Recipe> GetRecipes();
        void InsertRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
        ICollection<Recipe> SearchRecipesByTag(string tag);
    }
}
