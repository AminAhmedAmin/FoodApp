using FoodApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FoodApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = .\SQLExpress; Initial Catalog = FoodApp;Integrated security = true;trust server certificate = true")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
               
        ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Instructor>().ToTable("Instructor");
        }

    }
}
