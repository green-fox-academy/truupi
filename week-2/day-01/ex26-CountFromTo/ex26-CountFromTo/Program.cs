using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex26_CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers and hit Enter after each:\n");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            while (Compare(num1, num2))
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            }
            Counter(num1, num2);
            Console.ReadLine();
        }

        static bool Compare(int input1, int input2)
        {
            bool bigger = false;
            if (input2 < input1)
            {
                Console.WriteLine("The second number should be bigger!");
                bigger = true;
            }
            return bigger;
        }

        static void Counter(int input, int input2)
        {
            int range = input2 - input;
            for (int i = 0; i < range+1; i++)
            {
                Console.WriteLine(input++);
            }
        }
    }
}
