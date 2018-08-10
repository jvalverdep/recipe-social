using System;
using System.Collections.Generic;
using System.Linq;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;

namespace RecipeSocial.Interface.Web.ViewModels
{
    public class UserViewModel
    {
        public User user { get; set; }
        public List<Recipe> Recipes { get; set; }
        public UserViewModel()
        {
            Recipes = new List<Recipe>();
            user = new User();
        }

        public void LoadData(IRecipeService service)
        {
            Recipes = service.GetRecipes().ToList();
        }
    }
}
