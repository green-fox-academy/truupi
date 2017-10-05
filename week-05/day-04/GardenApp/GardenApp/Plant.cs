using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plant : Garden
    {
        protected float waterLevel;
        protected string color;
        protected string type;
        protected float absorb;

        public float SetPlantWaterLevel(float waterLevel)
        {
            return this.waterLevel += waterLevel * absorb;
        }

        public float GetPlantWaterLevel()
        {
            return waterLevel;
        }

        public string GetPlantType()
        {
            return type;
        }

        public string GetPlantColor()
        {
            return color;
        }
    }
}
