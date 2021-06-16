using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class HABANKs
    {
        public BankAccount bank1 { get; set; }
        public BankAccount bank2 { get; set; }
        public HABANKs()
        {
            bank1 = new BankAccount()
            {
                AccountNumber = "-",
                BankName = "-"
            };
            bank2 = new BankAccount();
        }
    }
}
