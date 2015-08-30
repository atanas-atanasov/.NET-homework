using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int[] array = new int[1001];
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                array[numbers[i]]++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]!=0)
                {
                    Console.WriteLine(i + "->" + array[i]);
                }
            }
        }
    }
}
