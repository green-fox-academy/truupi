using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Car : ParkLot
    {
        public CarColor Color;
        public CarType Type;

        public Car(CarColor color, CarType type)
        {
            Type = type;
            Color = color;
        }
    }

    public enum CarType
    {
        Audi,
        BMW,
        Mercedes,
        Opel,
        Dacia,
        Peugeot,
        Ford,
        Renault,
        Ferrari,
        McLaren,
        Dodge,
        Chevrolet,
        Toyota,
        Honda,
        Nissan
    }

    public enum CarColor
    {
        Red,
        Blue,
        Yellow,
        Green,
        Pink,
        Silver,
        Black,
        White,
        Gold,
        Orange
    }
}
