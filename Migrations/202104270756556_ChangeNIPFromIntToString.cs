namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNIPFromIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HousingAssociations", "NIP", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HousingAssociations", "NIP", c => c.Int(nullable: false));
        }
    }
}
