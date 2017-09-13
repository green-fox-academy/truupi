using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };
            List(planetList);
            Console.ReadLine();
        }

        static void List(List<string> input)
        {
            input.Insert(5, "Saturn");
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
