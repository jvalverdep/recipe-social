using RecipeSocial.Domain.Entities.Template;

namespace RecipeSocial.Domain.Entities
{
    public class Preparation : Base
    {
        public int Order { get; set; }
        public string Instruction { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
