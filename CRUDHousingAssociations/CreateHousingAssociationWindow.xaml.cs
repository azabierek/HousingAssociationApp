using HousingAssociationApp.VM;
using HousingAssociationApp.WindowsChanging;
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

namespace HousingAssociationApp.CRUDHousingAssociations
{
    /// <summary>
    /// Logika interakcji dla klasy CreateHousingAssociationWindow.xaml
    /// </summary>
    public partial class CreateHousingAssociationWindow : Window
    {
        ControlChangeClass ccc;
        public CreateHousingAssociationWindow()
        {
            InitializeComponent();

        }
        public CreateHousingAssociationWindow(HousingAssociationViewModel havm)
        {
            InitializeComponent();
            
            ccc = new ControlChangeClass();
            DataContext = havm;
        }


        private void QuantityBankAccountCBoxChange(object sender, SelectionChangedEventArgs e)
        {
            var picked = e.Source as ComboBox;
            ccc.HideTextBlockControls(B1TBlock,B2TBlock, BankNameTBlock, BankAccountTBlock);
            ccc.HideAndClearTextBoxControls(B1TBox, B2TBox, B1TBoxName, B2TBoxName);
            switch (Convert.ToInt32(picked.SelectedIndex))
            {
                case 0:
                    ccc.ShowTextBlockControls(B1TBlock, BankNameTBlock, BankAccountTBlock);
                    ccc.ShowTextBoxControls(B1TBoxName, B1TBox);
                    break;
                case 1:
                    ccc.ShowTextBlockControls(B1TBlock, B2TBlock, BankNameTBlock, BankAccountTBlock);
                    ccc.ShowTextBoxControls(B1TBox, B1TBoxName, B2TBox, B2TBoxName);
                    break;

                default:
                    break;
            }
        }

        private void QuantityParametersCboxChange(object sender, SelectionChangedEventArgs e)
        {
            var picked = e.Source as ComboBox;
            ccc.HideTextBlockControls(P1TBlock, P2TBlock, P3TBlock, P4TBlock, P5TBlock, P6TBlock, P7TBlock, P8TBlock);
            ccc.HideAndClearTextBoxControls(P1TBox, P2TBox, P3TBox, P4TBox, P5TBox, P6TBox, P7TBox, P8TBox);
            switch (Convert.ToInt32(picked.SelectedIndex))
            {
                case 0:
                    ccc.ShowTextBlockControls(P1TBlock);
                    ccc.ShowTextBoxControls(P1TBox);
                    break;
                case 1:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox);
                    break;
                case 2:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock, P3TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox, P3TBox);
                    break;
                case 3:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock, P3TBlock, P4TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox, P3TBox, P4TBox);
                    break;
                case 4:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock, P3TBlock, P4TBlock, P5TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox, P3TBox, P4TBox, P5TBox);
                    break;
                case 5:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock, P3TBlock, P4TBlock, P5TBlock, P6TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox, P3TBox, P4TBox, P5TBox, P6TBox);
                    break;
                case 6:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock, P3TBlock, P4TBlock, P5TBlock, P6TBlock, P7TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox, P3TBox, P4TBox, P5TBox, P6TBox, P7TBox);
                    break;
                case 7:
                    ccc.ShowTextBlockControls(P1TBlock, P2TBlock, P3TBlock, P4TBlock, P5TBlock, P6TBlock, P7TBlock, P8TBlock);
                    ccc.ShowTextBoxControls(P1TBox, P2TBox, P3TBox, P4TBox, P5TBox, P6TBox, P7TBox, P8TBox);
                    break;
                default:
                    break;
            }
        }

    }
}
