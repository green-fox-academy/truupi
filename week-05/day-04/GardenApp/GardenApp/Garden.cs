using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Garden
    {
        List<Plant> myPlants;

        public void Methods()
        {
            myPlants = new List<Plant>();
        }

        public void WriteOut()
        {
            Console.WriteLine(myPlants[2].GetPlantWaterLevel());
        }

        public void WateringPlants(int waterIncome)
        {
            foreach (var plantie in myPlants)
            {
                plantie.SetPlantWaterLevel(waterIncome);
            }
        }

        public void PlantsToMyPlants()
        {
            myPlants.Add(new Flower(0, "yellow"));
            myPlants.Add(new Flower(0, "blue"));
            myPlants.Add(new Tree(0, "purple"));
            myPlants.Add(new Tree(0, "orange"));
        }
    }
}
