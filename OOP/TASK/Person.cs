using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
     abstract class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string familyName;

        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        private int exp;

        public int Experience
        {
            get { return exp; }
            set { exp = value; }
        }

        public Person(string name,string familyName,int exp)
        {
            this.name = name;
            this.familyName = familyName;
            this.exp = exp;
        }
        public Person()
        {

        }
    }
}
