using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class HousingAssociation
    {
        [Key]
        public int IdHousingAssociation { get; set; }
        [StringLength(450)]
        [Index(IsUnique=true)]
        public string Name { get; set; }
        public string NIP { get; set; }
        public int Regon { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public int NumberOfHouse { get; set; }
        public virtual List<BankAccount> BankAccount { get; set; }
        public virtual List<Person> Person { get; set; }

        public virtual List<HousingAssociationParameters> HousingAssociationParameters { get;set;}

    }
}
