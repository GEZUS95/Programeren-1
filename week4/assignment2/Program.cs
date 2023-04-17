using System;
using System.Transactions;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int count = 0;
            Console.Write("Enter target number: ");
            int targ = Int32.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num == targ)
                {
                    count++;
                }
            } while (num!=0);

            Console.WriteLine("Count of numbers equal to target number: {0}", count);
            Console.ReadKey();
        }
    }
}
