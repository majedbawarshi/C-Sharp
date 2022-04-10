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
        int cost=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cost += 8;
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cost += 10;
            button2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cost += 10;
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cost += 8;
            button4.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            cost += 9;
            button5.Enabled = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            cost += 9;
            button6.Enabled = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            cost += 9;
            button7.Enabled = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cost);
        }
    }
}
