using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double food1Price = 100;
            const double food2Price = 200;
            const double food3Price = 300;
            double taxes = 0, rate = 0.18;

            Boolean check1 = false;
            Boolean check2 = false;
            Boolean check3 = false;

            int quantityFood1 = Convert.ToInt32(textBox1.Text);
            int quantityFood2 = Convert.ToInt32(textBox2.Text);
            int quantityFood3 = Convert.ToInt32(textBox3.Text);
            double total = (quantityFood1 * food1Price) + (quantityFood2 * food2Price) + (quantityFood3 * food3Price);

            if (checkBox1.Checked)
            {
                total += 25;
                check1 = true;
            }
            
            if (checkBox2.Checked)
            {
                total += 35;
                check2 = true;
            }
                
            if (checkBox3.Checked)
            {
                total += 50;
                check3 = true;
            }

            StreamWriter sr = new StreamWriter(
                @"E:\For_Backup\UniversitySubjects\university_docs\thirdYear\FirstSemester\C#\13th_week\Class_Activity\WindowsFormsApp1\WindowsFormsApp1\orders.txt");
            sr.WriteLine("you have ordered {0} pizzas \n you have ordered {1} burger \n you have ordered {2} kumpir",quantityFood1,quantityFood2,quantityFood3);
            sr.WriteLine("extra choosen:");
            if (check1)
                sr.WriteLine("extra cheese");
            if (check2)
                sr.WriteLine("double cheese");
            if (check3)
                sr.WriteLine("double beef");

            sr.WriteLine("tax: " + total * rate);
            sr.WriteLine("your total is: {0}", total);

            sr.Close();
        }
    }
}
