using System.Data.Entity;
using Business.Entities;

namespace Data {
	public class IMSDemoContext : DbContext {
		public DbSet<Company> Companies { get; set; }

		public DbSet<Inventory> Inventories { get; set; }

		public DbSet<Location> Locations { get; set; }

		public DbSet<Manufacturer> Manufacturers { get; set; }

		public DbSet<Item> Items { get; set; }
	}
}