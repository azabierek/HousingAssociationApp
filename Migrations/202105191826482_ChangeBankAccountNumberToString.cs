namespace HousingAssociationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBankAccountNumberToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BankAccounts", "AccountNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BankAccounts", "AccountNumber", c => c.Long(nullable: false));
        }
    }
}
