using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Infrastructure.Database.Configuration.Mappers;
using System.Linq;

namespace RecipeSocial.Infrastructure.Database.Configuration
{
    public class DatabaseContext : IdentityDbContext<User, Role, int>
    {
        DbSet<Comment> Comment { get; set; }
        DbSet<Ingredient> Ingredient { get; set; }
        DbSet<Like> Like { get; set; }
        DbSet<Measure> Measure { get; set; }
        DbSet<RecipeTag> RecipeTag { get; set; }
        DbSet<Tag> Tag { get; set; }
        DbSet<Recipe> Recipe { get; set; }
        DbSet<User> User { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CommentMapper.Map(modelBuilder.Entity<Comment>());
            IngredientMapper.Map(modelBuilder.Entity<Ingredient>());
            LikeMapper.Map(modelBuilder.Entity<Like>());
            MeasureMapper.Map(modelBuilder.Entity<Measure>());
            RecipeTagMapper.Map(modelBuilder.Entity<RecipeTag>());
            TagMapper.Map(modelBuilder.Entity<Tag>());
            RecipeMapper.Map(modelBuilder.Entity<Recipe>());
            UserMapper.Map(modelBuilder.Entity<User>());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
