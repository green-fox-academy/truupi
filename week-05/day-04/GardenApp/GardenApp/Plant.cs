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

        internal float SetPlantWaterLevel(float waterLevel)
        {
            return this.waterLevel += waterLevel * absorb;
        }

        internal float GetPlantWaterLevel()
        {
            return waterLevel;
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
