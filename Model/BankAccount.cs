using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class BankAccount
    {
        [Key]
        public int IdBankAccount { get; set; }
        public string BankName { get; set; }
        public int AccountNumber { get; set; }

        public int IdHousingAssociation { get; set; }
        public virtual HousingAssociation HousingAssociation { get; set; }
    }
}
