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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(UsersController));
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Profile(int? id)
        {
            IActionResult result;
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException("User Id");
                }
                User user = userService.GetUserWithRecipes(id.Value);
                if (user == null)
                {
                    throw new ArgumentNullException("User");
                }

                result = View(user);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                result = StatusCode(500);
            }

            return result;
        }
    }
}
