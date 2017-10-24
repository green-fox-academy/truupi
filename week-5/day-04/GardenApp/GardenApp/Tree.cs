namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            absorb = 0.4f;
            type = "Tree";
            minWaterLevel = 10;
            this.color = color;
        }
    }
}
