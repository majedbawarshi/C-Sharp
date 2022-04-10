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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "square";
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x * x);
            label3.Text = Convert.ToString(x * x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox4.Text);
            int y = Convert.ToInt32(textBox3.Text);
            label8.Text = Convert.ToString(x * y);
            label7.Text = Convert.ToString(x * y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox6.Text);
            label12.Text = Convert.ToString(3.14 * x * x);
            label11.Text = Convert.ToString(3.14 * x * x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }
    }
}
