using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*decimal amount, principal = (decimal)1000.00;
            double rate = 0.05;
            string output = "";
            for (int i = 0; i <= 10; i++)
            {
                amount = principal * (decimal)Math.Pow(1.0 + rate, i);

                output += i + "\t" + String.Format("{0:C}", amount) + "\n";
            }

            Console.WriteLine("compount interest: \n" + output);*/

            char grade;
            int aCount = 0,
                bCount = 0,
                cCount = 0,
                dCount = 0,
                fCount = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter a letter grade: ");
                grade = Char.Parse(Console.ReadLine().ToUpper());
                switch (grade)
                {
                    case 'A':
                        ++aCount;
                        break;
                    case 'B':
                        ++bCount;
                        break;
                    case 'C':
                        ++cCount;
                        break;
                    case 'D':
                        ++dCount;
                        break;
                    case 'F':
                        ++fCount;
                        break;
                    default:
                        Console.WriteLine("Incorrect grade!");
                        break;
                }
            }
            Console.WriteLine("A:{0}\tB:{1}\tC:{2}\tD:{3}\tF:{4}", aCount, bCount, cCount, dCount, fCount);
        }  
    }
}
