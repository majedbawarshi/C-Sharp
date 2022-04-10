using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    textBox2.Text = "Sat";
                    break;
                case "2":
                    textBox2.Text = "Sun";
                    break;
                case "3":
                    textBox2.Text = "Mon";
                    break;
                case "4":
                    textBox2.Text = "Tue";
                    break;
                case "5":
                    textBox2.Text = "Wed";
                    break;
                case "6":
                    textBox2.Text = "Thu";
                    break;
                case "7":
                    textBox2.Text = "Fri";
                    break;
                default:
                    textBox2.Text = "out of rane";
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
