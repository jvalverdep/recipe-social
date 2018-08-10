using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using RecipeSocial.Interface.Web.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeSocial.Interface.Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;
        private readonly IMeasureService measureService;

        public RecipeController(IRecipeService service, IMeasureService measureService)
        {
            recipeService = service;
            this.measureService = measureService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            RecipeViewModel model = new RecipeViewModel();
            //model.LoadData();
            model.Recipes = recipeService.GetRecipes().ToList();
            ViewBag.MeasuresList = measureService.GetMeasures();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(string title, string description, 
                                    ICollection<Ingredient> ingredients,
                                    ICollection<Preparation> preparations)
        {
            RecipeViewModel model = new RecipeViewModel();
            model.recipe.Name = title;
            model.recipe.UserId = 1;
            model.recipe.Description = description;
            model.recipe.Preparations = preparations;
            //model.recipe.Ingredients = ingredients;
            recipeService.InsertRecipe(model.recipe);

            //System.Diagnostics.Debug
            return RedirectToAction("Profile", "Users", new { id = 1});
        }
    }
}
