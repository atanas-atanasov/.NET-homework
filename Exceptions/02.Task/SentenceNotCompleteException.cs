using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task
{
    class SentenceNotCompleteException : Exception
    {
        public SentenceNotCompleteException(String message)
            : base(message)
        {          
        }       
    }
}
