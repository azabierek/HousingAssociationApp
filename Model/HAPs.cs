using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.Model
{
    public class HAPs
    {
        public HousingAssociationParameters hap1 { get; set; }
        public HousingAssociationParameters hap2 { get; set; }
        public HousingAssociationParameters hap3 { get; set; }
        public HousingAssociationParameters hap4 { get; set; }
        public HousingAssociationParameters hap5 { get; set; }
        public HousingAssociationParameters hap6 { get; set; }
        public HousingAssociationParameters hap7 { get; set; }
        public HousingAssociationParameters hap8 { get; set; }
        public HAPs()
        {
            hap1 = new HousingAssociationParameters()
            {
                ParameterName = "-"
            };
            hap2 = new HousingAssociationParameters();
            hap3 = new HousingAssociationParameters();
            hap4 = new HousingAssociationParameters();
            hap5 = new HousingAssociationParameters();
            hap6 = new HousingAssociationParameters();
            hap7 = new HousingAssociationParameters();
            hap8 = new HousingAssociationParameters();
        }
    }
}
