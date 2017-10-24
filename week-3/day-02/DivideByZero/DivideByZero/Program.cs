using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number that you want 10 divide with:");
                int userInput = int.Parse(Console.ReadLine());
                int result = 10 / userInput;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (Exception error)
            {
                Console.WriteLine("An unknown error happened!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
