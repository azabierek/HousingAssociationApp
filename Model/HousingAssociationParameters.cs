using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class HousingAssociationParameters
    {
        [Key]
        public int IdHousingAssociationParameters { get; set; }
        public string ParameterName { get; set; }

        public int IdHousingAssociation { get; set; }
        public HousingAssociation HousingAssociation { get; set; }
    }
}
