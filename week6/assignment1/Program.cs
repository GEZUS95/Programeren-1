using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        const float VAT_PERS = 0.21f;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter a price: ");
            double price = double.Parse(Console.ReadLine());
            double vat = Calcvat(price);
            double total = vat + price;

            Console.WriteLine("price: {0}, VAT: {1}, total: {2}", price.ToString("0.00"), vat.ToString("0.00"), total.ToString("0.00"));
            WaitForUser();
        }

        static double Calcvat(double price)
        {
            double temp = price * VAT_PERS;
            return temp;

        }

        static void WaitForUser()
        {
            Console.ReadKey();
        }
    }
}
