using System;
using System.ComponentModel;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            int big;
            int small;
            if (num1 > num2)
            {    
                big = num1;
                small = num2;
            }
            else
            {
                big = num2;
                small = num1;
            }

            Console.WriteLine("highest value is: " + big);
            Console.WriteLine("lowest value is: " + small);

            Console.ReadKey();
        }
    }
}
