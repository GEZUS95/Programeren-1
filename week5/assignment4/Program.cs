using System;

namespace assignment4
{
    class Program
    {
        const int MAX_NUM = 20;
        static void Main(string[] args)
        {
            int[] numbers = new int[MAX_NUM];
            int i = 0;
            int count = 0;
            int numelements = 0;

            Console.Write("Enter a number (0=stop): ");
            int input = int.Parse(Console.ReadLine());
            
            while ((input != 0) && (numelements < MAX_NUM)){
                numbers[numelements] = input;
                numelements++;
                Console.Write("Enter a number (0=stop): ");
                input = int.Parse(Console.ReadLine());

            }

            Console.Write("Enter a searchvalue: ");
            int searchVal = int.Parse(Console.ReadLine());

            foreach (int number in numbers)
            {
                if (number == searchVal)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of occurences of searchvalue ({0}) is: {1}", searchVal, count);
            Console.ReadKey();

        }
    }
}
