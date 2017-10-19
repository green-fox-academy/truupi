using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkLot
    {
        public Random rnd = new Random();
        public List<Car> Lot = new List<Car>();

        public void LotCreation()
        {
            for (int i = 1; i <= 256; i++)
            {
                Lot.Add(new Car((CarColor)rnd.Next(0, 15), (CarType)rnd.Next(0, 10)));
            }
        }
    }
}
