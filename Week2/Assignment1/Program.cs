using System;
using System.Globalization;
using System.Threading;

namespace Week2
{
    class Program
    {
        const double VAT = 0.21;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter a Price: ");
            string invoer = Console.ReadLine();
            double price = double.Parse(invoer);

            double VATprice = price * VAT;

            double total = VATprice + price;

            string totalS = total.ToString("0.00");
            string VATpriceS = VATprice.ToString("0.00");
            string priceS = price.ToString("0.00");


            Console.WriteLine("price: " + priceS + ", VAT: " +VATpriceS+ ", total: " + totalS);
            Console.ReadKey();

        }
    }
}
