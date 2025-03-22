using Microsoft.EntityFrameworkCore;
using LivingCountyLewisAPI.Models;  // ✅ This is likely where your error was

namespace LivingCountyLewisAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Listing> Listings { get; set; }

        public DbSet<EmailLead> EmailLeads { get; set; } // ✅ Make sure this line ends with a semicolon
    }
}