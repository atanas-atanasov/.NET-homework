using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Task_2
{
    class Program
    {
        public static int lineNum = 0;
        static void Main(string[] args)
        {
            Test();
            Console.WriteLine(lineNum);
        }

        private static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                lineNum++;
            }
        }
    }
}
