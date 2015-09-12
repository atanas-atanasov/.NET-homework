using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task
{
    class FileEmptyException: Exception
    {
        public FileEmptyException(String message)
            : base(message)
        {
        }
    }
}
