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
        public int Code;

        public Car(CarColor color, CarType type)
        {
            Type = type;
            Color = color;
            SetCode();
        }

        private void SetCode()
        {
            int counter = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((Color == (CarColor)j && Type == (CarType)i))
                    {
                        Code = counter;
                        return;
                    }
                }
            }
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
