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

namespace RecipeSocial.Interface.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Profile(int? id)
        {
            
            if(id == null)
            {
                return View();
            }
            User user = userService.GetUserWithRecipes(id.Value);
            if (user == null)
            {
                return View();
            }
            return View(user);
        }
    }
}
