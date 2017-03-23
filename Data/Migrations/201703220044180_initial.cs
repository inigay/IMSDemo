using System.Data.Entity.Migrations;

namespace Data.Migrations {
	public partial class initial : DbMigration {
		public override void Up() {
			CreateTable(
					"dbo.Companies",
					c => new {
						Id = c.Int(false, true),
						Name = c.String()
					})
				.PrimaryKey(t => t.Id);

			CreateTable(
					"dbo.Inventories",
					c => new {
						InventoryId = c.Int(false),
						Category = c.String()
					})
				.PrimaryKey(t => t.InventoryId)
				.ForeignKey("dbo.Companies", t => t.InventoryId)
				.Index(t => t.InventoryId);

			CreateTable(
					"dbo.Items",
					c => new {
						Id = c.Int(false, true),
						Code = c.String(),
						Category = c.String(),
						Price = c.Decimal(false, 18, 2),
						ItemsInStock = c.Int(false),
						IsActive = c.Boolean(false)
					})
				.PrimaryKey(t => t.Id);

			CreateTable(
					"dbo.Manufacturers",
					c => new {
						Id = c.Int(false, true),
						Name = c.String()
					})
				.PrimaryKey(t => t.Id);

			CreateTable(
					"dbo.Locations",
					c => new {
						Id = c.Int(false, true),
						Address = c.String(),
						AddressOpt = c.String(),
						City = c.String(),
						State = c.String(),
						zip = c.Int(false),
						Company_Id = c.Int(false)
					})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Companies", t => t.Company_Id, true)
				.Index(t => t.Company_Id);

			CreateTable(
					"dbo.ItemInventories",
					c => new {
						Item_Id = c.Int(false),
						Inventory_Id = c.Int(false)
					})
				.PrimaryKey(t => new {t.Item_Id, t.Inventory_Id})
				.ForeignKey("dbo.Items", t => t.Item_Id, true)
				.ForeignKey("dbo.Inventories", t => t.Inventory_Id, true)
				.Index(t => t.Item_Id)
				.Index(t => t.Inventory_Id);

			CreateTable(
					"dbo.ManufacturerItems",
					c => new {
						Manufacturer_Id = c.Int(false),
						Item_Id = c.Int(false)
					})
				.PrimaryKey(t => new {t.Manufacturer_Id, t.Item_Id})
				.ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id, true)
				.ForeignKey("dbo.Items", t => t.Item_Id, true)
				.Index(t => t.Manufacturer_Id)
				.Index(t => t.Item_Id);
		}

		public override void Down() {
			DropForeignKey("dbo.Locations", "Company_Id", "dbo.Companies");
			DropForeignKey("dbo.ManufacturerItems", "Item_Id", "dbo.Items");
			DropForeignKey("dbo.ManufacturerItems", "Manufacturer_Id", "dbo.Manufacturers");
			DropForeignKey("dbo.ItemInventories", "Inventory_Id", "dbo.Inventories");
			DropForeignKey("dbo.ItemInventories", "Item_Id", "dbo.Items");
			DropForeignKey("dbo.Inventories", "InventoryId", "dbo.Companies");
			DropIndex("dbo.ManufacturerItems", new[] {"Item_Id"});
			DropIndex("dbo.ManufacturerItems", new[] {"Manufacturer_Id"});
			DropIndex("dbo.ItemInventories", new[] {"Inventory_Id"});
			DropIndex("dbo.ItemInventories", new[] {"Item_Id"});
			DropIndex("dbo.Locations", new[] {"Company_Id"});
			DropIndex("dbo.Inventories", new[] {"InventoryId"});
			DropTable("dbo.ManufacturerItems");
			DropTable("dbo.ItemInventories");
			DropTable("dbo.Locations");
			DropTable("dbo.Manufacturers");
			DropTable("dbo.Items");
			DropTable("dbo.Inventories");
			DropTable("dbo.Companies");
		}
	}
}