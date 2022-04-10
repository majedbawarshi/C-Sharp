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

            double amount, principal = Convert.ToDouble(textBox1.Text);
            double rate = Convert.ToDouble(textBox3.Text);
            string output = "";
            for (int i = Convert.ToInt32(textBox2.Text); i <= 10; i++)
            {
                amount = principal * (double)Math.Pow(1.0 + rate, i);

                output += String.Format("{0:C}", amount) + "\n";
            }

            label3.Text = output;
        }
    }
}
