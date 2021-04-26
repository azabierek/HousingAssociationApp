namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteBillsInPeopleTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "IdBenefit", "dbo.Benefits");
            DropIndex("dbo.People", new[] { "IdBenefit" });
            RenameColumn(table: "dbo.People", name: "IdBenefit", newName: "Benefit_IdBenefit");
            AlterColumn("dbo.People", "Benefit_IdBenefit", c => c.Int());
            CreateIndex("dbo.People", "Benefit_IdBenefit");
            AddForeignKey("dbo.People", "Benefit_IdBenefit", "dbo.Benefits", "IdBenefit");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Benefit_IdBenefit", "dbo.Benefits");
            DropIndex("dbo.People", new[] { "Benefit_IdBenefit" });
            AlterColumn("dbo.People", "Benefit_IdBenefit", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.People", name: "Benefit_IdBenefit", newName: "IdBenefit");
            CreateIndex("dbo.People", "IdBenefit");
            AddForeignKey("dbo.People", "IdBenefit", "dbo.Benefits", "IdBenefit", cascadeDelete: true);
        }
    }
}
