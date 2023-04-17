using System;

namespace assignment4
{
    class Program
    {
        static void Main()
        {
            int getal1 = 1;
            int getal2 = 1;

            Console.Write("{0}, {0}", getal1, getal2);
            int aantal = 2;

            while (aantal < 20)
            {
                int getal3 = getal1 + getal2;
                Console.Write(", {0}", getal3);

                getal1 = getal2;
                getal2 = getal3;

                aantal++;
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
