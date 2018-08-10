using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace RecipeSocial.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> repository)
        {
            userRepository = repository;
        }

        public ICollection<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUserWithRecipes(int id)
        {
            return userRepository.Get(id, x => x.Recipes);
    }
    }
    
}
