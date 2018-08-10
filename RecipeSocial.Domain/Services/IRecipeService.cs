﻿using RecipeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSocial.Domain.Services
{
    public interface IRecipeService
    {
        ICollection<Recipe> GetRecipes();
        ICollection<Recipe> SearchRecipesByTag(string tag);
        Recipe GetRecipe(int id);
        void InsertRecipe(Recipe recipe);
        ICollection<Recipe> GetTopRecipes();
    }
}
