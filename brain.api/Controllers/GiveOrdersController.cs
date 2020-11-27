using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brain.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiveOrdersController : ControllerBase
    {
        private readonly ILogger<GiveOrdersController> _logger;
        public GiveOrdersController(ILogger<GiveOrdersController> logger) 
        {
            _logger = logger;
        }

        [Route("handsup")]
        [HttpGet]
        public async Task<IActionResult> GiveHandsUpOrdersAsync() 
        {
            await Task.CompletedTask;
            return Ok("大脑下达了一个举手的指令");
        }
    }
}