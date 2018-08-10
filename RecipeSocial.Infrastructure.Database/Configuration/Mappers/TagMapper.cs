using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class TagMapper
    {
        public static void Map(EntityTypeBuilder<Tag> builder)
        {
            BaseMapper.Map(builder);

            builder.Property(recipe => recipe.Name).IsRequired();
        }
    }
}
