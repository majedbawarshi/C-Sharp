using System;
using System.IO;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp;
            Console.WriteLine("Please choose one of the below:\n");
            Console.WriteLine("(1) Calculate one semester GPA.\n");
            Console.WriteLine("(2) Calculate cum GPA (general GPA for all semesters).\n");
            Console.Write("~");
            inp = Int32.Parse(Console.ReadLine());
            if (inp == 1)
            {
                Calculate gpa = new Calculate();
                Console.WriteLine("\ncalculating semester GPA..\n\n");
                gpa.semesterGpa();
                gpa.printGpa();
            }
            else if (inp == 2)
            {
                fullGpa fgpa = new fullGpa();
            }
            else
            {
                Console.WriteLine("\nYou've entered an invalid character!\a\nPlease run the program again!\a\n\n");
            }
        }
    }
}
