using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HousingAssociationApp.Validation
{
    public class ValidationClass
    {
        public bool NumberValidation(params string[] input)
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
        public bool PostCodeValidation(params string[] input)
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
        public bool WordValidation(params string[] input)
        {
            var result = false;
            if (input.Length == 0) return false;
            Regex regex = new Regex(@"^[a-zA-ZąłśćżńżĄŁŚĆŻŃŹ\x20]+$");
            foreach (var item in input)
            {
                if (regex.IsMatch(item)) result = true;
                else return false;
            }

            return result;
        }
    }
}
