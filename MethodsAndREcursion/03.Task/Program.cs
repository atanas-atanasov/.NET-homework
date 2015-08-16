using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {

                int num1 = rnd.Next(-1000, 1000);
                int num2 = rnd.Next(-1000, 1000);
                int num3 = rnd.Next(-1000, 1000);
                double result = RandomParameters(num1, num2, num3);
                Console.WriteLine(result);
            }
        }

        private static double RandomParameters(int num1, int num2, int num3)
        {
            int result = 0;
            result = num1 * num2 * num3;
            return result;
        }

    }
}
