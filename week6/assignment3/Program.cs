using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year (0 is stop value): ");
            int invoer = int.Parse(Console.ReadLine());
            bool leapyear = true;

            while (invoer != 0)
            {
                if (invoer < 0)
                {
                    Console.WriteLine("Negative year entered...");
                }
                else
                {
                    if (IsLeapYear(invoer) == true)
                    {
                        Console.WriteLine("{0} is a leap year.", invoer);
                    }
                    else if (IsLeapYear(invoer) == false)
                    {
                        Console.WriteLine("{0} is not a leap year.", invoer);

                    }
                }
                Console.Write("Enter year (0 is stop value): ");
                invoer = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("end of program");
            Console.ReadKey();
        }
        static bool IsLeapYear(int year)
        {

            bool deelDoor400 = ((year % 400) == 0);
            bool deelDoor100 = ((year % 100) == 0);
            bool deelDoor4 = ((year % 4) == 0);

            return (deelDoor400 || (deelDoor4 && !deelDoor100));

        }
    }
}
