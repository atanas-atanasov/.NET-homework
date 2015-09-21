using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Task
{
    public partial class Registraion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if ((nameBox.Text != String.Empty) && (passBox.Text != String.Empty) && (passBox2.Text != String.Empty) && (passBox2.Text == passBox.Text) && (emailBox.Text != string.Empty))
            {
               using(StreamWriter writer = new StreamWriter("Entries.txt")) // Ne mi pravi faila v bin-a !?
               {
                   writer.WriteLine("{0}{1}{2}{3}{4}", nameBox.Text.PadRight(20, ' '), passBox.Text.PadRight(20, ' '), ageBox.Text.PadRight(20, ' '), emailBox.Text.PadRight(20, ' '));
               }
            }
            else
            {
               
            }
        }
    }
}