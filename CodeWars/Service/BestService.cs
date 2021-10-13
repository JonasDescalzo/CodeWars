using CodeWars.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.Service
{
    public class BestService
    {
        #region Challenge #1: Duplicate Encoder
        //Challenge #1: Duplicate Encoder
        public string BestDuplicateEncoder(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }
        #endregion

        #region Challenge #2: Persistent Bugger
        //Challenge #2: Persistent Bugger
        public int Persistence(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }
        #endregion

        #region Challenge #3: Tribonacci Sequence
        //Challenge #3: Tribonacci Sequence

        #endregion

        #region Challenge #4: Regex validate PIN code
        //Challenge #4: Regex validate PIN code
        public bool ValidatePin(string pin)
        {
            //Top 1
            return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);

            //Top 2
            //return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
        }
        #endregion

        #region Challennge #5: Sum of odd numbers
        // Sum of odd numbers
        public long rowSumOddNumbers(long n) => (n * n * n);
        #endregion

        #region Challennge #6: Valid Braces
        // Sum of odd numbers
        public bool validBraces(String braces)
        {
            var st = new Stack<char>();
            foreach (var c in braces)
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        st.Push(c);
                        continue;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(') return false;
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[') return false;
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{') return false;
                        continue;
                }
            return st.Count == 0;
        }
        #endregion

        #region Challennge #7: Narcissistic Number
        // Does my number look big in this?
        public bool Narcissistic(int value)
        {
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        }
        #endregion

        #region Challennge #8: Decode the Morse code
        // Decode the Morse code
        public string Decode(string morseCode)
        {
            var words = morseCode.Trim().Split(new[] { "   " }, StringSplitOptions.None);
            var translatedWords = words.Select(word => word.Split(' ')).Select(letters => string.Join("", letters.Select(c => MorseCode.Get(c)))).ToList();
            return string.Join(" ", translatedWords);
        }
        #endregion

        #region Challennge #10: RGB To Hex Conversion
        // RGB To Hex Conversion
        public string Rgb(int r, int g, int b)
        {
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }
        #endregion

        #region Challennge #11: Are they the "same"?
        // Are they the "same"?
        public bool comp(int[] a, int[] b)
        {
            if ((a == null) || (b == null))
            {
                return false;
            }

            int[] copy = a.Select(x => x * x).ToArray();
            Array.Sort(copy);
            Array.Sort(b);

            return copy.SequenceEqual(b);
        }
        #endregion

        #region Challennge #12: The Supermarket Queue
        //The Supermarket Queue
        public long QueueTime(int[] customers, int n)
        {
            var registers = new List<int>(Enumerable.Repeat(0, n));

            foreach (int cust in customers)
            {
                registers[registers.IndexOf(registers.Min())] += cust;
            }
            return registers.Max();
        }
        #endregion

        #region Challennge #13: Write Number in Expanded Form
        //Write Number in Expanded Form
        public string ExpandedForm(long num)
        {
            var str = num.ToString();
            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
        }
        #endregion

        #region Challennge #14: Playing with digits
        //Playing with digits
        public long digPow(int n, int p)
        {
            var sum = Convert.ToInt64(n.ToString().Select(s => Math.Pow(int.Parse(s.ToString()), p++)).Sum());
            return sum % n == 0 ? sum / n : -1;
        }
        #endregion

        #region Challennge #16: Permutations
        //Permutations
        public List<string> SinglePermutations(string s)
        {
            // Your code here!
            List<string> returnstrings = new List<string>();
            if (s.Length == 1)
            {
                returnstrings.Add(s);
            }
            else
            {
                for (int x = 0; x < s.Length; x++)
                {
                    returnstrings.AddRange(SinglePermutations(s.Remove(x, 1)).Select(z => s[x] + z));
                }
            }

            return returnstrings.Distinct().ToList();
        }

        //public static List<string> SinglePermutations(string s)
        //{
        //    if (s.Length < 2)
        //    {
        //        return new List<string> { s };
        //    }
        //    var result = new HashSet<string>();
        //    foreach (var sub in SinglePermutations(s.Substring(1)))
        //    {
        //        for (int i = 0; i <= sub.Length; i++)
        //        {
        //            result.Add(sub.Substring(0, i) + s[0] + sub.Substring(i));
        //        }
        //    }
        //    return result.ToList();
        //}
        #endregion

        #region Challennge #17: First non-repeating character
        //First non-repeating character
        public string FirstNonRepeatingLetter(string s)
        {
            return s.GroupBy(char.ToLower)
                    .Where(gr => gr.Count() == 1)
                    .Select(x => x.First().ToString())
                    .DefaultIfEmpty("")
                    .First();
        }
        #endregion

        #region Challennge #18: Sum by Factors
        //Sum by Factors

        #endregion
    }
}
