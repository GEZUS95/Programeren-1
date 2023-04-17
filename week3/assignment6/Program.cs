using System;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = Int32.Parse(Console.ReadLine());
            string grade = "";
                
            if (score >= 90)
                {
                    grade = "A";
                }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70) 
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            
            string txt = "";
            
            if (grade == "A" || grade == "B" || grade == "C")
            {
                txt = "course passed";
            }
            else
            {
                txt = "course not passed";
            }

            Console.WriteLine("grade: " +grade);
            Console.WriteLine(txt);
            Console.ReadKey();

        }
    }
}
