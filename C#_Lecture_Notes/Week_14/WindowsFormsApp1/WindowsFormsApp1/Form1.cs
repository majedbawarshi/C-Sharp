using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = oleDbConnection1;
            com1.CommandText = "select * from Students where id=1";
            oleDbConnection1.Open();
            textBox1.Text = com1.ExecuteScalar().ToString();
            oleDbConnection1.Close();
        }
    }
}
