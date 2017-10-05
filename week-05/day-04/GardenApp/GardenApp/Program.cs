using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenCreation();
        }

        static void GardenCreation()
        {
            Garden myGarden = new Garden();
            myGarden.GardenPlanting();
            GardenWatering(myGarden);
            Console.ReadLine();
        }

        static void GardenWatering(Garden myGarden)
        {
            myGarden.WateringPlants(0);
            myGarden.WateringPlants(40);
            myGarden.WateringPlants(70);
        }
    }
}
