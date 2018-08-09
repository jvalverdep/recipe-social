using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Interface.Web.ViewModels
{
    public class RecipeViewModel : BaseViewModel
    {

        public List<Recipe> Recipes { get; set; }
        
        public RecipeViewModel()
        {
            //Recipes = new List<Recipe>();
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
