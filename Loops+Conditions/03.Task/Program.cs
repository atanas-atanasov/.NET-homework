using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която чете от конзолата поредица от цели числа (примерно 5 числа) и отпечатва най-малкото и най-голямото от тях.

namespace _03.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count of numbers to enter?:");
            int n = int.Parse(Console.ReadLine());
            int num;
            int min=0;
            int max=0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number:");
                num = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    min = num;
                    max = num;
                }
                if (min>num)
                {
                    min = num;
                }
                if (max<num)
                {
                    max = num;
                }
            }
            Console.Write("The minumum value is:");
            Console.WriteLine(min);
            Console.Write("The maxumum value is:");
            Console.WriteLine(max);
        }
    }
}
