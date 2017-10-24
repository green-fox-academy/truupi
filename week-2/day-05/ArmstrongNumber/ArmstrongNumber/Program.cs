using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to check:\n");
            double number1 = double.Parse(Console.ReadLine());
            int number = Convert.ToInt32(number1);
            IsArmstrong(Checker(number), number);
        }

        static void IsArmstrong(int sum, int number)
        {
            if (sum == number)
            {
                Console.Write("Your number is an Armstrong number!");
            }
            else
                Console.Write("Your number is not an Armstrong number!");
            Console.ReadLine();
        }

        static int Checker(int number)
        {
            double remainder, sum = 0;
            double length = number.ToString().Length;
            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + Math.Pow(remainder, length);
            }
            int  summarize = Convert.ToInt32(sum);
            return summarize;
        }
    }
}
