using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Infrastructure.Database.Configuration.Mappers;
using System.Linq;

namespace RecipeSocial.Infrastructure.Database.Configuration
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Measure> Measure { get; set; }
        public DbSet<RecipeTag> RecipeTag { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<Log> Log { get; set; }

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
            LogMapper.Map(modelBuilder.Entity<Log>());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
