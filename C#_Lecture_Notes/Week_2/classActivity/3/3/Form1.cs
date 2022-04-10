using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 numberInt;
            double result = 1;
            numberInt = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= numberInt; i++)
            {
                result = result * i;
            }
            label2.Text = Convert.ToString(result);
        }
    }
}
