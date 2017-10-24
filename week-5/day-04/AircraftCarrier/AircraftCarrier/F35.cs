using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            maxAmmo = 12;
            baseDamage = 50;
            type = "F35";
        }
    }
}
