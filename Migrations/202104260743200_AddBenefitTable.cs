namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBenefitTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Benefits",
                c => new
                    {
                        IdBenefit = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Unit = c.String(),
                        Parameter = c.Double(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BruttoPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdBenefit);
            
            AddColumn("dbo.People", "IdBenefit", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "IdBenefit");
            AddForeignKey("dbo.People", "IdBenefit", "dbo.Benefits", "IdBenefit", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "IdBenefit", "dbo.Benefits");
            DropIndex("dbo.People", new[] { "IdBenefit" });
            DropColumn("dbo.People", "IdBenefit");
            DropTable("dbo.Benefits");
        }
    }
}
