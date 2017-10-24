using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plant : Garden
    {
        private float waterLevel;
        protected float minWaterLevel;
        protected string color;
        protected string type;
        protected float absorb;

        public float WaterLevel { get => waterLevel; set => waterLevel = value; }

        internal float Watering(float waterLevel)
        {
            return this.WaterLevel += waterLevel * absorb;
        }

        internal float Drying(float dryLevel)
        {
            return this.WaterLevel -= dryLevel;
        }

        internal float GetPlantWaterLevel()
        {
            return WaterLevel;
        }

        internal float GetPlantMinWaterLevel()
        {
            return minWaterLevel;
        }

        internal string GetPlantType()
        {
            return type;
        }

        internal string GetPlantColor()
        {
            return color;
        }
    }
}
