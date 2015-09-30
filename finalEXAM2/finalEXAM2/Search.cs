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

namespace finalEXAM2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            this.Hide();
            add.Show();
            add.Top = this.Top;
            add.Left = this.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            using (StreamReader reader = new StreamReader("DataBase.txt"))
            {
                string line = reader.ReadLine();
                string[] toPrint = line.Split('|');
                while (line != null)
                {
                    if (textBox1.Text == toPrint[0])
                    {
                        richTextBox1.Text += toPrint[0] + Environment.NewLine + toPrint[1] + Environment.NewLine + toPrint[2] +
                             Environment.NewLine + Environment.NewLine;
                    }
                    line = reader.ReadLine();
                }
            }
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 add = new Form1();
            this.Hide();
            add.Show();
            add.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            using (StreamReader reader = new StreamReader("DataBase.txt"))
            {
                string line = reader.ReadLine();
                string[] toPrint = line.Split('|');
                while (line != null)
                {
                    if (textBox2.Text == toPrint[1])
                    {
                        richTextBox1.Text += toPrint[0] + Environment.NewLine + toPrint[1] + Environment.NewLine + toPrint[2] +
                             Environment.NewLine + Environment.NewLine;
                    }
                    line = reader.ReadLine();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            using (StreamReader reader = new StreamReader("DataBase.txt"))
            {
                string line = reader.ReadLine();
                string[] toPrint = line.Split('|');
                while (line != null)
                {
                    if (double.Parse(toPrint[2])>=double.Parse(textBox3.Text) && double.Parse(toPrint[2])<double.Parse(textBox4.Text))
                    {
                        richTextBox1.Text += toPrint[0] + Environment.NewLine + toPrint[1] + Environment.NewLine + toPrint[2] +
                             Environment.NewLine + Environment.NewLine;
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}