using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Consul;
using Microsoft.Extensions.Logging;

namespace DemoBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ConsulClient _consulClient;
        private readonly ILogger _logger;

        public ServicesController(ConsulClient client,
                                  ILogger<ServicesController> logger)
        {
            _consulClient = client;
            _logger = logger;
        }

        // GET api/services
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            _logger.LogInformation($"Discovering Services from Consul.");

            var services = await _consulClient.Agent.Services();
            return services.Response.Select(srv => $"{srv.Value.Address}:{srv.Value.Port}");
        }
    }
}
