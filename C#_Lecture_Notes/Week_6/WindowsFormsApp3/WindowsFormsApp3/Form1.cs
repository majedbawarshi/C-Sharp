using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userInput = Convert.ToInt32(textBox1.Text);
            int fibo = calcFibo(userInput);
            label2.Text = "Fibonacci values is: " + Convert.ToString(fibo);
        }

        private int calcFibo(int number)
        {
            if (number == 0)
                return 0;
            
            else if (number == 1)
                return 1;
            else
                return calcFibo((number - 1)) + calcFibo((number - 2));
            
        }
    }
}
