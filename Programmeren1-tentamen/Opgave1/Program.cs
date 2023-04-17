using System;
using System.Globalization;
using System.Threading;

namespace Opgave1
{
    class Program
    {
        const float COLLEGEGELD = 2142.00f;
        const float COLLEGEHELFT = 1071.00f;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // naam opvragen
            Console.Write("geef je naam: ");
            string naam = Console.ReadLine();

            // eerste bachelor?
            Console.Write("{0}, is dit je eerste bachelor opleiding? ", naam);
            string eerste = Console.ReadLine();

            if (eerste == "ja")
            {
                Console.Write("is het een lerarenopleiding? ");
                string isLeraar = Console.ReadLine();

                if (isLeraar == "ja")
                {
                    Console.WriteLine("\nhet collegegeld voor dit collegejaar is de helft ({0} euro), en volgend jaar ook de helft", COLLEGEHELFT.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("\nhet collegegeld voor dit collegejaar is de helft ({0} euro), daarna volledig", COLLEGEHELFT.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("\nhet collegegeld voor dit collegejaar is volledig ({0} euro)", COLLEGEGELD.ToString("0.00"));
            }

            Console.ReadKey();
        }
    }
}
