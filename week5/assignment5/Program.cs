using System;

namespace assignment5
{
    class Program
    {
        const int MAX_ARRAYLENGT = 10;
        static void Main(string[] args)
        {

            int[] prescholers = new int[MAX_ARRAYLENGT];
            int[] children = new int[MAX_ARRAYLENGT];
            int[] adults = new int[MAX_ARRAYLENGT];

            Console.Write("Enter age (0=stop): ");
            int age = int.Parse(Console.ReadLine());

            int ipreschool = 0, ichild = 0, iadult = 0;

            while (age != 0)
            {
                if (age <= 3)
                {
                    prescholers[ipreschool] = age;
                    ipreschool++;
                }
                else if (age <= 17)
                {
                    children[ichild] = age;
                    ichild++;
                }
                else
                {
                    adults[iadult] = age;
                    iadult++;
                }
                
                Console.Write("Enter age (0=stop): ");
                age = int.Parse(Console.ReadLine());
            }



        }
    }
}
