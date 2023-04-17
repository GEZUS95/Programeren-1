using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;
using System.Threading;

namespace assignment7
{
    class Program
    {
        const double FBMIMIN = 19;
        const double FBMIMAX = 24;
        const double MBMIMIN = 20;
        const double MBMIMAX = 25;

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
            double weightmin = 0;
            double weightmax = 0;
            Console.WriteLine("bmi-value: " + bmiS);
            switch (gen){
                case "male":
                {
                        weightmin = MBMIMIN *soh;
                        weightmax = MBMIMAX * soh;
                        string wmin = weightmin.ToString("0.0");
                        string wmax = weightmax.ToString("0.0");
                        Console.WriteLine("normal bmi-value (min .. max): " + MBMIMIN + ".." + MBMIMAX);
                        Console.WriteLine("Healthy weight range: " +wmin+ " .. " + wmax);
                        break;
                    }
                case "female": 
                    {
                        weightmin = FBMIMIN * soh;
                        weightmax = FBMIMAX * soh;
                        string wmin = weightmin.ToString("0.0");
                        string wmax = weightmax.ToString("0.0");
                        Console.WriteLine("normal bmi-value (min .. max): " + FBMIMIN + ".." + FBMIMAX);
                        Console.WriteLine("Healthy weight range: " + wmin + " .. " + wmax);
                        break;
                    }
            }
            Console.ReadKey();
            
            
        }
    }
}
