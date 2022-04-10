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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == true)
                e.Handled = true;
        }

        private void textBox1_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                MessageBox.Show("A");
        }

        private void textBox1_mouseOver(object sender, EventArgs e)
        {
            //textBox1.Cursor = Cursors.No;
        }

        private void Button1_Hover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void Form1_Move(object sender, MouseEventArgs e)
        {
            label2.Text = e.X.ToString();
            label3.Text = e.Y.ToString();
        }

        private void textBox1_mouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Enter";
        }

        private void textBox1_mouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Leave";
        }
    }
}
