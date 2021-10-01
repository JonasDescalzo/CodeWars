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

        //Challenge #1: Duplicate Encoder
        [HttpGet("duplicate-encoder/{word}")]
        public IActionResult DuplicateEncoder(string word)
        {
            var response = _solutionService.DuplicateEncoder(word);

            return Ok(response);
        }
        
    }
}
