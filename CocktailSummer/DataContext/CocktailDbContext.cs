using CocktailSummer.Models;
using Microsoft.EntityFrameworkCore;

namespace CocktailSummer.DataContext
{
    public class CocktailDbContext : DbContext
    {
        public CocktailDbContext(DbContextOptions<CocktailDbContext> options)
            : base(options) {
        }

        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
