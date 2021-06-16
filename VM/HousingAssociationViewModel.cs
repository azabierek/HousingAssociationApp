using GalaSoft.MvvmLight.Command;
using HousingAssociationApp.CRUDHousingAssociations;
using HousingAssociationApp.Model;
using HousingAssociationApp.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        #region INotifyImpementation
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

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
        HousingAssociation HousingAssociation { get; set; }
        HAPs haps { get; set; }
        HABANKs hBanks {get; set;}
        //HouseDbContext houseDb;

        public HousingAssociationViewModel()
        {
            HousingAssociation = new HousingAssociation();
            haps = new HAPs();
            hBanks = new HABANKs();
            using (HouseDbContext hdb = new HouseDbContext())
            {
                HousingList = hdb.HousingAssociations.ToList();
            }

                CommAddHousingAssociation = new RelayCommand<Window>((Window) =>
                {
                    try
                    {
                        using (HouseDbContext hdb = new HouseDbContext())
                        {

                            hdb.HousingAssociations.Add(HousingAssociation);
                            hdb.SaveChanges();
                            var lastHousingAssociationAddedId = hdb.HousingAssociations.ToList().Last().IdHousingAssociation;
                            if (hBanks.bank1.AccountNumber != null && hBanks.bank1.BankName != null)
                            {
                                hBanks.bank1.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.BankAccounts.Add(hBanks.bank1);

                            }
                            if (hBanks.bank2.AccountNumber != null && hBanks.bank2.BankName != null)
                            {
                                hBanks.bank2.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.BankAccounts.Add(hBanks.bank2);
                            }
                            if (haps.hap1.ParameterName != null)
                            {
                                haps.hap1.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap1);
                            }
                            if (haps.hap2.ParameterName != null)
                            {
                                haps.hap2.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap2);
                            }
                            if (haps.hap3.ParameterName != null)
                            {
                                haps.hap3.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap3);
                            }
                            if (haps.hap4.ParameterName != null)
                            {
                                haps.hap4.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap4);
                            }
                            if (haps.hap5.ParameterName != null)
                            {
                                haps.hap5.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap5);
                            }
                            if (haps.hap6.ParameterName != null)
                            {
                                haps.hap6.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap6);
                            }
                            if (haps.hap7.ParameterName != null)
                            {
                                haps.hap7.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap7);
                            }
                            if (haps.hap8.ParameterName != null)
                            {
                                haps.hap8.IdHousingAssociation = lastHousingAssociationAddedId;
                                hdb.HousingAssociationParameters.Add(haps.hap8);
                            }
                            hdb.SaveChanges();
                            Window.Close();
                            HousingList = hdb.HousingAssociations.ToList();
                        }
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("WYSTAPIŁ PROBLEM!\nTAKA NAZWA SPÓŁDZIELNI JUŻ ISTNIEJE, LUB SPRAWDŹ CZY DŁUGOŚĆ NAZWY NIE PRZEKRACZA 450 ZNAKÓW");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("WYSTĄPIŁ PROBLEM, ZGŁOŚ KOD BŁĘDU ADMINISTRATOROWI \n" + ex);
                    }
                    
                }, HousingAssociationAddingValidation);
        }
        
        bool HousingAssociationAddingValidation(Window ww)
        {
            //logic for checking all values, validation
            try
            {
                if (Name != null && NIP != null && Regon != 0 && City != null
                    && Street != null && PostCode != null && NumberOfHouse != 0)
                {
                    if (Name.Length > 2 && NIP.Length == 10 && City.Length > 2 && Street.Length > 2)
                    {
                        if (ValidationClass.WordValidation(Name,City) && ValidationClass.PostCodeValidation(PostCode)
                            && ValidationClass.IBANValidation(BankAccount1) &&  ValidationClass.IBANValidation(BankAccount2)
                            && ValidationClass.WriteWordValidation(BankName1) && ValidationClass.WriteWordValidation(BankName2)
                            && ValidationClass.WriteWordValidation(Parameter1) && ValidationClass.WriteWordValidation(Parameter2)
                            && ValidationClass.WriteWordValidation(Parameter3) && ValidationClass.WriteWordValidation(Parameter4)
                            && ValidationClass.WriteWordValidation(Parameter5) && ValidationClass.WriteWordValidation(Parameter6)
                            && ValidationClass.WriteWordValidation(Parameter7) && ValidationClass.WriteWordValidation(Parameter8))
                        {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #region Commands
        public RelayCommand<Window> CommAddHousingAssociation { get; private set; }

        #endregion
        #region Properties

        public string Name
        {
            get 
            { 
                return HousingAssociation.Name; 
            }
            set
            {
                if (HousingAssociation.Name!=value)
                {
                    HousingAssociation.Name = value;
                    OnPropertyChanged("Name");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }

        public string NIP
        {
            get
            {
                return HousingAssociation.NIP;
            }
            set
            {
                if (HousingAssociation.NIP != value)
                {
                    HousingAssociation.NIP = value;
                    OnPropertyChanged("NIP");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public int Regon
        {
            get
            {
                return HousingAssociation.Regon;
            }
            set
            {
                if (HousingAssociation.Regon != value)
                {
                    HousingAssociation.Regon = value;
                    OnPropertyChanged("Regon");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string City
        {
            get
            {
                return HousingAssociation.City;
            }
            set
            {
                if (HousingAssociation.City != value)
                {
                    HousingAssociation.City = value;
                    OnPropertyChanged("City");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Street
        {
            get
            {
                return HousingAssociation.Street;
            }
            set
            {
                if (HousingAssociation.Street != value)
                {
                    HousingAssociation.Street = value;
                    OnPropertyChanged("Street");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string PostCode
        {
            get
            {
                return HousingAssociation.PostCode;
            }
            set
            {
                if (HousingAssociation.PostCode != value)
                {
                    HousingAssociation.PostCode = value;
                    OnPropertyChanged("PostCode");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public int NumberOfHouse
        {
            get
            {
                return HousingAssociation.NumberOfHouse;
            }
            set
            {
                if (HousingAssociation.NumberOfHouse != value)
                {
                    HousingAssociation.NumberOfHouse = value;
                    OnPropertyChanged("NumberOfHouse");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        #region foreign tables needed informations
        public string Parameter1
        {
            get
            {
                return haps.hap1.ParameterName;
            }
            set
            {
                if (haps.hap1.ParameterName!=value)
                {
                    haps.hap1.ParameterName = value;
                    OnPropertyChanged("Parameter1");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter2
        {
            get
            {
                return haps.hap2.ParameterName;
            }
            set
            {
                if (haps.hap2.ParameterName != value)
                {
                    haps.hap2.ParameterName = value;
                    OnPropertyChanged("Parameter2");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter3
        {
            get
            {
                return haps.hap3.ParameterName;
            }
            set
            {
                if (haps.hap3.ParameterName != value)
                {
                    haps.hap3.ParameterName = value;
                    OnPropertyChanged("Parameter3");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter4
        {
            get
            {
                return haps.hap4.ParameterName;
            }
            set
            {
                if (haps.hap4.ParameterName != value)
                {
                    haps.hap4.ParameterName = value;
                    OnPropertyChanged("Parameter4");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter5
        {
            get
            {
                return haps.hap5.ParameterName;
            }
            set
            {
                if (haps.hap5.ParameterName != value)
                {
                    haps.hap5.ParameterName = value;
                    OnPropertyChanged("Parameter5");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter6
        {
            get
            {
                return haps.hap6.ParameterName;
            }
            set
            {
                if (haps.hap6.ParameterName != value)
                {
                    haps.hap6.ParameterName = value;
                    OnPropertyChanged("Parameter6");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter7
        {
            get
            {
                return haps.hap7.ParameterName;
            }
            set
            {
                if (haps.hap7.ParameterName != value)
                {
                    haps.hap7.ParameterName = value;
                    OnPropertyChanged("Parameter7");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string Parameter8
        {
            get
            {
                return haps.hap8.ParameterName;
            }
            set
            {
                if (haps.hap8.ParameterName != value)
                {
                    haps.hap8.ParameterName = value;
                    OnPropertyChanged("Parameter8");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }

        public string BankName1
        {
            get
            {
                return hBanks.bank1.BankName;
            }
            set
            {
                if (hBanks.bank1.BankName != value)
                {
                    hBanks.bank1.BankName = value;
                    OnPropertyChanged("BankName1");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();

                }
            }
        }
        public string BankAccount1
        {
            get
            {
                return hBanks.bank1.AccountNumber;
            }
            set
            {
                if (hBanks.bank1.AccountNumber != value)
                {
                    hBanks.bank1.AccountNumber = value;
                    OnPropertyChanged("BankAccount1");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();

                }
            }
        }

        public string BankName2
        {
            get
            {
                return hBanks.bank2.BankName;
            }
            set
            {
                if (hBanks.bank2.BankName != value)
                {
                    hBanks.bank2.BankName = value;
                    OnPropertyChanged("BankName2");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        public string BankAccount2
        {
            get
            {
                return hBanks.bank2.AccountNumber;
            }
            set
            {
                if (hBanks.bank2.AccountNumber != value)
                {
                    hBanks.bank2.AccountNumber = value;
                    OnPropertyChanged("BankAccount2");
                    CommAddHousingAssociation.RaiseCanExecuteChanged();
                }
            }
        }
        #endregion
        #endregion

    }
}
