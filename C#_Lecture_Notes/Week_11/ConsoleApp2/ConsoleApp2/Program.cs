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
            var employees = new[]
            {
                new Employee("Jason","Red",5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James","Indigo",4700.77M),
                new Employee("Luke","Indigo",6200M),
                new Employee("Jason","Blue",3200M),
                new Employee("Wendy","Brown",4236.4M)
            };
            Console.WriteLine("Original Array:");
            foreach (var element in employees)
                Console.WriteLine($" {element}");

            var betweek4k6k =
                from e in employees
                where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
                select e;

            Console.WriteLine("\nEmployee earning in the range" +
                $" {4000:C} - {6000:C} per month ");
            foreach (var element in betweek4k6k)
            {
                Console.WriteLine(element);
            }

            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            Console.WriteLine("\nFirst employee then sorted by name:");
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            var lastNames =
                from e in employees
                select e.LastName;

            Console.WriteLine("\nUnique employee last names:");
        }
    }
}
