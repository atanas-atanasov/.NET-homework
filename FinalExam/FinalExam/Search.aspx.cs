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
    public partial class Search : System.Web.UI.Page
    {
        public string[] country;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            { }
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line;
                line = reader.ReadLine();
                country = line.Split('|');
                if (nameSearch.Text==country[0])
                {
                    booksRepeater.DataSource = country;
                    booksRepeater.DataBind();
                }
            }
        }
    }
}