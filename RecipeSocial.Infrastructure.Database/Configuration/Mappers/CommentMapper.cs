using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class CommentMapper
    {
        public static void Map(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(comment => comment.RecipeId).IsRequired();

            builder.HasOne(comment => comment.User)
                .WithMany()
                .HasForeignKey(comment => comment.UserId);
        }
    }
}
