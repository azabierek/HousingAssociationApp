using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class Benefit
    {
        [Key]
        public int IdBenefit { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Parameter { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BruttoPrice { get; set; }

        public virtual List<Person> People { get; set; }
    }
}
