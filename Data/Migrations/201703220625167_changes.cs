namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ItemInventories", name: "Inventory_Id", newName: "Inventory_InventoryId");
            RenameIndex(table: "dbo.ItemInventories", name: "IX_Inventory_Id", newName: "IX_Inventory_InventoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ItemInventories", name: "IX_Inventory_InventoryId", newName: "IX_Inventory_Id");
            RenameColumn(table: "dbo.ItemInventories", name: "Inventory_InventoryId", newName: "Inventory_Id");
        }
    }
}
