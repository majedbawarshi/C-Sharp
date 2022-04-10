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
            int n;
            Console.WriteLine("please enter how many students do you have: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] grade = new double[n];
            string[] name = new string[n];
            double sum = 0;
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("please enter the {0} student name & grade: ", (i + 1));
                name[i] = Console.ReadLine();
                grade[i] = Convert.ToDouble(Console.ReadLine());
                sum += grade[i];
                i++;
            }
            double avg = getAvg(sum,n);
            Console.WriteLine("The average is: " + avg);
            getInfo(name,grade,avg);
        }

        static double getAvg(double sum,int n)
        {
            return sum / n;
        }

        static void getInfo(string[]name,double[]grade,double avg)
        {
            for(int counter = 0; counter < name.Length; counter++)
            {
                if(grade[counter] < avg)
                {
                    Console.WriteLine("{0} of grade {1} has failed",name[counter],grade[counter]);
                }
                else
                {
                    Console.WriteLine("{0} of grade {1} has passed", name[counter], grade[counter]);
                }
            }
        }
    }
}
