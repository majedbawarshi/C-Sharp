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
        String txt1, txt2;
        int i = 0, j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            int result = txt1.IndexOf(txt2);
            if (result == -1)
                MessageBox.Show("it is not in the text");
            else
                MessageBox.Show(result.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            textBox1.Text = txt1.Insert(3, txt2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = textBox1.Text.Length;
            txt1 = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = txt1.Substring(i, j) + "..." + txt1.Substring(0, j);
            i--;
            j++;
            if (i== 0)
            {
                i = textBox1.Text.Length;
                j = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            textBox1.Text = txt1.Remove(3,3);
        }
    }
}
