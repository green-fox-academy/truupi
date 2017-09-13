using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UrlFixer());
            Console.ReadLine();
        }

        static string UrlFixer()
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = UrlSwap(url);
            url = UrlColon(url);
            return url;
        }
        
        static string UrlSwap(string input)
        {
            string swap = input.Replace("bots", "odds");
            return swap;
        }
        
        static string UrlColon(string input)
        {
            string modified = input.Insert(5, ":");
            return modified;
        }
    }
}
