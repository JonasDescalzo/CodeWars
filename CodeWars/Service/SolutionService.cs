using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
