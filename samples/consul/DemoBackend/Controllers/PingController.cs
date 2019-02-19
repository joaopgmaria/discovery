using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        public PingController()
        {
        }

        // GET api/ping
        [HttpGet]
        public string Ping()
        {
            return $"Pong from {System.Environment.MachineName}";
        }
    }
}
