using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class UserMapper
    {
        public static void Map(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(user => user.Recipes)
                .WithOne(recipe => recipe.User)
                .HasForeignKey(user => user.UserId);
        }
    }
}
