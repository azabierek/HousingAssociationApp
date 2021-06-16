using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class HouseDbContext : DbContext
    {
        public HouseDbContext() : base(@"Server=DESKTOP-7F8H54O\SQLEXPRESS;Database=master;Trusted_Connection=True;")
        {

        }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<HousingAssociation> HousingAssociations { get; set; }

        public DbSet<HousingAssociationParameters> HousingAssociationParameters { get; set; }
    }
}
