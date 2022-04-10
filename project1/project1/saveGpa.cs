using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace project1
{
    class saveGpa : Calculate
    {
        private string[] disk = new string[3];
        private string s;
        public void SaveGpa()
        {
            getDiskName();
            Console.WriteLine("\nyour information will be writen to the directory " + disk[0] + "Your_gpa.txt\n");
            CreteEmptyFile();
            Console.WriteLine("\nEnter how many semester you want to know the total GPA of:");
            int semNum = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < semNum; i++)
            {
                Console.WriteLine("\nEnter your semester number:{0} information\n", i + 1);
                Calculate gp = new Calculate();
                gp.semesterGpa();
                gWg += gp.tWg;
                gECTS += gp.gCredet;
                tGpa = gWg / gECTS;
                s = "your semester " + (i + 1) + " gpa is:" + tGpa;
                FileWriteLine(s);
            }
            FileWriteLine("------------------------------");
            tGpa = gWg / gECTS;
            s = "your total gpa is:" + tGpa;
            FileWriteLine(s);
            Console.WriteLine("\nyour data has been successfully writed to the address " + disk[0] + "Your_gpa.txt\n");
            Console.Write("open the file to check your information.");
        }

        //write into file
        private void FileWriteLine(string s)
        {
            StreamWriter sw = new StreamWriter(@disk[0] + "Your_gpa.txt", true);
            sw.WriteLine(s);
            sw.Close();
        }

        //get one disk name other than C disk
        private void getDiskName()
        {
            int i = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.Name != "C:\\")
                {
                    disk[i] = d.Name;
                    i++;
                }
            }
        }
        private void CreteEmptyFile()
        {
            using (FileStream stream = new FileStream(@disk[0] + "Your_gpa.txt", FileMode.Create))
            using (TextWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("");
            }
        }
    }
}
