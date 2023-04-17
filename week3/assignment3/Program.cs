using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            if(num3 < num1 && num3 < num2)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }

            Console.ReadKey();
        }
    }
}
