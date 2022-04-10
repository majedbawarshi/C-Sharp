using System;

namespace FirstLessonSecHour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# programming");

            /*
             * Defining variable
             */
            /*int number1, number2, sum;
            Console.Write("Please enter the first number: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            number2 = Int32.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("the sum of {0} and {1} is {2}" , number1  , number2  , sum);*/

            /**/

            int number1, number2;
            Console.Write("please enter the first and second number respectively: ");
            number1 = Int32.Parse(Console.ReadLine());
            number2 = Int32.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine(number1 + " == " + number2);
            }
            if (number1 != number2)
            {
                Console.WriteLine(number1 + " != " + number2);
            }
            if (number1 < number2)
            {
                Console.WriteLine(number1 + " < " + number2);
            }
            if (number1 > number2)
            {
                Console.WriteLine(number1 + " > " + number2);
            }
            if (number1 <= number2)
            {
                Console.WriteLine(number1 + " <= " + number2);
            }
            if (number1 >= number2)
            {
                Console.WriteLine(number1 + " >= " + number2);
            }

        }
    }
}
