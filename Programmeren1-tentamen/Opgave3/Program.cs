using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randnumbers = new int[20];

            Random rand = new Random();

            for (int i = 0; i < randnumbers.Length; i++)
            {
                randnumbers[i] = rand.Next(1, 100);
            }

            foreach (int num in randnumbers)
            {
                if ((num %2 == 0) && (num %3 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if ((num % 2 == 0) && (num % 3 != 0)) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if ((num % 3 == 0) && (num % 2 != 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write("{0} ", num.ToString("00"));
                
            }

            Console.ReadKey();
        }
    }
}
