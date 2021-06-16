using HousingAssociationApp.VM;
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
using System.Windows.Shapes;

namespace HousingAssociationApp.CRUDPerson
{
    /// <summary>
    /// Logika interakcji dla klasy CreatePersonWindow.xaml
    /// </summary>
    public partial class CreatePersonWindow : Window
    {
        PersonViewModel vm;
        public CreatePersonWindow()
        {
            InitializeComponent();
            vm = new PersonViewModel();
            DataContext = vm;
        }

    }
}
