using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text> ");
            string input = Console.ReadLine();

            SearchText(input, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons);

            Console.WriteLine("result: {0} full stops, {1} commas, {2} semicolons", nrOfFullStops, nrOfCommas, nrOfSemiColons);
            Console.ReadKey();

        }

        static void SearchText(string input, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = nrOfCommas = nrOfSemiColons = 0;
            foreach (char c in input)
            {
                switch (c)
                {
                    case '.':
                        nrOfFullStops++;
                        break;
                    case ',':
                        nrOfCommas++;
                        break;
                    case ';':
                        nrOfSemiColons++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
