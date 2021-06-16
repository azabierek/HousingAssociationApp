namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameUiqueHousingAssociation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HousingAssociations", "Name", c => c.String(maxLength: 450));
            CreateIndex("dbo.HousingAssociations", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.HousingAssociations", new[] { "Name" });
            AlterColumn("dbo.HousingAssociations", "Name", c => c.String());
        }
    }
}
