using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeSocial.Domain.Services;
using RecipeSocial.Interface.Web.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeSocial.Interface.Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService service)
        {
            recipeService = service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            RecipeViewModel model = new RecipeViewModel();
            //model.LoadData();
            model.Recipes = recipeService.GetRecipes().ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(string title, string description)
        {
            RecipeViewModel model = new RecipeViewModel();
            model.recipe.Name = title;
            model.recipe.UserId = 1;
            recipeService.InsertRecipe(model.recipe);
            return RedirectToAction("Index");
        }
    }
}
