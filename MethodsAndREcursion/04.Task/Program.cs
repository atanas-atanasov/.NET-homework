using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            OddOrEven(number);
            
        }

        private static void OddOrEven(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Number is zero (0)!");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Number is even!");
            }
            else
            {
                Console.WriteLine("Number is odd!");
            }
        }

    }
}
