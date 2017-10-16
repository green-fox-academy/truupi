using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F16 : Aircraft
    {
        public F16()
        {
            maxAmmo = 8;
            baseDamage = 30;
            type = "F16";
        }
    }
}
