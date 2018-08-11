using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Interface.Web.ViewModels
{
    public class RecipeViewModel : BaseViewModel
    {
        public Recipe recipe { get; set; }
        public List<Recipe> Recipes { get; set; }
        
        public RecipeViewModel()
        {
            //Recipes = new List<Recipe>();
            recipe = new Recipe();
        }
        public void CreateRecipe(string title, string description)
        {
            
        }
        //public void LoadData()
        //{
        //    Recipes = new List<Recipe>();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Recipe recipe = new Recipe();
        //        recipe.Name = "Receta" + i;
        //        Recipes.Add(recipe);
        //    }
        //}
    }
}
