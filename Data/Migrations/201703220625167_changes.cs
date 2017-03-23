using System.Data.Entity.Migrations;

namespace Data.Migrations {
	public partial class changes : DbMigration {
		public override void Up() {
			RenameColumn("dbo.ItemInventories", "Inventory_Id", "Inventory_InventoryId");
			RenameIndex("dbo.ItemInventories", "IX_Inventory_Id", "IX_Inventory_InventoryId");
		}

		public override void Down() {
			RenameIndex("dbo.ItemInventories", "IX_Inventory_InventoryId", "IX_Inventory_Id");
			RenameColumn("dbo.ItemInventories", "Inventory_InventoryId", "Inventory_Id");
		}
	}
}