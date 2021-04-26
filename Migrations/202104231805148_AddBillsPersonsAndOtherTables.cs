namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBillsPersonsAndOtherTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        IdBankAccount = c.Int(nullable: false, identity: true),
                        BankName = c.String(),
                        AccountNumber = c.Int(nullable: false),
                        IdHousingAssociation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdBankAccount)
                .ForeignKey("dbo.HousingAssociations", t => t.IdHousingAssociation, cascadeDelete: true)
                .Index(t => t.IdHousingAssociation);
            
            CreateTable(
                "dbo.HousingAssociations",
                c => new
                    {
                        IdHousingAssociation = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIP = c.Int(nullable: false),
                        Regon = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.String(),
                        PostCode = c.String(),
                        NumberOfHouse = c.String(),
                        BankName = c.String(),
                    })
                .PrimaryKey(t => t.IdHousingAssociation);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        IdPerson = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Housenumber = c.String(),
                        PostCode = c.String(),
                        IdHousingAssociation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPerson)
                .ForeignKey("dbo.HousingAssociations", t => t.IdHousingAssociation, cascadeDelete: true)
                .Index(t => t.IdHousingAssociation);
            
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        IdParameters = c.Int(nullable: false, identity: true),
                        Surface = c.Double(nullable: false),
                        QuantityOfPeople = c.Int(nullable: false),
                        ColdWaterUsage = c.Double(nullable: false),
                        QuantityOfAntennas = c.Int(nullable: false),
                        HotWaterUsage = c.Double(nullable: false),
                        IdPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdParameters);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        IdBills = c.Int(nullable: false, identity: true),
                        AccountStatus = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        IdPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdBills)
                .ForeignKey("dbo.People", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson);
            
            CreateTable(
                "dbo.ParametersPersons",
                c => new
                    {
                        Parameters_IdParameters = c.Int(nullable: false),
                        Person_IdPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Parameters_IdParameters, t.Person_IdPerson })
                .ForeignKey("dbo.Parameters", t => t.Parameters_IdParameters, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_IdPerson, cascadeDelete: true)
                .Index(t => t.Parameters_IdParameters)
                .Index(t => t.Person_IdPerson);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "IdPerson", "dbo.People");
            DropForeignKey("dbo.ParametersPersons", "Person_IdPerson", "dbo.People");
            DropForeignKey("dbo.ParametersPersons", "Parameters_IdParameters", "dbo.Parameters");
            DropForeignKey("dbo.People", "IdHousingAssociation", "dbo.HousingAssociations");
            DropForeignKey("dbo.BankAccounts", "IdHousingAssociation", "dbo.HousingAssociations");
            DropIndex("dbo.ParametersPersons", new[] { "Person_IdPerson" });
            DropIndex("dbo.ParametersPersons", new[] { "Parameters_IdParameters" });
            DropIndex("dbo.Bills", new[] { "IdPerson" });
            DropIndex("dbo.People", new[] { "IdHousingAssociation" });
            DropIndex("dbo.BankAccounts", new[] { "IdHousingAssociation" });
            DropTable("dbo.ParametersPersons");
            DropTable("dbo.Bills");
            DropTable("dbo.Parameters");
            DropTable("dbo.People");
            DropTable("dbo.HousingAssociations");
            DropTable("dbo.BankAccounts");
        }
    }
}
