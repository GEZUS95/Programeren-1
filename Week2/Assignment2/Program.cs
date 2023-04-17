using System;
using System.Globalization;
using System.Threading;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter 1st number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter 2nd number: ");
            string num2 = Console.ReadLine();
            Console.Write("Enter 3rd number: ");
            string num3 = Console.ReadLine();

            double num1D = double.Parse(num1);
            double num2D = double.Parse(num2);
            double num3D = double.Parse(num3);

            double result = (num1D + num2D + num3D) / 3;

            string resultS = result.ToString();

            Console.WriteLine("The average is: " + result);
            Console.ReadKey();
        }
    }
}
