using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)

        {
            // Hello Tamas excercise

            Console.WriteLine("Hello Tamas!");

            Console.ReadLine();

            // Humpty Dumpty excercise
            string humpty1 = "All the king's horses and all the king's men";
            string humpty2 = "Humpty Dumpty had a great fall.";
            string humpty3 = "Humpty Dumpty sat on a wall,";
            string humpty4 = "Couldn't put Humpty together again.";

            Console.WriteLine(humpty3);
            Console.WriteLine(humpty2);
            Console.WriteLine(humpty1);
            Console.WriteLine(humpty4);

            Console.ReadLine();

            //Greeting excercise

            string name1 = "Csilla";
            string name2 = "Gergo";
            string name3 = "Balazs";

            Console.Write("Greetings today " + name1);
            Console.Write(", " + name2);
            Console.Write(" and " + name3);
            Console.Write("!");
            Console.WriteLine();

            Console.ReadLine();

            //Numericals

            Console.WriteLine(2 + 2);
            Console.WriteLine(7 - 2);
            Console.WriteLine(3 * 2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(7 % 2);
            Console.WriteLine(7 / 2.0);

            Console.ReadLine();

            //true, false
            Console.WriteLine(true);
            Console.WriteLine(false);

            //negation
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //and
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            //or
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.ReadLine();

            // string and special characters
            Console.WriteLine("hello");
            Console.WriteLine("don't");
            Console.WriteLine("She said, \"you deserva a treat\" ");

            // string Operators
            // Concatination
            Console.WriteLine("hand" + "some");

            // concat string with number
            Console.WriteLine("My favourite number is: 2" + 8);

            Console.ReadLine()

        }
    }
}
