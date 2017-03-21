using System.Data.Entity;
using IMSDemo;

namespace DataLayer
{
    public class IMSContext: DbContext
    { 
        public DbSet<Company> Companies { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
