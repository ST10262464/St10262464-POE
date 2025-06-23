using AgriEnergyConnectWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnectWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Farmers table
        public DbSet<Farmer> Farmers { get; set; }

        // Products table
        public DbSet<Product> Products { get; set; }

        // Employees table
        public DbSet<Employee> Employees { get; set; }
    }
}
