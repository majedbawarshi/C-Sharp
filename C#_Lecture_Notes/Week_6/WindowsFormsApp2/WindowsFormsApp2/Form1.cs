using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int[] x = new int[10];

            double avg;
            double sum=0;
            if(counter+2 == 11)
            {
                label1.Text = "Re-run the program only accepts 10 values";
            }
            else
            {
                label1.Text = "enter the value of the element: " + (counter + 2).ToString();
            }
            
            x[counter] = Convert.ToInt32(textBox1.Text);
            counter++;
            if (counter == 10)
            {

                for (counter = 0; counter < 10; counter++)
                {
                    sum += x[counter];
                }
                avg = sum / 10;

                if (avg > 3)
                {
                    label2.Text = "pass";
                }
                else
                {
                    label2.Text = "fail";
                }
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter the value of the 1 element:";
        }
    }
}
