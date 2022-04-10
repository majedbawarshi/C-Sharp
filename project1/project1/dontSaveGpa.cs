using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{

    class dontSaveGpa : Calculate
    {
        public void FullGSemGpa()
        {
            Console.WriteLine("\nEnter how many semester you want to know the total GPA of:");
            int semNum = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < semNum; i++)
            {
                Console.WriteLine("\nEnter your semester number:{0} information\n", i + 1);
                Calculate gp = new Calculate();
                gp.semesterGpa();
                gWg += gp.tWg;
                gECTS += gp.gCredet;
            }
            tGpa = gWg / gECTS;
            Console.WriteLine("\nyour total gpa is:{0:0.00}", tGpa);
        }
    }
}
