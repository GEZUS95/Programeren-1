using System;
using System.Globalization;
using System.Threading;
using System.Transactions;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            double total = 0.00;
            int count = 0;
            double average = 0.00;

            Console.Write("Enter a number: ");
            int num = Int32.Parse(Console.ReadLine());
            while (num != 0)
            {
                if (num > 0)
                {
                    count++;
                    total += num;
                }
                Console.Write("Enter a number: ");
                num = Int32.Parse(Console.ReadLine());
            }
            

            if (count != 0)
            {
                average = total / count;
            }
            else
            {
                average = 0.00;
            }
            string output = average.ToString("0.00");
            Console.WriteLine("Average of all positive numbers is: {0}", output);
            Console.ReadKey();
        }
    }
}
