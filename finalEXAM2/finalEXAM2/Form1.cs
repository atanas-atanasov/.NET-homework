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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.Show();
            srch.Top = this.Top;
            srch.Left = this.Left;
            try
            {
                using (StreamReader read = new StreamReader("DataBase.txt"))
                {
                }
            }
            catch (Exception)
            {
              
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country2 country = new Country2();
            country.Name = textBox1.Text;
            country.Capital = textBox2.Text;
            country.Population = double.Parse(textBox3.Text);
            using (StreamWriter writer = new StreamWriter("DataBase.txt", true))
            {
                writer.WriteLine(country);
            }
        }
    }
}
