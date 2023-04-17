using System;
using System.Globalization;
using System.Threading;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter weight (kg): ");
            double kg = Double.Parse(Console.ReadLine());
            Console.Write("Enter length (cm): ");
            double cm = Double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/fenale): ");
            string gen = Console.ReadLine();

            double soh = Math.Pow(cm / 100, 2);

            //bmi calcs
            double bmi = kg / soh;
            string bmiS = bmi.ToString("0.0");
          
            Console.WriteLine("bmi-value: " + bmiS);
            //male standard
            double bmiMin = 20;
            double bmiMax = 25;
            double weightmin = bmiMin *soh;
            double weightmax = bmiMax * soh;
            
               
            if (gen == "female")
                    {
                        bmiMin = 19;
                        bmiMax = 24;
                        weightmin = bmiMin * soh;
                        weightmax = bmiMax * soh;
                    }
            
            string wmin = weightmin.ToString("0.0");
            string wmax = weightmax.ToString("0.0");

            Console.WriteLine("normal bmi-values (min .. max): " + bmiMin + ".." + bmiMax);
            Console.WriteLine("Healthy weight range: " + wmin + ".." + wmax);

            Console.ReadKey();
            
            
        }
    }
}
