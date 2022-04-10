using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 5;
            int z;
            Console.WriteLine($"Original vlaue of y: {y}");
            Console.WriteLine("original values of z: uninitialized");

            SquareRef(ref y);
            SquareOut(out z);

            Console.WriteLine($"Value of y after SquareRef: {y}");
            Console.WriteLine($"Value of z after SquareOut: {z}");

            Square(y);
            Square(z);
        }

        static void SquareRef(ref int x)
        {
            x = x * x;
        }

        static void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }

        static void Square(int x)
        {
            x = x * x;
        }
    }
}
