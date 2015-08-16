using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            decimal fac = Fac(n);
            Console.WriteLine(fac);
        }
        private static decimal Fac(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }
    }
}