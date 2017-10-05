using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(int waterLevel, string color)
        {
            this.waterLevel = waterLevel;
            this.color = color;
        }
    }
}
