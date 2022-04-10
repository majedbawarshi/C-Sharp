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
            var items = new List<string>();

            Console.WriteLine("Before adding to items: " +
                $"Count={items.Count}; Capacity ={items.Capacity}");

            items.Add("red");
            items.Insert(0, "yellow");

            Console.WriteLine("After adding two elements to items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.Write("\nDisplay list contents with computer controlled loop:");
            for(var i = 0; i < items.Count; i++)
            {
                Console.Write($"{items[i]}");
            }

            Console.Write("\nDisplay list contents with foreach statemnet:");
            foreach(var item in items)
            {
                Console.Write($"{item}");
            }

            items.Add("green");
            items.Add("yellow");

            Console.WriteLine("\n\nAfter adding two more element to items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");
        }
    }
}