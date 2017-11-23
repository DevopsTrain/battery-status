using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BatteryStatus.Models;


namespace BatteryStatus.Controllers
{
    [Route("api/battery")]
    public class BatteryController : Controller
    {
        [HttpGet("{vin17}")]
        public IActionResult GetByVin(string vin17)
        {
            Battery bat = new Battery { Vin17 = vin17, ChargedPercentage = this.GetBatteryPercentage(), LastCheck = this.GetCheckedTime() };

            return new ObjectResult(bat);
        }

        private byte GetBatteryPercentage()
        {
            Random rand = new Random();
            int randomPercent = rand.Next(0, 100);

            return (byte)randomPercent;
        }

        private string GetCheckedTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
