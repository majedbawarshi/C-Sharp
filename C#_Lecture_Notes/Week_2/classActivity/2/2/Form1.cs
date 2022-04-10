using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        Int16 getValue;
        int counter = 0;
        Int16 sum=0;
        int n = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < n)
            {
                getValue = Convert.ToInt16(textBox1.Text);
                sum += getValue;
                counter++;
            }
            else
            {
                label3.Text = Convert.ToString(sum / n);
            }
            

        }
    }
}
