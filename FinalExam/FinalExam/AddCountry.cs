using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam
{
    public class AddCountry
    {
        private string name;
        private string capital;
        private double population;

        public double Population
        {
            get { return population; }
            set { population = value; }
        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.name, this.capital, this.population);
        }
    }
}