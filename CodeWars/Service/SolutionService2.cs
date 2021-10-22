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
        #region Challennge #21: Alphabetic Anagrams [TIMEOUT]
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
            //int[] digits
            var digits = Array.ConvertAll(n.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));
            
            //List<int> sorted
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

            //long temp
            var temp = Convert.ToInt64(String.Join("", rightHalf));
            //List<string> permutations
            var permutations = Permutation(temp.ToString()).ToList();

            if (permutations.Count == 1)
            {
                return -1;
            }

            permutations.Sort();

            permutations = permutations.Where(c => c.ToString().Length == temp.ToString().Length).ToList();
            //int index
            var index = permutations.IndexOf(temp.ToString());
            //string result
            var result = index == 0 ? "-1" : permutations[index - 1];

            if (result == "-1")
            {
                return Convert.ToInt64(result);
            }

            var last = Convert.ToInt64(String.Join("", leftHalf) + result);

            return last;
        }
        #endregion

        #region Challennge #23: Twice linear [TIMEOUT]
        //Twice linear
        public int DblLinear(int n)
        {
            /*
            var Linears = new List<int>() { 1 };

            for (int i = 0; i <= n + 1; i++)
            {
                var Y = 2 * Linears[i] + 1; 
                var Z = 3 * Linears[i] + 1;

                Linears.AddRange(new List<int>() { Y, Z });

                Linears = Linears.Distinct().ToList();
                Linears.Sort();
            }

            return Linears[n];
            */

            var Linears = new List<int>() { 1 };

            for (int i = 0; i <= n + 1; i++)
            {
                var Y = 2 * Linears[i] + 1;
                var Z = 3 * Linears[i] + 1;

                Linears.AddRange(new List<int>() { Y, Z });

                Linears = Linears.Distinct().ToList();
                Linears.Sort();
            }

            return Linears[n];
        }
        #endregion

        #region Challennge #24: Square into Squares. Protect trees! [UNSOLVED]
        //Square into Squares. Protect trees!
        public string Decompose(long n)
        {
            var squared = n * n;

            var result = new List<int>();

            var squares = new int[n - 1];

            for (int i = 1; i < n; i++)
            {
                squares[i - 1] = i; 
            }

            for (int i = squares.Length - 1 ; i >= 0; i--)
            {
                if(squares[i] * squares[i] <= squared)
                {
                    result.Add(squares[i]);
                    squared -= squares[i] * squares[i];
                }
            }

            result.Reverse();

            var final_result = squared != 0 ? null : String.Join(" ", result);

            return final_result;
        }

        #endregion

        #region Challennge #25: Strings Mix
        //Strings Mix
        public string Mix(string s1, string s2)
        {
            var s1CharList = GetCharList(s1, "1:");
            var s1Strings = s1CharList.Select(c => c[2]).ToList();

            var s2CharList = GetCharList(s2, "2:");
            var s2Strings = s2CharList.Select(c => c[2]).ToList();

            var finalS1 = Finalize(s1Strings, s2Strings, s1CharList);
            var finalS2 = Finalize(s1Strings, s2Strings, s2CharList);

            var final = finalS1;

            for (int i = 0; i < final.Count; i++)
            {
                if (final[i].Length == finalS2[i].Length)
                {
                    final[i] = finalS1[i].Replace("1", "3");
                }
                else if (final[i].Length < finalS2[i].Length)
                {
                    final[i] = finalS2[i];
                }
            }

            final.Sort();

            final.Reverse();

            final = finalS1.OrderBy(a => a.Length).ToList();

            final.Reverse();

            for (int i = 0; i < final.Count; i++)
            {
                final[i] = final[i].Replace('3', '=');
            }

            var result = String.Join("/", final);

            return result;
        }

        public List<string> GetCharList(string sentence, string prefix)
        {
            //get letters
            var letters = sentence.Where(c => '`' < c && c < '{').ToList();
            letters.Sort();
            //get unique letters
            var uniqueLetters = letters.Distinct().ToList();

            var characterList = new List<string>();

            foreach (var u in uniqueLetters)
            {
                string tempList = "";

                foreach (var character in letters)
                {
                    if (u == character)
                    {
                        tempList += character;
                    }
                }

                if(tempList.Length > 1)
                {
                    tempList = prefix + tempList;
                    characterList.Add(tempList);
                }
            }

            return characterList;
        }

        public List<string> Finalize(List<char> s1List, List<char> s2List, List<string> charList)
        {
            var finalized = new List<string>();
            finalized.AddRange(s1List.Select(c => c.ToString()));
            finalized.AddRange(s2List.Select(c => c.ToString()));

            finalized = finalized.Distinct().ToList();

            foreach (var item in charList)
            {
                var a = finalized.IndexOf(item[2].ToString());

                if (finalized[a].Length < item.Length)
                {
                    finalized[a] = item;
                }
            }

            return finalized;
        }
        #endregion
    }
}
