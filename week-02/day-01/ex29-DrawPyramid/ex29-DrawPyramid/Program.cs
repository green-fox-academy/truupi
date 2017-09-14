using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex29_DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberoflayer = Convert.ToInt32(Console.ReadLine()), Space, Number;
            for (int i = 1; i <= numberoflayer; i++)
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)
                    Console.Write("");
                for (Number = 1; Number <= i; Number++)
                    Console.Write('*');
                for (Number = (i - 1); Number >= 1; Number--)
                    Console.Write('*');
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }       
}
