using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
