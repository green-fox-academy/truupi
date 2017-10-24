using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            AirBattle();
        }

        static void AirBattle()
        {
            F16 f16_1 = new F16();
            F35 f35_1 = new F35();

            Console.WriteLine(f35_1.Refill(300));
            Console.WriteLine(f35_1.GetStatus());
            Console.WriteLine(f35_1.Fight());
            Console.WriteLine(f35_1.GetAircraftType());

            Console.ReadLine();
        }
    }
}
