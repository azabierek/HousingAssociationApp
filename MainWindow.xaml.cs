using HousingAssociationApp.CRUDHousingAssociations;
using HousingAssociationApp.CRUDPerson;
using HousingAssociationApp.Model;
using HousingAssociationApp.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public HousingAssociationViewModel mwvm;

        public MainWindow()
        {
            InitializeComponent();
            mwvm = new HousingAssociationViewModel();
            mwvm.NIP = "999999999";
            DataContext = mwvm;
        }

        private void CreateHousingAssociationClick(object sender, RoutedEventArgs e)
        {
            CreateHousingAssociationWindow c = new CreateHousingAssociationWindow(mwvm);
            c.Visibility = 0;
        }

        private void CreatePersonClick(object sender, RoutedEventArgs e)
        {
            CreatePersonWindow c = new CreatePersonWindow();
            c.Visibility = 0;
        }
    }

}
