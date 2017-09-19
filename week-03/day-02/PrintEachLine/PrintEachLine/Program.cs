using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./my-file.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content[0]);
            }
            catch (Exception error)
            {
                Console.WriteLine("Could not read file!");
            }
            finally
            {
                Console.ReadLine();
            }

        }   
    }
}
