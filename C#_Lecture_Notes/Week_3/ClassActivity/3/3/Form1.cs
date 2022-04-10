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
            int accountNumber   = Convert.ToInt32(textBox1.Text);
            double Bm           = Convert.ToDouble(textBox2.Text);
            double chargedTotal = Convert.ToDouble(textBox3.Text);
            double totalCredit  = Convert.ToDouble(textBox4.Text); 
            double creditLimit  = Convert.ToDouble(textBox5.Text);

            double balance = Bm + chargedTotal - totalCredit;

            if( balance <=creditLimit)
            {
                label5.Text = "The balance is: " + balance.ToString();
            }
            else
            {
                label5.Text = "credit limit is exceeded";
            }

        }
    }
}
