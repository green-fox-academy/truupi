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
            Garden myGarden = new Garden();
            myGarden.Methods();
            myGarden.PlantsToMyPlants();
            myGarden.WateringPlants(40);
            myGarden.WateringPlants(70);
            myGarden.WriteOut();
            Console.ReadLine();
        }
    }
}
