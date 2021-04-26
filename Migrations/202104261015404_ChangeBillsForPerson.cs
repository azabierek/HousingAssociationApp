namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBillsForPerson : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bills", "IdPerson", "dbo.People");
            DropIndex("dbo.Bills", new[] { "IdPerson" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Bills", "IdPerson");
            AddForeignKey("dbo.Bills", "IdPerson", "dbo.People", "IdPerson", cascadeDelete: true);
        }
    }
}
