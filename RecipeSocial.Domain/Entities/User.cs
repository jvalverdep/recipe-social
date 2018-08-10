using Microsoft.AspNetCore.Identity;
using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;

namespace RecipeSocial.Domain.Entities
{
    public class User : Base
    {
        public User()
        {
            this.Recipes = new HashSet<Recipe>();
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
