using RecipeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSocial.Domain.Services
{
    public interface IUserService
    {
        ICollection<User> GetUsers();
        User GetUserWithRecipes(int id);

    }
}
    