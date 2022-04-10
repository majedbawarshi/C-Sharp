using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[10];
            double sum=0;
            for(int counter = 0; counter < grades.Length; counter++)
            {
                Console.WriteLine("please enter the grade of {0} student", counter + 1);
                grades[counter] = Convert.ToDouble(Console.ReadLine());
                sum += grades[counter];
            }

            double avg = sum / grades.Length;

            var greaterThanAvg =
                from value in grades
                where value > avg
                select value;

            foreach (var element in greaterThanAvg)
                Console.Write($" {element}");

            Console.WriteLine();

            var smallerThanAvg =
                from value in grades
                where value < avg
                select value;

            foreach (var element in smallerThanAvg)
                Console.Write($" {element}");

            Console.WriteLine();
            var sortedGrades =
                from value in grades
                orderby value
                select value;

            foreach (var element in sortedGrades)
                Console.Write($" {element}");
            Console.WriteLine();

        }
    }
}
