using HousingAssociationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HousingAssociationApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using(HouseDbContext hdb = new HouseDbContext())
            {


                hdb.BankAccounts.Add(new BankAccount()
                {
                    IdHousingAssociation = 2,
                    IdBankAccount = 2
                });

                hdb.HousingAssociations.Add(new HousingAssociation()
                {
                    IdHousingAssociation = 2,
                    Name = "ADS"
                });
                hdb.SaveChanges();

                foreach (var item in hdb.HousingAssociations)
                {
                    thisGrid.Children.Add(new Label()
                    {
                        Content = item.IdHousingAssociation,
                    });
                }
               
            }

        }
    }
}
