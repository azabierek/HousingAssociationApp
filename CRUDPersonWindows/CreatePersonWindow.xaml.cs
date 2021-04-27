using HousingAssociationApp.Model;
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

namespace HousingAssociationApp.CRUDPersonWindows
{
    /// <summary>
    /// Logika interakcji dla klasy CreatePersonWindow.xaml
    /// </summary>
    public partial class CreatePersonWindow : Window
    {
        private readonly PersonViewModel pvm;
        public CreatePersonWindow()
        {
            InitializeComponent();
            pvm = new PersonViewModel();
            DataContext = pvm;
          
            if (pvm.CloseAction == null)
                pvm.CloseAction = new Action(this.Close);
        }
    }
}
