using System;
using System.Collections;
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
            int[] numbers = new int[10000000];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-100000000, 100000000);
            }

            ArrayList odd = new ArrayList();
            ArrayList even = new ArrayList();
            for (int i = 0; i < numbers.Length; i++)
            {
                //if (arr[i]==0)
                //{
                //    continue;           wikipedia казва,че 0(нула) е четно.
                //}
                if (numbers[i] % 2 == 0)
                {
                    odd.Add(numbers[i]);
                }
                else
                {
                    even.Add(numbers[i]);
                }
            }
            Console.WriteLine("Time to sort all numbers:");
            double time = Environment.TickCount;
            Array.Sort(numbers);
            Console.WriteLine(Environment.TickCount-time);

            Console.WriteLine("Time to sort even numbers in acsending order:");
            double time2 = Environment.TickCount;
            even.Sort();
            Console.WriteLine(Environment.TickCount - time2);

            Console.WriteLine("Time to sort odd numbers in descending order:");
            double time3 = Environment.TickCount;
            odd.Reverse();
            Console.WriteLine(Environment.TickCount - time3);
            
               
        }
    }
}
