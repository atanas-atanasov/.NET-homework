using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която намира сбора на всичките четни елементи в масив.


namespace _01.task
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter size of array:");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
