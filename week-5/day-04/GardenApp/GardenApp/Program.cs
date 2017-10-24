using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        static Garden myGarden = new Garden();

        static void Main(string[] args)
        {
            GardenCreation();
        }

        static void GardenCreation()
        {
            myGarden.GardenPlanting();
            GardenWatering();
            GardenDrying();
            Console.ReadLine();
        }

        static void GardenWatering()
        {
            myGarden.WateringPlants(0);
            myGarden.WateringPlants(40);
            myGarden.WateringPlants(70);
        }

        static void GardenDrying()
        {
            myGarden.DryingPlants();
            myGarden.DryingPlants(2);
        }
    }
}
