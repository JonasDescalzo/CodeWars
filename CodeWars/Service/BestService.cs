using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Service
{
    public class BestService
    {
        //Challenge #1: Duplicate Encoder
        public string BestDuplicateEncoder(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }
    }
}
