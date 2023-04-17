using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (num2 % num1 == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
            Console.ReadKey();
        }
    }
}
