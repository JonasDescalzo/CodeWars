using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CodeWars.Helpers;

namespace CodeWars.Service
{
    public class SolutionService2
    {
        #region Challennge #21: Alphabetic Anagrams
        //Alphabetic Anagrams
        public long ListPosition(string value)
        {
            var wordlist = Permutation(value.ToLower());

            wordlist.Sort();

            long position = wordlist.IndexOf(value.ToLower()) + 1;

            return position;
        }

        public static List<string> Permutation(string s)
        {
            if (s.Length < 2)
            {
                return new List<string> { s };
            }
            var result = new HashSet<string>();
            foreach (var sub in Permutation(s.Substring(1)))
            {
                for (int i = 0; i <= sub.Length; i++)
                {
                    result.Add(sub.Substring(0, i) + s[0] + sub.Substring(i));
                }

                var test = sub;
            }
            return result.ToList();
        }
        #endregion

        #region Challennge #22: Next smaller number with the same digits
        //Next smaller number with the same digits
        public long NextSmaller(long n)
        {
            #region Solution 1
            //var permutations = Permutation(n.ToString()).Select(c => Convert.ToInt64(c)).ToList();

            //if (permutations.Count == 1)
            //{
            //    return -1;
            //}

            //permutations.Sort();

            //permutations = permutations.Where(c => c.ToString().Length == n.ToString().Length).ToList();

            //var index = permutations.IndexOf(n);

            //var result = index == 0 ? -1 : permutations[index - 1];

            //return result;
            #endregion

            #region Solution 2
            //var digits = Array.ConvertAll(n.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

            //var leftHalf = new List<int>();
            //var rightHalf = new List<int>();


            //for (int i = digits.Count() - 1; i >= 0; i--)
            //{
            //    if (i == 0)
            //    {
            //        break;
            //    }

            //    if (digits[i] < digits[i - 1])
            //    {
            //        leftHalf = digits.Take(i - 1).ToList();
            //        rightHalf = digits.Skip(i - 1).ToList();
            //        break;
            //    }
            //}

            //var temp = Convert.ToInt64(String.Join("", rightHalf));

            //var permutations = Permutation(temp.ToString()).Select(c => Convert.ToInt64(c)).ToList();

            //if (permutations.Count == 1)
            //{
            //    return -1;
            //}

            //permutations.Sort();

            //permutations = permutations.Where(c => c.ToString().Length == temp.ToString().Length).ToList();

            //var index = permutations.IndexOf(temp);

            //var result = index == 0 ? -1 : permutations[index - 1];

            //var last = Convert.ToInt64(String.Join("", leftHalf) + result);

            //return last;
            #endregion

            #region Solution 3 ***
            var digits = Array.ConvertAll(n.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

            var sorted = digits.Distinct().ToList();
            sorted.Sort();

            var leftHalf = new List<int>();
            var rightHalf = new List<int>();


            for (int i = digits.Count() - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    break;
                }

                if (digits[i] < digits[i - 1])
                {
                    if (i == 1 && digits[i] == 0 && digits[i - 1] == sorted[1])
                    {
                        return -1;
                    }

                    leftHalf = digits.Take(i - 1).ToList();
                    rightHalf = digits.Skip(i - 1).ToList();
                    break;
                }
            }

            if(rightHalf.Count == 0)
            {
                return -1;
            }

            var temp = Convert.ToInt64(String.Join("", rightHalf));

            var permutations = Permutation(temp.ToString()).ToList();

            if (permutations.Count == 1)
            {
                return -1;
            }

            permutations.Sort();

            permutations = permutations.Where(c => c.ToString().Length == temp.ToString().Length).ToList();

            var index = permutations.IndexOf(temp.ToString());

            var result = index == 0 ? "-1" : permutations[index - 1];

            if (result == "-1")
            {
                return Convert.ToInt64(result);
            }

            var last = Convert.ToInt64(String.Join("", leftHalf) + result);

            return last;
            #endregion
        }
        #endregion
    }
}
