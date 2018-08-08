using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;

namespace RecipeSocial.Domain.Entities
{
    public class Tag : Base
    {
        public int Name { get; set; }

        public ICollection<RecipeTag> RecipeTags { get; set; }
    }
}
