using System;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int getal1 = rand.Next(1, 20);
                int getal2 = rand.Next(1, 20);

                //highest = 
                int heigest, lowest = 0;
                if (getal1 > getal2) { heigest = getal1; lowest = getal2; }
                else { heigest = getal2; lowest = getal1; }


                Console.Write("{0}..{1} =   {2}\n", lowest, heigest, SomGetallenReeks(lowest, heigest));

            }

            Console.ReadKey();
        }

        static int SomGetallenReeks(int num1, int num2)
        {
            int som = 0;
            int getal = num1;
            for (int i = num1; i < num2; i++)
            {
                som += getal;
                getal++;
            }

            return som;
        }
    }
}
