using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 10;
            int d = 0;
            for (int a = 0; a < 20; a++)
            {

                for (int b = 0; b < 20; b++)
                {

                    if (c < a + b)
                    {
                        d++;
                    }
                }
            }
            Console.WriteLine("Number of possibilities is: {0}", d);
        }
    }
}
