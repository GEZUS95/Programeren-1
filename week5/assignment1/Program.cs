using System;
using System.Globalization;
using System.Threading;
using System.Xml.Schema;

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

            int[] elements = new int[20];
            double average = 0;
            Random rand = new Random();
            
            int total = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = rand.Next(0, 201);
                Console.WriteLine("Element "+i+" is " + elements[i]);
            }
            
            foreach (int element in elements)
            {
                total += element;
            }
            average = total / elements.Length;

            Console.WriteLine(" ");
            Console.WriteLine("The average is: "+ average.ToString("0.00"));
            Console.WriteLine(" ");

            for (int j = 0; j < elements.Length; j++)
            {
                double diff = Math.Abs(elements[j] - average);
                Console.WriteLine("Difference between average and element {0} is {1}" , j , diff.ToString("0.00"));
            }
            Console.ReadKey();

        }
    }
}
