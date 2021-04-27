using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using HousingAssociationApp.Model;
using HousingAssociationApp.Validation;

namespace HousingAssociationApp.VM
{
    public class ParametersViewModel : INotifyPropertyChanged
    {
        //creating new parameters
        public ParametersViewModel()
        {
            p = new Parameters();
        }
        //creating new parameters with PERSON ID'S
        public ParametersViewModel(int IdPerson)
        {
            p = new Parameters();
            p.IdPerson = IdPerson;
            CreateNewParameter = new RelayCommand(OnCreateNewParameter);
        }
        private Parameters p { get; set; }
        public ICommand CreateNewParameter { get; set; }
        public Action ActionClose { get; set; }
        void OnCreateNewParameter()
        {
            try
            {
                using (HouseDbContext hdb = new HouseDbContext())
                {
                    hdb.Parameters.Add(p);
                    hdb.SaveChanges();
                    MessageBox.Show("DODANO PARAMETRY DO OSOBY");
                    ActionClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public int IdParameters 
        {
            get
            {
                return p.IdParameters;
            }
            set
            {
                if (p.IdParameters!=value)
                {
                    p.IdParameters = value;
                    OnPropertyChanged("IdParameters");
                }
            }
        }
        public int IdPerson
        {
            get
            {
                return p.IdPerson;
            }
            set
            {
                if (p.IdPerson != value)
                {
                    p.IdPerson = value;
                    OnPropertyChanged("IdPerson");
                }
            }
        }
        public double Surface
        {
            get
            {
                return p.Surface;
            }
            set
            {
                if (p.Surface!=value)
                {
                    p.Surface = value;
                    OnPropertyChanged("Surface");
                }
            }
        }

        public int QuantityOfPeople
        {
            get
            {
                return p.QuantityOfPeople;
            }
            set
            {
                if (p.QuantityOfPeople != value)
                {
                    p.QuantityOfPeople = value;
                    OnPropertyChanged("QuantityOfPeople");
                }
            }
        }
        public int QuantityOfAntennas
        {
            get
            {
                return p.QuantityOfAntennas;
            }
            set
            {
                if (p.QuantityOfAntennas != value)
                {
                    p.QuantityOfAntennas = value;
                    OnPropertyChanged("QuantityOfAntennas");
                }
            }
        }
        public double ColdWaterUsage
        {
            get
            {
                return p.ColdWaterUsage;
            }
            set
            {
                if (p.ColdWaterUsage != value)
                {
                    p.ColdWaterUsage = value;
                    OnPropertyChanged("ColdWaterUsage");
                }
            }
        }
        public double DeclaredColdWaterUsage
        {
            get
            {
                return p.DeclaredColdWaterUsage;
            }
            set
            {
                if (p.DeclaredColdWaterUsage != value)
                {
                    p.DeclaredColdWaterUsage = value;
                    OnPropertyChanged("DeclaredColdWaterUsage");
                }
            }
        }
        public double HotWaterUsage
        {
            get
            {
                return p.HotWaterUsage;
            }
            set
            {
                if (p.HotWaterUsage != value)
                {
                    p.HotWaterUsage = value;
                    OnPropertyChanged("HotWaterUsage");
                }
            }
        }
        public double DeclaredHotWaterUsage
        {
            get
            {
                return p.DeclaredHotWaterUsage;
            }
            set
            {
                if (p.DeclaredHotWaterUsage != value)
                {
                    p.DeclaredHotWaterUsage = value;
                    OnPropertyChanged("DeclaredHotWaterUsage");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged!=null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
