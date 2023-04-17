using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            double total = 0;

            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                count++;
                if (count % 5 == 0)
                    total = total + input;
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of 5th, 10th, 15th, ... number is: {0}", total);
            Console.ReadKey();

        }
    }
}
