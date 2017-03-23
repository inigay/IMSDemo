using System.Data.Entity.Migrations;

namespace Data.Migrations {
	public partial class one_to_one_company_Location : DbMigration {
		public override void Up() {
			DropForeignKey("dbo.Locations", "Company_Id", "dbo.Companies");
			RenameColumn("dbo.Locations", "Company_Id", "LocationId");
			RenameIndex("dbo.Locations", "IX_Company_Id", "IX_LocationId");
			DropPrimaryKey("dbo.Locations");
			AddPrimaryKey("dbo.Locations", "LocationId");
			AddForeignKey("dbo.Locations", "LocationId", "dbo.Companies", "Id");
			DropColumn("dbo.Locations", "Id");
		}

		public override void Down() {
			AddColumn("dbo.Locations", "Id", c => c.Int(false, true));
			DropForeignKey("dbo.Locations", "LocationId", "dbo.Companies");
			DropPrimaryKey("dbo.Locations");
			AddPrimaryKey("dbo.Locations", "Id");
			RenameIndex("dbo.Locations", "IX_LocationId", "IX_Company_Id");
			RenameColumn("dbo.Locations", "LocationId", "Company_Id");
			AddForeignKey("dbo.Locations", "Company_Id", "dbo.Companies", "Id", true);
		}
	}
}