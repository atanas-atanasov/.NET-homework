using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

namespace FinalExam
{
    public partial class Fate_of_the_World : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCountry_Click(object sender, EventArgs e)
        {
            AddCountry country = new AddCountry();
            country.Name = nameText.Text;
            country.Capital = capitalText.Text;
            country.Population = double.Parse(populationText.Text);
            
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(country);
            }
        }
    }
}