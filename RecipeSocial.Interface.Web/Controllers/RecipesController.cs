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
        private ICommentService commentService;

        public RecipesController(IRecipeService recipeService, ICommentService commentService)
        {
            this.recipeService = recipeService;
            this.commentService = commentService;
        }
        public IActionResult Search(string tag)
        {
            ICollection<Recipe> recipes = recipeService.SearchRecipesByTag(tag);
            return View(recipes);
        }

        [HttpPost]
        public void Comment(int id, string comment)
        {
            int userId = 1;

            commentService.Comment(id, comment, userId);
        }
    }
}