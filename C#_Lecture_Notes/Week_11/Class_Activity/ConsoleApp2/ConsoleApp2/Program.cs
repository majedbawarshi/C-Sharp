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
            var students = new[]
           {
                new student("Omar",90,3500,"eng"),
                new student("majed",60,200,"soc"),
                new student("sami",95,9500,"eco"),
                new student("khaled",40,200,"eng"),
                new student("rani",20,6500,"soc"),
                new student("ahmad",546,5964,"eco"),
                new student("ghaith",75,200,"eng"),
                new student("tamer",33,5642,"soc"),
                new student("salah",90,9756,"eco"),
                new student("hasan",65,6546,"eco")
            };

            var markB30 =
                from s in students
                where (s.Mark > 30) && (s.Payment == 200)
                select s;
            foreach(var element in markB30) {
                Console.WriteLine(element);
            }

            var mark90 =
                from s in students
                where (s.Mark == 90) && (s.Faculty == "eng") && (s.Payment > 100)
                select s;
            foreach (var element in mark90)
            {
                Console.WriteLine(element);
            }


        }
    }
}