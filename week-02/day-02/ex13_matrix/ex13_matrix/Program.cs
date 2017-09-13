using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = DrawMatrix(17);
            Console.ReadLine();
        }

        static int[,] DrawMatrix(int size)
        {
            int[,] table = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        table[i, j] = 1;
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
            return table;
        }
    }
}
