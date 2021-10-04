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
        public double[] Tribonacci(double[] signature, int n) // new double []{1,1,1}, 10
        {
            var result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = signature.Length - 1 >= i ? signature[i] : 0;
            }

            for (int i = 3; i < n; i++)
            {
                result[i] = signature.Sum();
                signature[0] = signature[1];
                signature[1] = signature[2];
                signature[2] = result[i];
            }

            return result;
        }
        //expected: 1, 1, 1, 3, 5, 9, 17, 31, 57, 105

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

        #region Challennge #5: Sum of odd numbers
        // Sum of odd numbers
        public long rowSumOddNumbers(long n)
        {
            long sum = 0;

            long oddNumbersCount = n;

            for (int i = 0; i < n; i++)
            {
                oddNumbersCount += i;
            }

            var rowNumbers = new List<long>();

            long index = 0;
            while (rowNumbers.Count < oddNumbersCount)
            {

                if (index % 2 == 1)
                {
                    rowNumbers.Add(index);
                }

                index++;
            }

            for (var i = 1; i <= n; i++)
            {
                sum += rowNumbers[rowNumbers.Count - i];
            }

            return sum;
        }

        #endregion

        #region Challennge #6: Valid Braces
        // Sum of odd numbers

        #endregion
    }
}
