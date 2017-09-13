using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Matchmaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = girls.Join
                (boys, 
                g => girls.IndexOf(g), 
                b => boys.IndexOf(b), 
                (g, b) => new { G = g, B = b }).ToList();

            foreach (var item in order)
            {
                Console.Write("{0}, {1}, ", item.G, item.B);

                if (item == order.Last())
                {
                    Console.Write(boys.Last());
                }
            }
            Console.ReadLine();
        }
    }
}
