using RecipeSocial.Domain.Entities;
using System.Collections.Generic;
using System;

namespace RecipeSocial.Domain.Services
{
    public interface IUserService
    {
        User GetUser(int id);
        //IEnumerable<User> GetUsers();
    }
}
