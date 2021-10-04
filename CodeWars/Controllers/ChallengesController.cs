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
    public class ChallengesController : ControllerBase
    {
        #region Object and Constructor
        public SolutionService _solutionService;

        public ChallengesController(SolutionService solutionService)
        {
            _solutionService = solutionService;
        }
        #endregion

        #region Challenge #1: DuplicateEncoder
        //Challenge #1: Duplicate Encoder
        [HttpGet("duplicate-encoder/{word}")]
        public IActionResult DuplicateEncoder(string word)
        {
            var response = _solutionService.DuplicateEncoder(word);

            return Ok(response);
        }
        #endregion

        #region Challenge #2: Persistent Bugger
        //Challenge #2: Persistent Bugger
        [HttpGet("persistent-bugger/{number}")]
        public IActionResult Persistence(long number)
        {
            var response = _solutionService.Persistence(number);

            return Ok(response);
        }
        #endregion

        #region Challenge #3: Tribonacci Sequence
        //Challenge #3: Tribonacci Sequence
        [HttpGet("tribonacci/")]
        public IActionResult Tribonacci()
        {
            var response = _solutionService.Tribonacci(new double[] { 1, 1, 1 }, 10);

            return Ok(response);
        }
        #endregion

        #region Challenge #4: Regex validate PIN code
        //Challenge #4: Regex validate PIN code
        [HttpGet("validate-pin/{pin}")]
        public IActionResult ValidatePin(string pin)
        {
            var response = _solutionService.ValidatePin(pin);

            return Ok(response);
        }
        #endregion

        #region Challennge #5: Sum of odd numbers
        // Sum of odd numbers
        [HttpGet("sum-of-odd-numbers/{number}")]
        public IActionResult RowSumOddNumbers(long number)
        {
            var response = _solutionService.rowSumOddNumbers(number);

            return Ok(response);
        }
        #endregion

        #region Challennge #6: Valid Braces
        // Sum of odd numbers
        [HttpGet("valid-braces/{braces}")]
        public IActionResult ValidBraces(string braces)
        {
            var response = _solutionService.validBraces(braces);

            return Ok(response);
        }
        #endregion

        #region Challennge #7: Narcissistic Number
        // Does my number look big in this?
        [HttpGet("narcissistic-number/{value}")]
        public IActionResult Narcissistic(int value)
        {
            var response = _solutionService.Narcissistic(value);

            return Ok(response);
        }
        #endregion

    }
}
