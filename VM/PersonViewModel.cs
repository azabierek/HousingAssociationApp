using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousingAssociationApp.Model;

namespace HousingAssociationApp.VM
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person;
        private HousingAssociation hs;
        public List<HousingAssociation> HousingAssociations { get; set; }
        public PersonViewModel()
        {
            person = new Person();
            using (HouseDbContext hdb = new HouseDbContext()) HousingAssociations = hdb.HousingAssociations.ToList(); 
        }

        public HousingAssociation HousingAssociation { 
            get
            {
                return hs;
            }
            set
            {
                if (hs!=value)
                {
                    hs = value;
                    OnPropertyChange("HousingAssociation");
                }
            }
        }
        public string Name { get 
            {
                return person.Name;
            }
            set 
            {
                if (person.Name!=value)
                {
                    person.Name = value;
                    OnPropertyChange("Name");
                }
            } 
        }
        public string Surname
        {
            get
            {
                return person.Surname;
            }
            set
            {
                if (person.Surname != value)
                {
                    person.Surname = value;
                    OnPropertyChange("Surname");
                }
            }
        }
        public string City
        {
            get
            {
                return person.City;
            }
            set
            {
                if (person.City != value)
                {
                    person.City = value;
                    OnPropertyChange("City");
                }
            }
        }
        public string Street
        {
            get
            {
                return person.Street;
            }
            set
            {
                if (person.Street != value)
                {
                    person.Street = value;
                    OnPropertyChange("Street");
                }
            }
        }
        public string Housenumber
        {
            get
            {
                return person.Housenumber;
            }
            set
            {
                if (person.Housenumber != value)
                {
                    person.Housenumber = value;
                    OnPropertyChange("Housenumber");
                }
            }
        }
        public string PostCode
        {
            get
            {
                return person.PostCode;
            }
            set
            {
                if (person.PostCode != value)
                {
                    person.PostCode = value;
                    OnPropertyChange("PostCode");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
