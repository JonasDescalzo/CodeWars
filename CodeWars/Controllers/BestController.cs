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

        //Challenge #1: Duplicate Encoder
        [HttpGet("best-duplicate-encoder/{word}")]
        public IActionResult BestDuplicateEncoder(string word)
        {
            var response = _bestService.BestDuplicateEncoder(word);

            return Ok(response);
        }
    }
}
