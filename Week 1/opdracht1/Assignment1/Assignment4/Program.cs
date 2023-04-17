using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //assign var 'input' the result of 'number + number'
            int result = number + number;

            //add result + 10
            result = result + 10;

            // devide result by 2
            result = result /= 2;

            //subtract original num from res.
            result = result -= number;

            Console.WriteLine($"result is {result}");
        }
    }
}
