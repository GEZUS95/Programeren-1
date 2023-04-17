using System;
using System.Globalization;
using System.Threading;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter number of seconds: ");
            string seconds = Console.ReadLine();

            double secondsD = double.Parse(seconds);

            // tijd van string naar Timespan
            TimeSpan time = TimeSpan.FromSeconds(secondsD);

            // Timespan naar leesbare tekst
            string tijd = time.ToString(@"hh\:mm\:ss");

            Console.WriteLine(tijd);

            Console.ReadKey();


        }
    }
}
