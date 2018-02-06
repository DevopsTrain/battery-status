using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BatteryStatus.Controllers
{

    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        [HttpGet]
        [Route("live")]
        public IActionResult GetLive()
        {
            return Ok();
        }

        [HttpGet]
        [Route("readiness")]
        public IActionResult GetReadiness()
        {
            return Ok();
        }
    }
}
