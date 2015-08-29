using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
   public class Teacher:Person
    {
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

       public Teacher(string name,string familyName,int exp, string subject)
           :base(name,familyName,exp)
        {
            this.name = "Ivan";
            this.familyName = "Ivanov";
            this.exp = 10;
            this.subject = "Biology";
        }
       public Teacher()
       {
           this.familyName = "Ivanov";
           this.exp = 10;
           this.subject = "Biology";
           this.name = "Ivan";
       }
       public void Homework()
       {
           Console.WriteLine("{0} {1} the {2} checked the homework",name,familyName,subject);
       }
       public void Hello()
       {
           Console.WriteLine("{0} {1} the {2} said Hello!", name, familyName, subject);
       }
       public void Bye()
       {
           Console.WriteLine("{0} {1} the {2} said Goodbye", name, familyName, subject);
       }
    }
}
