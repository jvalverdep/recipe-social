using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;

namespace RecipeSocial.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        
        public UserService(IRepository<User> repository)
        {
            userRepository = repository;
        }

        public User GetUser(int id)
        {
            return userRepository.Get(id);
        }
    }
}
