using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class Bills
    {
        [Key]
        public int IdBills { get; set; }
        public decimal AccountStatus { get; set; }
        public DateTime Date { get; set; }
        public int IdPerson { get; set; }
    }
}
