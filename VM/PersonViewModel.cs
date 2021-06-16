using HousingAssociationApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAssociationApp.VM
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        Person person { get; set; }

        List<HousingAssociation> hList;

        public List<HousingAssociation> HousingList
        {
            get
            {
                return hList;
            }
            set
            {
                if (hList != value)
                {
                    hList = value;
                    OnPropertyChanged("HousingList");
                }
            }
        }
        public PersonViewModel()
        {
            person = new Person()
            {
                Name = "Adrian",
                Surname = "Żabierek"
            };
            using(HouseDbContext hdb = new HouseDbContext())
            {
                hList = hdb.HousingAssociations.ToList();
            }
        }

        public string Name
        {
            get
            {
                return person.Name;
            }
            set
            {
                if (person.Name!=value)
                {
                    person.Name = value;
                    OnPropertyChanged("Name");
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
                if (person.Surname!=value)
                {
                    person.Surname = value;
                    OnPropertyChanged("Surname");
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
                    OnPropertyChanged("City");
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
                    OnPropertyChanged("Street");
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
                if (person.Housenumber!=value)
                {
                    person.Housenumber = value;
                    OnPropertyChanged("Housenumber");
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
                if (person.PostCode!=value)
                {
                    person.PostCode = value;
                    OnPropertyChanged("PostCode");
                }
            }
        }


    }
}
