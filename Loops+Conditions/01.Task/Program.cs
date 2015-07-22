using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която за дадени две числа, намира най-големия им общ делител.

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int c;

            if (num2>num1)
            {
                c = num1;
                num1 = num2;
                num2 = c;

            }

            while (num2 != 0)
            {
                c = num1 % num2;
                num1 = num2;
                num2 = c;
            }
            Console.WriteLine(num1);
        }
    }
}
