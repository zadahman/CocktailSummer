using CoScheduleChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace CoScheduleChallenge.DataContext
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
