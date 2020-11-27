using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hand.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HandsUpController : ControllerBase
    {
        private readonly ILogger<HandsUpController> _logger;

        public HandsUpController(ILogger<HandsUpController> logger)
        {
            _logger = logger;
        }

        [Route("handsup")]
        [HttpGet]
        public async Task<IActionResult> HandsUpAsync()
        {
            await Task.CompletedTask;
            return Ok("接受举起手的指令，并且举手了");
        }
    }
}
