using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Doubling();
            Console.ReadLine();
        }

        static void Doubling()
        {
            int[] ag = { 3, 4, 5, 6, 7 };

            for (int i = 0; i<ag.Length; i++)
            {
                Console.WriteLine(ag[i] * 2);
            }
        }
    }
}
