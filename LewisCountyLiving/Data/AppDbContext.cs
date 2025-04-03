using LewisCountyLiving.Models;

namespace LewisCountyLiving.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Listing> Listings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }  // ✅ Ensure this closing brace exists!
}  // ✅ Ensure this closing brace exists!