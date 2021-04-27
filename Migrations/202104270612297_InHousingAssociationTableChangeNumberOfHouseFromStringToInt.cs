namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InHousingAssociationTableChangeNumberOfHouseFromStringToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HousingAssociations", "NumberOfHouse", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HousingAssociations", "NumberOfHouse", c => c.String());
        }
    }
}
