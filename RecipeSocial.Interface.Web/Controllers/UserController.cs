using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Infrastructure.Database.Configuration;

namespace RecipeSocial.Interface.Web.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
