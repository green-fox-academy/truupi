namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(string color)
        {
            absorb = 0.75f;
            type = "Flower";
            this.color = color;
        }
    }
}
