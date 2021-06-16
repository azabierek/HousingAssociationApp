using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HousingAssociationApp.Validation
{
    public static class ValidationClass
    {

        public static bool NumberValidation(params string[] input)
        {
            var result = false;
            Regex regex = new Regex(@"^[0-9]+$");
            foreach (var item in input)
            {
                if (regex.IsMatch(item)) result = true;
                else return false;
            }

            return result;
        }
        public static bool PostCodeValidation(params string[] input)
        {
            var result = false;
            Regex regex = new Regex(@"^[0-9][0-9]-[0-9][0-9][0-9]$");
            foreach (var item in input)
            {
                if (regex.IsMatch(item)) result = true;
                else return false;
            }

            return result;
        }
        public static bool WordValidation(params string[] input)
        {
            var result = false;
            if (input.Length == 0) return false;
            Regex regex = new Regex(@"^[a-zA-ZąęłśćźńżóĄĘŁŚĆŻŃŹÓ\x20]+$");
            foreach (var item in input)
            {
                if (regex.IsMatch(item)) result = true;
                else return false;
            }

            return result;
        }
        public static bool WriteWordValidation(string input)
        {
                var result = false;
                Regex regex = new Regex(@"^[a-zA-ZąęłśćźńżóĄĘŁŚĆŻŃŹÓ\x20]+$");
                if (input==null)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    if (regex.IsMatch(input)) result = true;
                    
                }
                return result;
        }
        public static bool IBANValidation(string input)
        {
            var result = false;
            Regex regex = new Regex(@"^[0-9]{26}$");

                if (input==null)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    if (regex.IsMatch(input)) result = true;
                }

            return result;
        }
    }
}
