using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSocial.Domain.Entities.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSocial.Infrastructure.Database.Configuration.Mappers
{
    public class BaseMapper
    {
        public static void Map<TEntity>(EntityTypeBuilder<TEntity> builder) where TEntity : Base
        {
            builder.HasKey(x => x.Id);
        }
    }
}
