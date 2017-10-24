using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name = "Foxie", string type = "pallida", string color = "green")
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
}
