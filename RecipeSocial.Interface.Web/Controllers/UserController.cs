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
        private readonly IUserService userService;
        private readonly IMeasureService measureService;
        public UsersController(IUserService userService, IMeasureService measureService)
        {
            this.userService = userService;
            this.measureService = measureService;
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
            ViewBag.MeasuresList = measureService.GetMeasures();
            return View(user);
        }
    }
}
