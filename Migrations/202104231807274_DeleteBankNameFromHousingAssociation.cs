namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteBankNameFromHousingAssociation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.HousingAssociations", "BankName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HousingAssociations", "BankName", c => c.String());
        }
    }
}
