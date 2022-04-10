using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Text";
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.Write("this is a test\n");
            sw.Write("this is the 2nd test");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Please select a text file";
            openFileDialog1.Filter = "text|*.txt";
            openFileDialog1.Title = "Open txt file";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\WindowsFormsApp1\WindowsFormsApp1\1.txt");
            if (!fi.Exists)
            {
                FileStream fs = fi.Create();
                fs.Close();
                fi = new FileInfo(@"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\WindowsFormsApp1\WindowsFormsApp1\1.txt");
            }
            StreamWriter sw;
            sw = fi.CreateText();
            sw.WriteLine("this is the sample for file info but this time it exists");
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\WindowsFormsApp1\WindowsFormsApp1\1.txt");
            listBox1.Items.Add("Creation Time: "     + fi.CreationTime.ToString() );
            listBox1.Items.Add( "Directory : "       + fi.Directory.ToString() );
            listBox1.Items.Add( "Extention: "        + fi.Extension.ToString() );
            listBox1.Items.Add( "lastAcecessTime : " + fi.LastAccessTime.ToString() );
            listBox1.Items.Add( "Is Readonly : "     + fi.IsReadOnly.ToString() );
            listBox1.Items.Add( "length is: "        + fi.Length.ToString() );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\WindowsFormsApp1\WindowsFormsApp1");
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo fi = new FileInfo(@"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\WindowsFormsApp1\WindowsFormsApp1\1.txt");
            fi.CopyTo(di.FullName + @"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\WindowsFormsApp1\WindowsFormsApp1\1.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DriveInfo drf = new DriveInfo(@"E:\");
            listBox1.Items.Add("availableFreeSpace : " + drf.AvailableFreeSpace.ToString() );
            listBox1.Items.Add( "Format is : " + drf.DriveFormat.ToString() );
            listBox1.Items.Add( "drive type is : " + drf.DriveType.ToString() );
            listBox1.Items.Add( "drive name is : " + drf.Name.ToString() );
            listBox1.Items.Add("total size is : " + drf.TotalSize.ToString());
            listBox1.Items.Add("drive free storage : " + drf.TotalFreeSpace.ToString());
            listBox1.Items.Add("volume label is : " + drf.VolumeLabel.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
}
