using System;
namespace ConsoleApp1
{
    class Program
    {
        //First Function
        private static void fun1()
        {
            string output = "";

            int[] x;
            x = new int[10];


            int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };
            
            const int ARRAY_SIZE = 10;

            int[] z;
            z = new int[ARRAY_SIZE];


            for(int i = 0; i < z.Length; i++)
                z[i] = 2 + 2 * i;
            
            output += "subscript\tArray x\tArray y\tArray z\n";

            for(int i = 0; i < ARRAY_SIZE; i++)
                output += i + "\t" + x[i] + "\t" + y[i] + "\t" + z[i] + "\n";
            

            Console.WriteLine(output);
        }

        //second function
        private static void fun2()
        {
            int[] a = new int[10];
            for(int counter = 0; counter < 10; counter++)
                a[counter] = counter+1;
            
            int total = 0;

            for(int counter = 0; counter < 10; counter++)
                total += a[counter];
            
            Console.WriteLine("the total of arrays elements is: " + total);
        }

        private static void histogram()
        {
            int[] n = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 1 };
            string output = "";
            output += "Element\tVale\tHistogram\n";
            for(int counter = 0; counter < n.Length; counter++)
            {
                output += "\n" + (counter+1) + "\t" + n[counter] + "\t";

                for (int counter2 = 0; counter2 < n[counter]; counter2++)
                    output += "*";

            }
            
            Console.WriteLine("\nHistogram Printing Program:\n" + output );
            
        }

        private static void classActivity()
        {
            int[] n = new int[10];

            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Please enter you {0} Number",counter+1);
                n[counter] = Convert.ToInt32(Console.ReadLine());
            }


            string output = "";
            output += "Element\tVale\tHistogram\n";
            for (int counter = 0; counter < n.Length; counter++)
            {
                output += "\n" + (counter + 1) + "\t" + n[counter] + "\t";

                for (int counter2 = 0; counter2 < n[counter]; counter2++)
                    output += "*";

            }

            Console.WriteLine("\nHistogram Printing Program:\n" + output);
        }


        static void Main(string[] args)
        {
            /*fun1();
            fun2();
            histogram();
            classActivity();*/
        }
    }
}
