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
                Lot.Add(new Car((CarColor)rnd.Next(0, 10), (CarType)rnd.Next(0, 15)));
            }
        }

        public void SameType()
        {
            PrintType(Lot.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count()));
        }

        public void SuperCar()
        {
            var mostCommon = Lot.GroupBy(x => x.Type)
                                       .OrderByDescending(x => x.Count())
                                       .Select(x => x).First()
                                       .GroupBy(x => x.Color)
                                       .OrderByDescending(x => x.Count())
                                       .Select(x => x).First();
            Console.WriteLine($"{mostCommon.First().Color}  {mostCommon.First().Type}");
        }

        public void SameColor()
        {
            PrintColor(Lot.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count()));
        }

        public void PrintType(Dictionary<CarType, int> Lot)
        {
            foreach (var car in Lot)
            {
                Console.WriteLine(car);
            }
        }

        public void PrintColor(Dictionary<CarColor, int> Lot)
        {
            foreach (var car in Lot)
            {
                Console.WriteLine(car);
            }
        }
    }
}
