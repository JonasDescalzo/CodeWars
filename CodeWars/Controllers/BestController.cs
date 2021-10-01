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
        [HttpGet("persistent-bugger/{number}")]
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
        [HttpGet("validate-pin/{pin}")]
        public IActionResult ValidatePin(string pin)
        {
            var response = _bestService.ValidatePin(pin);

            return Ok(response);
        }
        #endregion
    }
}
