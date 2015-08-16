using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd number:");
            int num3 = int.Parse(Console.ReadLine());

            int maxNum12 = CalculateMax(num1, num2);
            int maxNum123 = CalculateMax(maxNum12, num3);
            Console.WriteLine("The biggest number is:" + maxNum123);

        }

        private static int CalculateMax(int first, int second)
        {
            int max = 0;
            if (first > second)
            {
                max = first;
            }
            else
            {
                max = second;
            }
            return max;
        }
    }
}
