using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int years;

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public Person() { }
    }
}
