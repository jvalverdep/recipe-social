using Microsoft.AspNetCore.Mvc;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
namespace RecipeSocial.Interface.Web.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }
        public IActionResult Search(string tag)
        {
            ICollection<Recipe> recipes = recipeService.SearchRecipesByTag(tag);
            return View(recipes);
        }



    }
}
