using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer();
        }
        
        static void Writer()
        {
            string path = @"../../my-file.txt";
            string word = "apple";
            int number = 5;
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Can not write the file!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
