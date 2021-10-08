using CodeWars.Helpers;
using CodeWars.Models;
using CodeWars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestController : ControllerBase
    {
        #region Object and Constructor
        public BestService _bestService;

        public BestController(BestService bestService)
        {
            _bestService = bestService;
        }
        #endregion

        #region Challenge #1: Duplicate Encoder
        //Challenge #1: Duplicate Encoder
        [HttpGet("best-duplicate-encoder/{word}")]
        public IActionResult BestDuplicateEncoder(string word)
        {
            var response = _bestService.BestDuplicateEncoder(word);

            return Ok(response);
        }
        #endregion

        #region Challenge #2: Persistent Bugger
        //Challenge #2: Persistent Bugger
        [HttpGet("best-persistent-bugger/{number}")]
        public IActionResult Persistence(long number)
        {
            var response = _bestService.Persistence(number);

            return Ok(response);
        }
        #endregion

        #region Challenge #3: Tribonacci Sequence
        //Challenge #3: Tribonacci Sequence
        #endregion

        #region Challenge #4: Regex validate PIN code
        //Challenge #4: Regex validate PIN code
        [HttpGet("best-validate-pin/{pin}")]
        public IActionResult ValidatePin(string pin)
        {
            var response = _bestService.ValidatePin(pin);

            return Ok(response);
        }
        #endregion

        #region Challennge #5: Sum of odd numbers
        // Sum of odd numbers
        [HttpGet("best-sum-of-odd-numbers/{number}")]
        public IActionResult RowSumOddNumbers(long number)
        {
            var response = _bestService.rowSumOddNumbers(number);

            return Ok(response);
        }
        #endregion

        #region Challennge #6: Valid Braces
        // Sum of odd numbers
        [HttpGet("best-valid-braces/{braces}")]
        public IActionResult ValidBraces(string braces)
        {
            var response = _bestService.validBraces(braces);

            return Ok(response);
        }
        #endregion

        #region Challennge #7: Narcissistic Number
        // Does my number look big in this?
        [HttpGet("best-narcissistic-number/{value}")]
        public IActionResult Narcissistic(int value)
        {
            var response = _bestService.Narcissistic(value);

            return Ok(response);
        }
        #endregion

        #region Challennge #8: Decode the Morse code
        // Decode the Morse code
        [HttpGet("best-decode-morse-code/{message}")]
        public IActionResult DecodeMorseCode(string message)
        {
            var response = _bestService.Decode(message);

            return Ok(response);
        }
        #endregion

        #region Challennge #10: RGB To Hex Conversion
        // RGB To Hex Conversion
        
        [HttpPost("best-rgb-to-hex/{r}/{g}/{b}")]
        public IActionResult Rgb(int r, int g, int b)
        {
            var response = _bestService.Rgb(r, g, b);

            return Ok(response);
        }
        #endregion

        #region Challennge #11: Are they the "same"?
        // Are they the "same"?
        [HttpGet("best-compare-square-array/")]
        public IActionResult CompareSquareArray()
        {
            var a = new int[] { 0, 0, 0 };
            var b = new int[] { 0, 0, 0 };

            var response = _bestService.comp(a, b);

            return Ok(response);
        }
        #endregion

        #region Challennge #12: The Supermarket Queue
        //The Supermarket Queue
        [HttpGet("best-supermarket-queue/")]
        public IActionResult SupermarketQueue(SuperMarketQueue request)
        {
            var response = _bestService.QueueTime(request.customers, request.n);

            return Ok(response);
        }
        #endregion

        #region Challennge #13: Write Number in Expanded Form
        //Write Number in Expanded Form
        [HttpGet("best-supermarket-queue/{number}")]
        public IActionResult ExpandNumber(long number)
        {
            var response = _bestService.ExpandedForm(number);

            return Ok(response);
        }

        #endregion
    }
}
