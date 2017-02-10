using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_IF
{
    class Program
    {
        static void Main(string[] args)
        {

            string pozdrav = Console.ReadLine();

            if (pozdrav == "ahoj")
                // if muzu vnorovat jak se mi zachce
            {
                Console.Out.WriteLine("Ahoj taky te zdravim");
            }
            else if (pozdrav == "nazdar")
            {
                Console.Out.WriteLine("Zdar taky te zdravim");
            }
            else if (pozdrav == "cus")
            {
                Console.Out.WriteLine("Cus bus autobus");
            }
            // else if muze byt nekonecno

            else
            {
                Console.Out.WriteLine("Ty me nepozdravis?");
            }
            // else muze byt pouze jedno

            if (pozdrav == "ahojky" || pozdrav == "cusanek" || pozdrav == "papanek")
                // || je jako OR, && je jako and
            {
                Console.Out.WriteLine("zdrobneliny nepouzivame!!! Nejsme deti");
            }

            Console.ReadLine();

        }
    }
}
