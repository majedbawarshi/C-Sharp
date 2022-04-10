using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randint = new Random();
            Random randint2 = new Random();
            int n1,n2;
            int counter1=0, counter2=0;
            for(int counter = 0; counter < 100; counter++)
            {
                n1 = randint.Next(1, 7);
                n2 = randint2.Next(1, 20);
                if (n1 == n2)
                    counter1++;
                else
                    counter2++;
            }
            Console.WriteLine("Connected for {0}\ndisconnected for {1}" , counter1,counter2);
        }
    }
}