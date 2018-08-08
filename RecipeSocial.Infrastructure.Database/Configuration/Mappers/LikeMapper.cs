using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class LikeMapper
    {
        public static void Map(EntityTypeBuilder<Like> builder)
        {
            BaseMapper.Map(builder);

            builder.HasOne(like => like.User)
                .WithMany()
                .HasForeignKey(like => like.UserId);
        }
    }
}
