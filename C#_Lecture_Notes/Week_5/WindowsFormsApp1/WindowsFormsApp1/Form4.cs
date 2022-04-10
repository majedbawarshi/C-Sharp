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
    public partial class Form4 : Form
    {
        private Boolean sum = false;
        private Boolean min = false;
        private Boolean multi = false;
        private Boolean divi = false;
        public Form4()
        {
            InitializeComponent();
        }

        /*
         equal sign
             */
        private void button14_Click(object sender, EventArgs e)
        {
            if(sum == true)
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox1.Tag)).ToString();
            else if(min == true)
                textBox1.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox1.Tag)).ToString();
            else if(multi == true)
                textBox1.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Tag)).ToString();
            else if(divi == true)
                textBox1.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox1.Tag)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        /*
         addition button
             */
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            sum = true;
        }

        /*
         subtraction
             */
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            min = true;
        }

        /*
         division
             */
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            divi = true;
        }

        /*
         multiplication
             */
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            multi = true;
        }

        /*
         clear C
             */
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
