using System;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            //convert text to int val
            int age = int.Parse(input);
            //add 1 to age
            age++;
            //convert age into a string
            string output = age.ToString();
            // Display increased age
            Console.WriteLine("Next year you will be " + output + " years old.");

            //wait for user to enter a key
            Console.ReadKey();

        }
    }
}
