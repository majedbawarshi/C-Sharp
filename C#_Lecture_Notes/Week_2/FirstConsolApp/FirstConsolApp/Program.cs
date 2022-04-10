using System;

namespace FirstConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int total,
                gradeCounter,
                gradeValue,
                average;
            total = 0;
            gradeCounter = 1;
            while (gradeCounter <= 10)
            {
                Console.WriteLine("Enter integer grade: ");
                gradeValue = Int32.Parse(Console.ReadLine());
                total = total + gradeValue;
                gradeCounter = gradeCounter + 1;
            }
            average = total / 10;
            Console.WriteLine("Class average is: {0}", average);
        }
    }
}
