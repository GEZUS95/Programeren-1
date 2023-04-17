using System;
using System.Threading;

namespace assignment2
{
    class Program
    {
        const int MAX_NUM = 150;
        static void Main(string[] args)
        {
            int[] elements = new int[20];
            Random rand = new Random();
            int count = 0;
            int tmpmin = MAX_NUM;

            for (int i = 0; i < elements.Length; i++)
            {
                int randNum = rand.Next(0, MAX_NUM);
                elements[i] = randNum;
                Console.WriteLine("Element {0} = {1}", i , elements[i]);
            }

            foreach (int num in elements)
            {
                if (num < tmpmin)
                {
                    tmpmin = num;
                    count = 1;
                }
                else if (tmpmin == num)
                {
                    count++;
                }
            }

            Console.WriteLine("smallest number = {0}", tmpmin);
            Console.WriteLine("number of occurence = {0}" , count);
            Console.ReadKey();

        }
    }
}
