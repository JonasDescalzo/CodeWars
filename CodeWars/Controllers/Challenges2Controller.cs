using CodeWars.Models;
using CodeWars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Controllers
{
    public class Challenges2Controller : Controller
    {
        #region Object and Constructor
        public SolutionService2 _solutionService2;

        public Challenges2Controller(SolutionService2 solutionService2)
        {
            _solutionService2 = solutionService2;
        }
        #endregion

        #region Challennge #21: Alphabetic Anagrams
        //Alphabetic Anagrams
        [HttpPost("alphabetic-anagrams/{word}")]
        public IActionResult AlphabeticAnagrams(string word)
        {
            var response = _solutionService2.ListPosition(word);

            return Ok(response);
        }
        #endregion
    }
}
