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
    }
}
