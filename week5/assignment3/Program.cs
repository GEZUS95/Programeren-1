using System;
using System.Globalization;
using System.Threading;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter course name: ");
            string coursename = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int studentcount = int.Parse(Console.ReadLine());

            string[] students = new string[studentcount];
            float[] grades = new float[studentcount];
            double total = 0;
            int j = 1;
            float tmpmax = 0;
            string maxStudent = "";

            for (int i = 0; i < students.Length; i++)
            {
                
                Console.Write("Enter name of student {0}: ", j);
                students[i] = Console.ReadLine();
                j++;
            }

            Console.WriteLine(" ");

            for (int k = 0; k < grades.Length; k++)
            {
                Console.Write("Enter grade of {0}: ", students[k]);
                grades[k] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            // get the hi/lo est val incl. pos in array
            for (int l = 0; l < studentcount; l++)
            {
                float grade = grades[l];
                total += grade;
                if (grades[l] > tmpmax)
                {
                    tmpmax = grades[l];
                    maxStudent = students[l];
                }
            }
            
            double average = total / studentcount;

            Console.WriteLine("Average grade: {0}", average.ToString("0.0"));
            Console.WriteLine("Student {0} has maximum grade: {1}", maxStudent, tmpmax);

            Console.WriteLine(" ");

            for (int l = 0; l < students.Length; l++)
            {
                Console.WriteLine("Grade for student {0} (course {1}): {2}", students[l], coursename, grades[l]);
            }

            Console.ReadKey();

        }
    }
}
