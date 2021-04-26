using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class Parameters
    {
        [Key]
        public int IdParameters { get; set; }
        public double Surface { get; set; }
        public int QuantityOfPeople { get; set; }
        public double ColdWaterUsage { get; set; }
        public int QuantityOfAntennas { get; set; }
        public double HotWaterUsage { get; set; }

        public int IdPerson { get; set; }
        public virtual List<Person> Person { get; set; }

    }
}
