using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txt1, txt2 = 0;
            txt1 = Convert.ToInt32(textBox1.Text);
            txt2 = Convert.ToInt32(textBox2.Text);
            label1.Text = (txt1 + txt2).ToString();

            int total,
                gradeCounter,
                gradeValue,
                average;
            total = 0;
            gradeCounter = 1;
            while(gradeCounter <= 10)
            {
                Console.WriteLine("Enter integer grade: ");
                gradeValue = Int32.Parse(Console.ReadLine());
                total = total + gradeValue;
            }
        }
    }
}
