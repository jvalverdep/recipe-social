using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using RecipeSocial.Infrastructure.Database.Configuration;
using RecipeSocial.Interface.Web.ViewModels;

namespace RecipeSocial.Interface.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IRecipeService recipeService;

        public UsersController(IRecipeService service)
        {
            recipeService = service;
        }

        public IActionResult Profile()
        {
            UserViewModel model = new UserViewModel();
            model.LoadData(recipeService);
            return View(model);
        }
    }
}
