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

namespace HousingAssociationApp.CRUDHousingAssociationWindows
{
    /// <summary>
    /// Logika interakcji dla klasy CreateHousingAssociationWindow.xaml
    /// </summary>
    public partial class CreateHousingAssociationWindow : Window
    {
        private readonly HousingAssociationViewModel havm;
        public CreateHousingAssociationWindow()
        {
            InitializeComponent();
            havm = new HousingAssociationViewModel();
            DataContext = havm;
            
            if (havm.ActionClose == null)
                havm.ActionClose = new Action(this.Close);
            

        }
    }
}
