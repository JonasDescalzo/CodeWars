using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CodeWars.Helpers;

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
        public bool validBraces(String braces)
        {
            var Open = new List<char>();
            var Close = new List<char>();

            foreach (var character in braces)
            {
                if(character == '(' || character == '{' || character == '[')
                {
                    Open.Add(character);
                }

                if (character == ')' || character == '}' || character == ']')
                {
                    Close.Add(character);

                    if(Open.Count > 0 && ((Open.Last() == '(' && Close.Last() == ')') ||
                        (Open.Last() == '{' && Close.Last() == '}') || (Open.Last() == '[' && Close.Last() == ']')))
                    {
                        Open.RemoveAt(Open.Count - 1);
                        Close.RemoveAt(Close.Count - 1);
                    }
                }
            }

            return Open.Count == 0 && Close.Count == 0;
        }

        #endregion

        #region Challennge #7: Narcissistic Number
        // Does my number look big in this?
        public bool Narcissistic(int value)
        {
            double result = 0;
            
            var digits = Array.ConvertAll(value.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

            foreach (var n in digits)
            {
                result += Math.Pow(n, value.ToString().Length);
            }

            return result == value;
        }
        #endregion

        #region Challennge #8: Decode the Morse code
        // Decode the Morse code
        public string Decode(string morseCode)
        {
            string[] codes = morseCode.Trim().Split("   ");

            for (int i = 0; i < codes.Length; i++)
            {
                string[] letters = codes[i].Split(" ");

                for (int c = 0; c < letters.Length; c++)
                {
                    letters[c] = MorseCode.Get(letters[c]);
                }

                codes[i] = String.Join("", letters);
            }

            return String.Join(" ", codes);
        }
        #endregion

        #region Challennge #9: Find the missing letter
        // Find the missing letter
        public char FindMissingLetter(char[] array)
        {
            var num = array.Select(Convert.ToInt32).ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i + 1] - num[i] == 2)
                {
                    return Convert.ToChar(num[i] + 1);
                }
            }

            return ' ';
        }
        #endregion

        #region Challennge #10: RGB To Hex Conversion
        // RGB To Hex Conversion
        public string Rgb(int r, int g, int b)
        {
            var rgb_array = new int[] { r, g, b };

            var result = "";

            for (int i = 0; i < 3; i++)
            {
                rgb_array[i] = rgb_array[i] < 0 ? 0 : rgb_array[i];
                rgb_array[i] = rgb_array[i] > 255 ? 255 : rgb_array[i];

                int whole = rgb_array[i] / 16;
                int remainder = rgb_array[i] % 16;

                result += whole > 9 ? Convert.ToChar(whole + 55).ToString() : whole.ToString();
                result += remainder > 9 ? Convert.ToChar(remainder + 55).ToString() : remainder.ToString();
            }

            return result;
        }
        #endregion

        #region Challennge #11: Are they the "same"?
        // Are they the "same"?
        public bool comp(int[] a, int[] b)
        {
            if(a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            Array.Sort(a);
            Array.Sort(b);

            var result = true;

            for (int i = 0; i < a.Length; i++)
            {
                result = result && a[i] * a[i] == b[i];
            }

            return result;
        }
        #endregion

        #region Challennge #12: The Supermarket Queue
        //The Supermarket Queue
        public long QueueTime(int[] customers, int n)
        {
            var tills = new int[n];
            
            for (int i = 0; i < customers.Length; i++)
            {
                tills[0] += customers[i];
                Array.Sort(tills);
            }

            return Convert.ToInt64(tills[tills.Length - 1]);
        }
        #endregion

        #region Challennge #13: Write Number in Expanded Form
        //Write Number in Expanded Form
        public string ExpandedForm(long num)
        {
            var digits = Array.ConvertAll(num.ToString().ToCharArray(), c => (long)Char.GetNumericValue(c));

            for (int i = 0; i < digits.Count(); i++)
            {
                for (int o = i; o < digits.Count()-1; o++)
                {
                    digits[i] *= 10;
                }
            }

            return String.Join(" + ", digits.Where(c => c != 0).ToList());
        }
        #endregion

        #region Challennge #14: Playing with digits
        //Playing with digits
        public long digPow(int n, int p)
        {
            var digits = Array.ConvertAll(n.ToString().ToCharArray(), c => (long)Char.GetNumericValue(c));

            double sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += Math.Pow(digits[i], p + i);
            }

            var result = sum % n == 0 ? sum / n : -1;

            return Convert.ToInt64(result);
        }
        #endregion

        #region Challennge #15: PaginationHelper
        //PaginationHelper
        // Service > Challenge15
        #endregion

        #region Challennge #16: Permutations
        //Permutations
        public List<string> SinglePermutations(string s)
        {
            var indexes = new int[s.Length];

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }

            var list = new List<IList<int>>();

            var numbers = DoPermute(indexes, 0, indexes.Length - 1, list);

            var result = new List<string>();

            foreach (var item in numbers)
            {
                result.Add(intArrayToString(item, s));
            }

            return result.Distinct().ToList();
        }

        static string intArrayToString(IList<int> indexes, string word)
        {
            var newWord = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                newWord.Append(word[indexes[i]]);
            }

            return newWord.ToString();
        }

        static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Challennge #17: First non-repeating character
        //First non-repeating character
        public string FirstNonRepeatingLetter(string s)
        {
            var word = s.ToUpper();

            List<char> distincts = word.Distinct().ToList();

            var letters = new Dictionary<char, int>();

            for (int i = 0; i < distincts.Count; i++)
            {

                letters.Add(distincts[i], word.Where(c => c == distincts[i]).Count());
            }

            var test = word.IndexOf(letters.Where(c => c.Value == 1).FirstOrDefault().Key);

            var result = test == -1 ? "" : s[test].ToString();

            return result;
        }
        #endregion

        #region Challennge #18: Sum by Factors
        //Sum by Factors
        public string sumOfDivided(int[] lst)
        {
            var factors = new List<int>();

            foreach (var item in lst)
            {
                factors.Add(Math.Abs(item));
                factors.AddRange(getFactors(Math.Abs(item)));
            }

            factors = factors.Distinct().ToList();

            var primeFactors = factors.Where(f => getFactors(f).Count == 0).ToList();

            primeFactors.Sort();

            var result = new StringBuilder();

            for (int i = 0; i < primeFactors.Count; i++)
            {
                result.Append(String.Format("({0} {1})", primeFactors[i], lst.Where(n => n % primeFactors[i] == 0).Sum()));
            }

            return result.ToString();
        }

        private static List<int> getFactors(int number)
        {
            var factors = new List<int>();

            //number *= number < 0 ? -1 : 1; 

            for (int i = 2; i < number; i++)
            {

                if(number % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors;
        }
        #endregion

        #region Challennge #19: Directions Reduction
        //Directions Reduction
        public string[] dirReduc(String[] arr)
        {
            var result = new string[1];

            return arr;
        }
        #endregion


    }
}
