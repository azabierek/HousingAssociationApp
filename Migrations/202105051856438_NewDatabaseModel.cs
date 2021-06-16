namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabaseModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Benefit_IdBenefit", "dbo.Benefits");
            DropIndex("dbo.People", new[] { "Benefit_IdBenefit" });
            CreateTable(
                "dbo.HousingAssociationParameters",
                c => new
                    {
                        IdHousingAssociationParameters = c.Int(nullable: false, identity: true),
                        ParameterName = c.String(),
                        IdHousingAssociation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdHousingAssociationParameters)
                .ForeignKey("dbo.HousingAssociations", t => t.IdHousingAssociation, cascadeDelete: true)
                .Index(t => t.IdHousingAssociation);
            
            DropColumn("dbo.People", "Benefit_IdBenefit");
            DropTable("dbo.Benefits");
            DropTable("dbo.Bills");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        IdBills = c.Int(nullable: false, identity: true),
                        AccountStatus = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        IdPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdBills);
            
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
            
            AddColumn("dbo.People", "Benefit_IdBenefit", c => c.Int());
            DropForeignKey("dbo.HousingAssociationParameters", "IdHousingAssociation", "dbo.HousingAssociations");
            DropIndex("dbo.HousingAssociationParameters", new[] { "IdHousingAssociation" });
            DropTable("dbo.HousingAssociationParameters");
            CreateIndex("dbo.People", "Benefit_IdBenefit");
            AddForeignKey("dbo.People", "Benefit_IdBenefit", "dbo.Benefits", "IdBenefit");
        }
    }
}
