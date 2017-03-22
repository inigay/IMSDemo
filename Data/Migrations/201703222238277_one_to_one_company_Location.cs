namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one_to_one_company_Location : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locations", "Company_Id", "dbo.Companies");
            RenameColumn(table: "dbo.Locations", name: "Company_Id", newName: "LocationId");
            RenameIndex(table: "dbo.Locations", name: "IX_Company_Id", newName: "IX_LocationId");
            DropPrimaryKey("dbo.Locations");
            AddPrimaryKey("dbo.Locations", "LocationId");
            AddForeignKey("dbo.Locations", "LocationId", "dbo.Companies", "Id");
            DropColumn("dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Locations", "LocationId", "dbo.Companies");
            DropPrimaryKey("dbo.Locations");
            AddPrimaryKey("dbo.Locations", "Id");
            RenameIndex(table: "dbo.Locations", name: "IX_LocationId", newName: "IX_Company_Id");
            RenameColumn(table: "dbo.Locations", name: "LocationId", newName: "Company_Id");
            AddForeignKey("dbo.Locations", "Company_Id", "dbo.Companies", "Id", cascadeDelete: true);
        }
    }
}
