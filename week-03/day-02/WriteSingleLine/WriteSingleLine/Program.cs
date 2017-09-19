using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"my-file.txt";
            try
            {
                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine("Deak Tamas");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
