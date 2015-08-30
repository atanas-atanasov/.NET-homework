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
            List<int> numbers = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int[] array = new int[numbers.Count];
            numbers.Sort();


            for (int i = 0; i < numbers.Count; i++)
            {
                array[numbers[i]]++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= (numbers.Count / 2 + 1))
                {
                    Console.WriteLine("Мажоранта е " + i);
                }
            }
        }
    }
}
