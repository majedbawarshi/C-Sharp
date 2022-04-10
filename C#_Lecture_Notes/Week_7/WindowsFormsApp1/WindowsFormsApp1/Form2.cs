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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "ali") && (textBox2.Text == "123"))
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect");
            }
        }
    }
}
