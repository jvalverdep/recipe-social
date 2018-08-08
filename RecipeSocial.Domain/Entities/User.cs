using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace RecipeSocial.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public ICollection<Recipe> Recipes { get; set; }
    }
}
