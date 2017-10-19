using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkLot parkLot = new ParkLot();
            parkLot.LotCreation();

            Console.WriteLine(parkLot.Lot[6].Color);
            Console.ReadLine();
        }
    }
}
