using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //read first name of user
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            // read last name of user
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            //display full name (Option 1)
            Console.WriteLine("Your full name is " + firstName + " " + lastName );

            // display full name (Option 2)
            Console.WriteLine("Your full name is {0} {1} ", firstName, lastName);

            //display full name (option 3)
            Console.WriteLine($"Your full name is {firstName} {lastName}");

            //wait for user to enter key
            Console.ReadKey();
        }
    }
}
