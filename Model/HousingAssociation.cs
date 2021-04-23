using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class HousingAssociation
    {
        [Key]
        public int IdHousingAssociation { get; set; }
        public string Name { get; set; }
        public int NIP { get; set; }
        public int Regon { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string NumberOfHouse { get; set; }
        public string BankName { get; set; }
        public virtual List<BankAccount> BankAccount { get; set; }

    }
}
