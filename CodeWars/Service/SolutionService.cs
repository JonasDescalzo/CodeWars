using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeWars.Service
{
    public class SolutionService
    {
        #region Challenge #1: DuplicateEncoder
        //Challenge #1: Duplicate Encoder
        public string DuplicateEncoder(string word)
        {

            word = word.ToLower();

            List<char> distincts = word.Distinct().ToList();

            var uniques = "";

            var newString = "";

            foreach (var item in distincts)
            {
                var count = 0;

                foreach (var element in word)
                {
                    count += item == element ? 1 : 0;
                }

                uniques += count < 2 ? item + "" : "";
            }

            foreach (var item in word)
            {
                newString += uniques.Contains(item) ? "(" : ")";
            }

            return newString;
        }
        #endregion

        #region Challenge #2: Persistent Bugger
        //Challenge #2: Persistent Bugger
        public int Persistence(long number)
        {
            if(number.ToString().Length == 1)
            {
                return 0;
            }

            var ArrayOfNumbers = Array.ConvertAll(number.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));
            var counter = 0;

            do
            {
                var Product = 1;

                foreach (var item in ArrayOfNumbers)
                {
                    Product *= item;
                }

                counter++;
                ArrayOfNumbers = Array.ConvertAll(Product.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

            } while (ArrayOfNumbers.Count() > 1);

            return counter;
        }
        #endregion

        #region Challenge #3: Tribonacci Sequence
        //Challenge #3: Tribonacci Sequence

        #endregion

        #region Challenge #4: Regex validate PIN code
        //Challenge #4: Regex validate PIN code
        public bool ValidatePin(string pin)
        {
            foreach (char c in pin)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return pin.Length == 4 || pin.Length == 6;
        }
        #endregion
    }
}
