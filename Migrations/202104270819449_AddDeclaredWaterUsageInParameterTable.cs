namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeclaredWaterUsageInParameterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "DeclaredColdWaterUsage", c => c.Double(nullable: false));
            AddColumn("dbo.Parameters", "DeclaredHotWaterUsage", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "DeclaredHotWaterUsage");
            DropColumn("dbo.Parameters", "DeclaredColdWaterUsage");
        }
    }
}
