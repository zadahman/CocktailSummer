using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoSchedule_Challenge.Models
{
    public class CocktailDbContext : DbContext
    {
        public CocktailDbContext(DbContextOptions<CocktailDbContext> options)
            : base(options) { }

        public DbSet<Cocktail> Cocktails { get; set; }
    }
}