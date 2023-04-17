using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord: ");
            string woord = Console.ReadLine();
            
            while (woord != "stop")
            {
                int totaalwaarde = 0;
                foreach (char letter in woord)
                {
                    int waarde = letter - 96;
                    Console.Write("{0}={1}", letter, waarde);
                    totaalwaarde += waarde;
                }
                Console.WriteLine("\nsom van '{0}' is {1}\n", woord , totaalwaarde);

                Console.Write("Geef een woord: ");
                woord = Console.ReadLine();
            }

            Console.WriteLine("\neinde programma");
            Console.ReadKey();
        }
    }
}
