using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HousingAssociationApp.WindowsChanging
{
    public class ControlChangeClass
    {
        public void ShowTextBlockControls(params TextBlock[] tb)
        {
            foreach (var item in tb)
                item.Visibility = Visibility.Visible;
        }
        public void HideTextBlockControls(params TextBlock[] tb)
        {
            foreach (var item in tb)
                item.Visibility = Visibility.Hidden;
        }

        public void ShowTextBoxControls(params TextBox[] tb)
        {
            foreach (var item in tb)
            {
                item.Visibility = Visibility.Visible;
                item.Text = "-";
            }

        }
        public void HideAndClearTextBoxControls(params TextBox[] tb)
        {
            foreach (var item in tb)
            {
                item.Text = null;
                item.Visibility = Visibility.Hidden;
            }
        }
    }
}
