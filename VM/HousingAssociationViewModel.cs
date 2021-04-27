using GalaSoft.MvvmLight.Command;
using HousingAssociationApp.Model;
using HousingAssociationApp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HousingAssociationApp.VM
{
    public class HousingAssociationViewModel : INotifyPropertyChanged
    {
        ValidationClass vc;
        HousingAssociation housingAssociation;
        public ICommand CreateNewHousingAssociation { get; }
        public Action ActionClose {get;set;}
        bool CanUserAddHousingAssociation()
        {
            vc = new ValidationClass();
            var result = false;
            if (vc.WordValidation(housingAssociation.Name, housingAssociation.City, housingAssociation.Street) &&
                vc.PostCodeValidation(housingAssociation.PostCode))
            {
                result = true;
            }
            return result;
        }
        void OnAddHousingAssociation()
        {
            try
            {
                if (CanUserAddHousingAssociation())
                {
                    using (HouseDbContext hdb = new HouseDbContext())
                    {
                        hdb.HousingAssociations.Add(housingAssociation);
                        hdb.SaveChanges();
                        MessageBox.Show("DODANO SPÓŁDZIELNIE!");
                        ActionClose();
                    }
                }
                else
                {
                    MessageBox.Show("BŁĄD WALIDACJI PÓL, SPRAWDŹ I POPRAW POLA WPISU");
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("UZUPEŁNIJ POLA WARTOŚCIAMI!\nPOLA NIE MOGĄ ZOSTAĆ PUSTE!");
            }
            catch (Exception)
            {
                throw;
            }

        }
        public HousingAssociationViewModel()
        {
            housingAssociation = new HousingAssociation();
            CreateNewHousingAssociation = new RelayCommand(OnAddHousingAssociation);
        }
        public string Name
        { 
            get
            {
                return housingAssociation.Name;
            }
            set
            {
                if (housingAssociation.Name!=value)
                {
                    housingAssociation.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string NIP
        {
            get
            {
                return housingAssociation.NIP;
            }
            set
            {
                if (housingAssociation.NIP != value)
                {
                    housingAssociation.NIP = value;
                    OnPropertyChanged("NIP");
                }
            }
        }
        public int Regon
        {
            get
            {
                return housingAssociation.Regon;
            }
            set
            {
                if (housingAssociation.Regon != value)
                {
                    housingAssociation.Regon = value;
                    OnPropertyChanged("Regon");
                }
            }
        }
        public string City
        {
            get
            {
                return housingAssociation.City;
            }
            set
            {
                if (housingAssociation.City != value)
                {
                    housingAssociation.City = value;
                    OnPropertyChanged("City");
                }
            }
        }

        public string Street
        {
            get
            {
                return housingAssociation.Street;
            }
            set
            {
                if (housingAssociation.Street != value)
                {
                    housingAssociation.Street = value;
                    OnPropertyChanged("Street");
                }
            }
        }
        public string PostCode
        {
            get
            {
                return housingAssociation.PostCode;
            }
            set
            {
                if (housingAssociation.PostCode != value)
                {
                    housingAssociation.PostCode = value;
                    OnPropertyChanged("PostCode");
                }
            }
        }

        public int NumberOfHouse
        {
            get
            {
                return housingAssociation.NumberOfHouse;
            }
            set
            {
                if (housingAssociation.NumberOfHouse != value)
                {
                    housingAssociation.NumberOfHouse = value;
                    OnPropertyChanged("NumberOfHouse");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
