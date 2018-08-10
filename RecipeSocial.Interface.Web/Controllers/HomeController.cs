using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using RecipeSocial.Infrastructure.Services;
using RecipeSocial.Interface.Web.ViewModels;

namespace RecipeSocial.Interface.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeService recipeService;
        public HomeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }
        public IActionResult Index()
        {

            ICollection<Recipe> recipes = recipeService.GetRecipes();
            ICollection<Recipe> topRecipes = recipeService.GetTopRecipes();
            IndexViewModel viewModel = new IndexViewModel
            {
                generalRecipeList = recipes,
                topList = topRecipes
            };
            return View(viewModel);
        }



    }
}