using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using RecipeSocial.Domain.Services;

namespace RecipeSocial.Interface.Web.Controllers
{
    public class RecipesController
    {
        private ICommentService commentService;

        public RecipesController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        public void Comment(int id, string comment)
        {
            int userId = 1;

            commentService.Comment(id, comment, userId);
        }
=======
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



>>>>>>> 2fca37766e6b9cb83e4c759ea7c6db315116e106
    }
}
