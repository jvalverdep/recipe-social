using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class MeasureMapper
    {
        public static void Map(EntityTypeBuilder<Measure> builder)
        {
            BaseMapper.Map(builder);

            builder.Property(measure => measure.Name).IsRequired();
            builder.Property(measure => measure.Symbol).IsRequired();
        }
    }
}
