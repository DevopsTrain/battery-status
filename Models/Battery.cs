using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatteryStatus.Models
{
    public class Battery
    {
        public string Vin17 { get; set; }

        public byte ChargedPercentage { get; set; }

        public string LastCheck { get; set; }
    }
}
