using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Candyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            if (list.ElementAt(1) != list.ElementAt(2))
            {
                list[1] = "Croissant";
            }
            if (list.ElementAt(3) != list.ElementAt(2))
            {
                list[3] = "Ice cream";
            }

            foreach (var item in list)
            {
               Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
