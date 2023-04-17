using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable 'name' is declared here
            string name;
            // write text before read name
            Console.Write("Enter your name:");
            //read the name if the user and save it in the var 'name'
            name = Console.ReadLine();
            // write text before read age
            Console.Write("Enter your age:");
            //read the age of the user and save it in the var 'age'
            // var 'age' is declared here and immediatly given a value
            string age = Console.ReadLine();
            //display name and age of the user
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            //wait for the user to enter a key
            Console.ReadKey();
        }
    }
}
