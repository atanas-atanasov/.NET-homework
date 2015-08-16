using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    public class Policeman:Emplayee
    {
        private string rang;

        public string Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Policeman(int hours, int salary, string rang)
           : base(salary,hours)
        {
            this.rang = rang;
        }

    }
}
