using System;
using System.Linq.Expressions;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4): ");
            int invoer = Int32.Parse(Console.ReadLine());

            switch (invoer)
            {
                case 1:
                    Console.WriteLine("clubs");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("spades");
                    break;
                default :
                    Console.WriteLine("Incorrect number!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
