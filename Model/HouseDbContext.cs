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
        public HouseDbContext() : base(@"Server=192.168.3.204\SQLEXPRESS;Database=Test;Trusted_Connection=True;")
        {

        }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<HousingAssociation> HousingAssociations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Parameters> Parameters { get; set; }

        public DbSet<Benefit> Benefits { get; set; }
        
    }
}
