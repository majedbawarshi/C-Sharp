using System;

namespace ClassActivity1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your kelvin: ");

            Double kelvin = Double.Parse(Console.ReadLine());

            Double farh;

            farh = (9 / 5) * (kelvin - 273) + 32;

            Console.WriteLine("{0} in farhanhite is: {1}",kelvin,farh);

            Console.Write("Enter your Celesius: ");

            Double cel = Double.Parse(Console.ReadLine());

            Double kel = cel + 273;

            Console.WriteLine("{0} in kelvin is: {1}",cel ,kel);*/



            /*Console.Write("please enter a number between 0-10: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("the cube of {0} is: {1}, \n the square of {0} is: {2}", 
                num, num * num * num, num * num);*/

            Console.WriteLine("input the radius: ");
            Double radius = Double.Parse(Console.ReadLine());
            Double pi = 3.14;

            Console.WriteLine("the diameter is: {2}\nthe circumference of the circle is: {0}\nThe area of the circle is: {1}",
                2*pi*radius,pi*radius*radius,2*radius);
            
        }
    }
}
