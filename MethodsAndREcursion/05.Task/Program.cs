using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <=999; i++)
            {
                PrintSymetric(i);
            }
        }

        private static void PrintSymetric(int i)
        {
            if (i<100)
            {
                if (i/10==i%10)
                {
                    Console.WriteLine(i);
                }
            }
            else if(i/100==i%10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
