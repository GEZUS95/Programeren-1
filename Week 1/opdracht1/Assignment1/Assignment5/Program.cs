using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int num1 = rnd.Next(101,10000);
            int num2 = rnd.Next(101, 10000);
            int num3 = rnd.Next(101, 10000);
            int num4 = rnd.Next(101, 10000);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            Console.WriteLine("Zullen we ze bij elkaar optellen? druk dan op een toets.");
            Console.ReadKey();

            int sum = num1 + num2 + num3 + num4;
            Console.WriteLine(sum);
        }
    }
}
