using System;
using System.Globalization;
using System.Threading;

namespace assignment7
{
    class Program
    {
        const int MBMIMIN = 20;
        const int MBMIMAX = 25;
        const int FBMIMIN = 19;
        const int FBMIMAX = 24;

        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //get information needed for calculation BMI
            Console.Write("Enter weight (kg): ");
            double invoerkg = Double.Parse(Console.ReadLine());
            Console.Write("Enter lenght (cm): ");
            double invoercm = Double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            double squareheight = invoercm / 100 * invoercm / 100;


            //calculate bmi
            double bmi = invoerkg / squareheight;
            string bmistring = bmi.ToString("0.0");

            Console.WriteLine(gender);
            //calculate estemated bmi-values
            if (gender == "male")
            {
               double weightrangemin = MBMIMIN * squareheight;
               double weightrangemax = MBMIMAX * squareheight;
            }
            else if (gender == "female")
            {
               double weightrangemin = FBMIMIN * squareheight;
               double weightrangemax = FBMIMAX * squareheight;
            }
            else
            {
                Console.WriteLine("Gender was not properly filled!");
            }

            string wrmin = weightrangemin.ToString("0.0");
            string wrmax = weightrangemax.ToString("0.0");



            //echo out the data
            Console.WriteLine("bmi-value: " +bmistring);

            if (gender == "male")
            {
                Console.WriteLine("normal mbi-values (min .. max): "+MBMIMIN+".."+MBMIMAX);
                Console.WriteLine("healthy weigt range: " +wrmin+ " .. " +wrmax);
            }
            else if (gender == "female")
            {
                Console.WriteLine("normal mbi-values (min .. max): "+FBMIMIN+".."+FBMIMAX);
                Console.WriteLine("healthy weigt range: "+wrmin+ " .. "+wrmax);
            }
            else
            {
                Console.WriteLine("Gender was not properly filled!");
            }

            Console.ReadKey();

        }
    }
}
