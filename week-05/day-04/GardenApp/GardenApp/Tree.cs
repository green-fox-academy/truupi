namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            absorb = 0.4f;
            type = "Tree";
            this.color = color;
        }
    }
}
