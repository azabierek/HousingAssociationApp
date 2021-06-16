using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HousingAssociationApp.MessageBoxesWindows
{
    static class CloseWindowsClass
    {
        public static void CloseWindows()
        {
            foreach (Window item in App.Current.Windows)
            {
                if (item is MainWindow)
                {

                }
                else
                {
                    item.Close();
                }
            }
        }
    }
}
