using LewisCountyLiving.Models;
using Microsoft.EntityFrameworkCore;

namespace LewisCountyLiving.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Listing> Listings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listing>().HasData(
                new Listing { Id = 1, Name = "Lewis County Farmers Market", Type = "Event", Description = "Weekly farmers market with fresh produce", Address = "123 Main St", ImageUrl = "farmersmarket.jpg" },
                new Listing { Id = 2, Name = "Pine Hill Cabin Rentals", Type = "Property", Description = "Cozy cabins for weekend getaways", Address = "456 Forest Rd", ImageUrl = "cabin.jpg" }
            );
        }
    }
}
