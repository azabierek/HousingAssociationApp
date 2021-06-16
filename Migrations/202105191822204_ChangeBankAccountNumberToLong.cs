namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBankAccountNumberToLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BankAccounts", "AccountNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BankAccounts", "AccountNumber", c => c.Int(nullable: false));
        }
    }
}
