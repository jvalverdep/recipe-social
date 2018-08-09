using Microsoft.AspNetCore.Identity;
using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;

namespace RecipeSocial.Domain.Entities
{
    public class User : Base
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
