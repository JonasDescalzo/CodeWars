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

        #region Challennge #22: Next smaller number with the same digits
        //Next smaller number with the same digits
        [HttpPost("next-smaller-number/{number}")]
        public IActionResult NextSmaller(long number)
        {
            var response = _solutionService2.NextSmaller(number);

            return Ok(response);
        }
        #endregion

        #region Challennge #23: Twice linear
        //Twice linear
        [HttpPost("twice-linear/{number}")]
        public IActionResult TwiceLinear(int number)
        {
            var response = _solutionService2.DblLinear(number);

            return Ok(response);
        }
        #endregion

        #region Challennge #24: Square into Squares. Protect trees!
        //Square into Squares. Protect trees!
        [HttpPost("decompose-square/{number}")]
        public IActionResult Decompose(long number)
        {
            var response = _solutionService2.Decompose(number);

            return Ok(response);
        }
        #endregion

        #region Challennge #25: Strings Mix
        //Strings Mix
        [HttpPost("strings-mix/{s1}/{s2}")]
        public IActionResult Decompose(string s1, string s2)
        {
            var response = _solutionService2.Mix(s1, s2);

            return Ok(response);
        }
        #endregion

        #region Challennge #26: Conway's Game of Life - Unlimited Edition
        //Conway's Game of Life - Unlimited Edition
        [HttpGet("game-of-life/")]
        //public IActionResult ConwayGame()
        public IActionResult ConwayGame()
        {
            var sample = new int[,] { { 1, 0, 0 }, { 0, 1, 1 }, { 1, 1, 0 } };

            var response = _solutionService2.GetGeneration(sample, 1);

            var result = "=";

            var squareRoot = Math.Sqrt(response.Length);

            foreach (var item in response)
            {
                var addedString = result.Length % (squareRoot + 1) == 0 ? "-" : "";

                result += addedString + item;
            }

            result = result.Replace("-","\n").Replace("=", "");

            return Ok(result);
        }
        #endregion

        #region Challennge #27: Range Extraction
        //Range Extraction
        [HttpGet("range-extraction/")]
        public IActionResult RangeExtraction()
        {
            var intArray = new int[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };

            var response = _solutionService2.Extract(intArray);

            return Ok(response);
        }
        #endregion
    }
}
