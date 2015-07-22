using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K. 

namespace _05.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N for N!:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K for K!:");
            int k = int.Parse(Console.ReadLine());
            int sumN = 1;
            int sumK = 1;
            for (int i = n-k+1; i < n+1; i++)
            {
                sumN *= i;
            }
            for (int i = 1; i < k+1; i++)
            {
                sumK *= i;
            }
            Console.WriteLine(sumK*sumN);
        }
    }
}
