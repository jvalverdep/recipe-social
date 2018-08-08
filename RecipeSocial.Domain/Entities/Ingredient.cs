using RecipeSocial.Domain.Entities.Template;

namespace RecipeSocial.Domain.Entities
{
    public class Ingredient : Base
    {
        public int Order { get; set; }
        public string Name { get; set; }

        public int MeasureId { get; set; }
        public Measure Measure { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
