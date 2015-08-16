using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
   public class Emplayee
    {
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Emplayee(int hours,int salary)
        {
            this.hours=hours;
            this.salary=salary;
        }
    }
}
