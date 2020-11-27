using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gateway.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiGatewayController : ControllerBase
    {
        private readonly ILogger<ApiGatewayController> _logger;
        public ApiGatewayController(ILogger<ApiGatewayController> logger) 
        {
            _logger = logger;
        }

        [HttpGet("test")]
        public async Task<IActionResult> GiveOrdersAsync() 
        {
            await Task.CompletedTask;
            return Ok("请求网关");
        }
    }
}