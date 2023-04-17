using System;
using System.Dynamic;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int workinghours = Int32.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter number of failures: ");
            int failures = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (workinghours > 10000 || age > 7 || failures > 25) {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            Console.ReadKey();

        }
    }
}
