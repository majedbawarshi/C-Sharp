using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16 grade = Convert.ToInt16(textBox1.Text);
            string finalGrade;
            if (grade >= 90)
            {
                finalGrade = "A";
            }
            else if (grade >= 80)
            {
                finalGrade = "B";
            }
            else if (grade >= 70)
            {
                finalGrade = "C";
            }
            else if (grade >= 60)
            {
                finalGrade = "D";
            }
            else
            {
                finalGrade = "F";
            }
            label2.Text = finalGrade;
        }
    }
}
