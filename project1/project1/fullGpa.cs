using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{

    class fullGpa : Calculate
    {

        //fullGpa class constructor
        public fullGpa()
        {
            char g;
            Console.Write("\n\nDo you want to save the result on your computer?(c drive)\nIf yes please press y if no press n\n~");
            g = Convert.ToChar(Console.ReadLine());
            if (g == 'Y' || g == 'y')
            {
                saveGpa SG = new saveGpa();
                Console.WriteLine("\nadd all information below carefully ! :)");
                SG.SaveGpa();
            }
            else if (g == 'N' || g == 'n')
            {
                dontSaveGpa DSG = new dontSaveGpa();
                Console.WriteLine("\nadd all information below carefully ! :)");
                DSG.FullGSemGpa();
            }
            else
            {
                Console.WriteLine("You have entered invalid character!\a please try again:");
                fullGpa f = new fullGpa();
            }
        }
    }
}
