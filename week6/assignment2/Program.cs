using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number (0 is stop value): ");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                if (num < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else
                {
                    IsPrimeNumber(num);
                }
                
                Console.Write("Enter number (0 is stop value): ");
                num = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("end of program");
                Console.ReadKey();
        }
        static void IsPrimeNumber(int number)
        {


            bool isPrime = true;
            int i = 2;
            while ((i < number) && isPrime)
            {
                if ((number % i) == 0)
                {
                    isPrime = false;
                }
                else
                {
                    i++;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
        }
    }
}
