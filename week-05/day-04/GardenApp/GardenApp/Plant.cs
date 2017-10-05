using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plant : Garden
    {
        protected int waterLevel;
        protected string color;

        public int SetPlantWaterLevel(int waterLevel)
        {
            this.waterLevel += waterLevel;
            return waterLevel;
        }

        public int GetPlantWaterLevel()
        {
            return waterLevel;
        }
    }
}
