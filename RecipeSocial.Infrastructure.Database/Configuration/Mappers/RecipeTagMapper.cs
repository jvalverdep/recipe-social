using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class RecipeTagMapper
    {
        public static void Map(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.HasKey(recipeTag => new { recipeTag.RecipeId, recipeTag.TagId });

            builder.HasOne(recipeTag => recipeTag.Recipe)
                .WithMany(recipe => recipe.RecipeTags)
                .HasForeignKey(recipeTag => recipeTag.RecipeId);

            builder.HasOne(recipeTag => recipeTag.Tag)
                .WithMany(recipe => recipe.RecipeTags)
                .HasForeignKey(recipeTag => recipeTag.TagId);
        }
    }
}
