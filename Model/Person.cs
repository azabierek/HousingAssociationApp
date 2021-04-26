using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class Person
    {
        [Key]
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Housenumber { get; set; }
        public string PostCode { get; set; }
        public int IdHousingAssociation { get; set; }
        public virtual HousingAssociation HousingAssociation { get; set; }

        public virtual List<Parameters> Parameters { get; set; }


    }
}
