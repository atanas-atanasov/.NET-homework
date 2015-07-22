using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N). 

namespace _04.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N for N!:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K for K!:");
            int k = int.Parse(Console.ReadLine());
            int fac = 1;
            for (int i = k + 1; i < n + 1; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
        }
    }
}
