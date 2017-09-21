using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurseDecToBinConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Running())
            {
                Running();
            }
            Console.WriteLine("\n\n\nThe program now closes!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }

        static bool Running()
        {
            Console.Clear();
            bool right = true;
            while (true)
            {
                try
                {
                    Clearing();
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        Console.Write("\n\nThe binary equivalent of {0} is: ", num);
                        DeciToBin(num);
                        Console.ReadLine();
                        Console.WriteLine("\n\nDo you want to do it again? Type \"y\" if yes or \"n\" if no and hit Enter!\n\n");
                        string answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            right = false;
                            break;
                        }
                        if (answer != "n" && answer != "y")
                        {
                            TrueOrFalse();
                        }
                    }
                    else if (num != 0 || num == 0)
                    {
                        Console.WriteLine("\n\nPlease enter a positive decimal number!\n\n");
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\nPlease enter a positive decimal number!\n\n");
                    Console.ReadLine();
                    right = false;
                }
            }
            return right;
        }

        private static void Clearing()
        {
            Console.Clear();
            Console.WriteLine("\n\nConvert a decimal number to binary number with recursion:" +
                "\n_________________________________________________________\n");
        }

        private static string TrueOrFalse()
        {
            string answer;
            while (true)
            {
                Clearing();
                Console.Write("\n\nPlease type \"y\" to restart or \"n\" to exit!\n\n");
                answer = Console.ReadLine();
                if (answer == "y")
                    {
                    break;
                    }
                else if (answer == "n")
                {
                    Console.WriteLine("\n\n\nThe program now closes!");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
                TrueOrFalse();
                break;
            }
            return answer;
        }

        private static int DeciToBin(int num)
        {
            int bin;
            if (num != 0)
            {
                bin = (num % 2) + 10 * DeciToBin(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
