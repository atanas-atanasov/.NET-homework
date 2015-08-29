using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.task
{
    class CAr
    {
        private string priece;

        public string Priece
        {
            get { return priece; }
            set { priece = value; }
        }

        public CAr(string price)
        {
            this.priece = price;
        }
    }
}
