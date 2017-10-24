using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumArray(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(SumArray(new char[] { 'a', 's', 'd', 'f' }));
            Console.ReadLine();
        }

        public static T SumArray<T>(T[] array)
        {
            T result = default(T);
            for (int i = 0; i <= array.Length - 1; i++)
            {
                result += (dynamic)array[i];
            }
            return result;
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
