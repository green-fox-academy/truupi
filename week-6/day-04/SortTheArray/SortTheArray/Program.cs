using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(SortArray(new int[] { 1, 2, 3, 4 }));
            PrintArray(SortArray(new char[] { 'a', 's', 'd', 'f' }));
            PrintArray(args);
            Console.ReadLine();
        }

        public static T[] SortArray<T>(T[] array)
        {
            return array.OrderByDescending(x => x).ToArray();
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
