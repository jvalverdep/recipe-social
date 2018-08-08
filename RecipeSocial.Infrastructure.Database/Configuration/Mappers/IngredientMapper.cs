using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class IngredientMapper
    {
        public static void Map(EntityTypeBuilder<Ingredient> builder)
        {
            BaseMapper.Map(builder);

            builder.Property(ingredient => ingredient.Name).IsRequired();

            builder.HasOne(ingredient => ingredient.Measure);
        }
    }
}
