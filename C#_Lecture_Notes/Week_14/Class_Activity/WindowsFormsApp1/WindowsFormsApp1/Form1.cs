using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("SELECT * from  students WHERE average > 50");
            command.Connection = oleDbConnection1;
            oleDbConnection1.Open();
            OleDbDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
               richTextBox1.Text += reader[0].ToString() + " ";
                richTextBox1.Text += reader[1].ToString() + " ";
                richTextBox1.Text += reader[2].ToString() + " ";
                richTextBox1.Text += reader[3].ToString() + " ";
                richTextBox1.Text += "\n";
            }
            reader.Close();
            oleDbConnection1.Close();
        }
    }
}
