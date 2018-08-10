using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class LogMapper
    {
        public static void Map(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Thread).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Level).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Logger).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Message).IsRequired().HasMaxLength(4000);
            builder.Property(x => x.Exception).HasMaxLength(2000);
        }
    }
}
