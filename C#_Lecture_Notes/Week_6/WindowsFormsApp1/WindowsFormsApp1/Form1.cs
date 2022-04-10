using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter = 'a';
            char[] letters = new char[3];
            label1.Text = " ";
            for(int counter = 0; counter < 3; counter++)
            {
                letters[counter] = letter;
                letter++;
            }

            foreach(char item in letters)
            {
                label1.Text += item + " ";
            }

            string[] a = new string[3];
            a[0] = "a";
            a[1] = "b";
            a[2] = "C";
            MessageBox.Show(a.Length.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] a = { "a", "b", "c" };
            MessageBox.Show(a.Length.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string [,] a = { { "0","1","2" } , { "3", "4", "5" } , { "6", "7", "8" } };
            label1.Text = " ";

            /*
             Either by foreach or by for
             */


            foreach(string item in a)
            {
                label1.Text += item + " ";
            }


            label1.Text += "\n";
            /*
             using for loop
             */
             for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    label1.Text += a[i, j] + " ";
                }
                label1.Text += "\n";
            }
        }
    }
}
