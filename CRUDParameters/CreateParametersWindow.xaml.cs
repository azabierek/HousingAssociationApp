using GalaSoft.MvvmLight.Command;
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

namespace HousingAssociationApp.CRUDParameters
{
    /// <summary>
    /// Logika interakcji dla klasy CreateParametersWindow.xaml
    /// </summary>
    public partial class CreateParametersWindow : Window
    {
        private readonly ParametersViewModel pvm;
        public CreateParametersWindow()
        {
            InitializeComponent();
            pvm = new ParametersViewModel();
            DataContext = pvm;
        }
        public CreateParametersWindow(int IdPerson)
        {
            InitializeComponent();
            pvm = new ParametersViewModel(IdPerson);
            DataContext = pvm;
            if (pvm.ActionClose == null)
                pvm.ActionClose = new Action(this.Close);
        }
    }
}
