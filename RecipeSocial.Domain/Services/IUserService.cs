using RecipeSocial.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Text;

namespace RecipeSocial.Domain.Services
{
    public interface IUserService
    {
        User GetUser(int id);
        // IEnumerable<User> GetUsers();
        ICollection<User> GetUsers();
        User GetUserWithRecipes(int id);

    }
}
    
