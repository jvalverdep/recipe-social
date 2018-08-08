using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class RecipeMapper
    {
        public static void Map(EntityTypeBuilder<Recipe> builder)
        {
            BaseMapper.Map(builder);

            builder.Property(recipe => recipe.Name).IsRequired();

            builder.HasMany(recipe => recipe.Preparations)
                .WithOne(preparation => preparation.Recipe)
                .HasForeignKey(preparation => preparation.RecipeId);

            builder.HasMany(recipe => recipe.Ingredients)
                .WithOne(ingredient => ingredient.Recipe)
                .HasForeignKey(ingredient => ingredient.RecipeId);

            builder.HasMany(recipe => recipe.Comments)
                .WithOne()
                .HasForeignKey(comment => comment.RecipeId);

            builder.HasMany(recipe => recipe.Likes)
                .WithOne()
                .HasForeignKey(like => like.RecipeId);

            builder.HasOne(recipe => recipe.User)
                .WithMany(user => user.Recipes)
                .HasForeignKey(recipe => recipe.UserId);
        }
    }
}
