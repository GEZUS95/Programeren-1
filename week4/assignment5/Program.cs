using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int invoer = int.Parse(Console.ReadLine());
            while (invoer != 0)
            {
                
                if (invoer < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else
                {
                    if (invoer == 0)
                    {
                        break;
                    }
                    else if  ((invoer % 4 == 0) && (invoer % 100 !=0) || (invoer % 400 == 0))
                    {
                        Console.WriteLine("{0} is a leap year.", invoer);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year",invoer);
                    }
                }

                Console.Write("Enter a year: ");
                invoer = int.Parse(Console.ReadLine());
            } 
            
            Console.ReadKey();
        }
    }
}
