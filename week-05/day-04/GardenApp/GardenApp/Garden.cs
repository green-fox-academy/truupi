using System;
using System.Collections.Generic;
using System.Linq;

namespace GardenApp
{
    class Garden
    {
        private List<Plant> myPlants = new List<Plant>();

        public void WateringPlants(int waterIncome)
        {
            if (waterIncome != 0)
            {
                Console.WriteLine($"Watering with {waterIncome}");
            }

            foreach (var plant in myPlants)
            {
                plant.SetPlantWaterLevel(waterIncome / myPlants.Count());
            }
            WaterLevelReview();
        }

        public void GardenPlanting()
        {
            myPlants.Add(new Flower("yellow"));
            myPlants.Add(new Flower("blue"));
            myPlants.Add(new Tree("purple"));
            myPlants.Add(new Tree("orange"));
        }

        private void WaterLevelReview()
        {
            foreach (var plant in myPlants)
            {
                if (plant.GetPlantWaterLevel() < 5 && plant.GetPlantType() == "Flower")
                {
                    Console.WriteLine(NeedWater(plant));
                }
                else if (plant.GetPlantWaterLevel() > 5 && plant.GetPlantType() == "Flower")
                {
                    Console.WriteLine(NoNeedWater(plant));
                }
                else if (plant.GetPlantWaterLevel() < 10 && plant.GetPlantType() == "Tree")
                {
                    Console.WriteLine(NeedWater(plant));
                }
                else if (plant.GetPlantWaterLevel() > 10 && plant.GetPlantType() == "Tree")
                {
                    Console.WriteLine(NoNeedWater(plant));
                }
            }
            Console.WriteLine();
        }

        private string NeedWater(Plant plant)
        {
            return string.Format("The {0} {1} needs water", plant.GetPlantColor(), plant.GetPlantType());
        }

        private string NoNeedWater(Plant plant)
        {
            return string.Format("The {0} {1} does not need water", plant.GetPlantColor(), plant.GetPlantType());
        }
    }
}
