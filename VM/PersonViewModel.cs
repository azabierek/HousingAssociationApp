using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using HousingAssociationApp.Model;
using HousingAssociationApp.Validation;

namespace HousingAssociationApp.VM
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person;
        private HousingAssociation hs;
        private ValidationClass vc;
        public ICommand CreateNewPerson { get; }
        public Action CloseAction { get; set; }
        public List<HousingAssociation> HousingAssociations { get; set; }
        //Inserting NEW PERSON!
        public PersonViewModel()
        {
            person = new Person();
            using (HouseDbContext hdb = new HouseDbContext()) HousingAssociations = hdb.HousingAssociations.ToList();
            //CreateNewPerson = new RelayCommand(OnAddPersonClick,CanUserAddPerson);
            CreateNewPerson = new RelayCommand(OnAddPersonClick);
        }

        //Another constructor - MODIFY EXISTING PERSON.

        bool CanUserAddPerson()
        {
            var result = false;
            vc = new ValidationClass();
            if (vc.WordValidation(person.Name, person.Surname, person.City, person.Street) && vc.PostCodeValidation(person.PostCode)) result = true;
            return result;
        }
        void OnAddPersonClick()
        {
            try
            {
                if (CanUserAddPerson())
                {
                    using (HouseDbContext hdb = new HouseDbContext())
                    {
                        person.IdHousingAssociation = hs.IdHousingAssociation;
                        hdb.Persons.Add(person);
                        hdb.SaveChanges();
                        MessageBox.Show("DODANO OSOBĘ!");
                        CloseAction();
                    }
                }
                else
                {
                    MessageBox.Show("WALIDACJA PÓL PRZESZŁA NIEPOMYŚLNIE, SPRAWDŹ WPISY I POPRAW");
                }
                

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("UZUPEŁNIJ POLA WARTOŚCIAMI!\nPOLA NIE MOGĄ ZOSTAĆ PUSTE!");
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("UZUPEŁNIJ DANE OSOBY");
            }
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
