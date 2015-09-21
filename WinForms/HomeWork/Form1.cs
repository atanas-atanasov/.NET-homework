using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Enabled = false;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = String.Empty;
            try
            {


            var adress = new System.Net.Mail.MailAddress(textBox3.Text);
            StreamReader reader = new StreamReader("Entries.txt");
            string readFile = reader.ReadToEnd();
            reader.Close();
            if (readFile.Contains(textBox3.Text))
            {
                label4.Text = "Email is already in use!";
            }
            else
            {
                StreamWriter writer = new StreamWriter("Entries.txt", true);
                writer.WriteLine("{0}{1}{2}", textBox1.Text.PadRight(50, ' '), textBox2.Text.PadRight(50, ' '), textBox3.Text);
                writer.Close();
                label4.Text = "Registration successful!";
            }

            }
            catch (Exception)
            {
                label4.Text = "Invalid email!";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty && textBox1.Text != String.Empty)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                button1.Enabled = false;
                textBox3.Text = string.Empty;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty && textBox2.Text != String.Empty && textBox1.Text != String.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;

            }
        }
    }
}
