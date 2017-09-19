using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../../encoded-lines.txt";
            try
            {
                var countline = File.ReadLines(path).Count();
                Console.WriteLine(countline);
            }
            catch (Exception error)
            {
                Console.WriteLine("File not found!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
