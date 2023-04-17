using System;
using System.Globalization;
using System.Threading;

namespace assigment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // get the numbers
            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            //calculate the sum
            int sum = num1 + num2 + num3;

            //calculate avarage
            double avaragesum = Convert.ToDouble(sum) / 3;
            string avarage = avaragesum.ToString("0.00");

            //calculate product
            int product = num1 * num2 * num3;

            // determine the highest
            int highest = 0;
            if (num1 > num2 && num1 > num3) { highest = num1; }
            else if (num2 > num1 && num2 > num3) { highest = num2; }
            else if (num3 > num1 && num3 > num2) { highest = num3; }

            // determine the lowest
            int lowest = 0;
            if (num1 < num2 && num1 < num3) { lowest = num1; }
            else if (num2 < num1 && num2 < num3) { lowest = num2; }
            else if (num3 < num1 && num3 < num2) { lowest = num3; }

            // write the results to con
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("average = "+avarage);
            Console.WriteLine("product = "+product);
            Console.WriteLine("highest = "+highest);
            Console.WriteLine("lowest = "+lowest);

            Console.ReadKey();

        }
    }
}
