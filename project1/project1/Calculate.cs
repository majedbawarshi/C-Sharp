using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Calculate
    {

        //x=variable for for loop ,ECTS =subject credit
        public int x, ECTS, subNum, gCredet, tECTS = 0, gECTS = 0;
        //result of the subject in letters e.g AA
        public string gr;
        //wg= ects*gr,twWg total wg,iGr int gr,tgr total gr
        public float wg = 0.0f, tWg = 0.0f, igr = 0.0f, igr2 = 0.0f, gpa, tgr = 0.0f, semGpa, tGpa = 0.0f, gWg = 0.0f;


        public void semesterGpa()
        {
            Console.WriteLine("Enter your amount of subjects:");
            subNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your total semester subject credit:");
            gCredet = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            for (x = 0; x < subNum; x++)
            {
                Console.WriteLine("Enter your {0} subject result in letter:", x + 1);
                gr = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your {0} subject ECTS:", x + 1);
                ECTS = Int32.Parse(Console.ReadLine());

                //making user input upper case
                gr = toUpper(gr);
                //assign the string into character array
                char[] charArr = gr.ToCharArray();

                igr = (int)charArr[0];//casting
                igr2 = (int)charArr[1];//casting

                tgr = GR(igr, igr2);//returning the result of GR (grade) in number
                wg = ECTS * tgr;//Weighted Grade calculating

                tWg = tWg + wg;//the total weighted grade of the semester

            }
            gpa = tWg / gCredet;
        }
        public void printGpa()
        {
            Console.WriteLine("your total GPA is :{0:0.00}", gpa);
        }

        //convert to upper
        private string toUpper(string text)
        {
            char[] textCharArr = text.ToCharArray();
            for (int i = 0; i < textCharArr.Length; i++)
            {
                char current = textCharArr[i];
                if (current >= 'a' && current <= 'z')
                {
                    int distance = current - 'a';
                    textCharArr[i] = (char)('A' + distance);
                }
            }
            return new string(textCharArr);
        }

        //Calculating subject credit
        private float GR(float igr, float igr2)
        {
            //fix this for the following ac,ad,af,bc,bd,bf,cf or opposite in the sending function
            float aGR = 0.0f, aGR2 = 0.0f;
            //A=65, B=66, C=67, D=68, F=70 
            if (igr == 65) { aGR = 2.0f; }
            else if (igr == 66) { aGR = 1.5f; }
            else if (igr == 67) { aGR = 1.0f; }
            else if (igr == 68) { aGR = 0.5f; }
            else if (igr == 70) { aGR = 0.0f; }

            if (igr2 == 65) { aGR2 = 2.0f; }
            else if (igr2 == 66) { aGR2 = 1.5f; }
            else if (igr2 == 67) { aGR2 = 1.0f; }
            else if (igr2 == 68) { aGR2 = 0.5f; }
            else if (igr2 == 70) { aGR2 = 0.0f; }

            return (aGR + aGR2);
        }
    }
}
