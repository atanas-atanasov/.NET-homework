using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Напишете програма, която попълва числата на Фибоначи в масив. Потребител въвежда колко да е голям масива.


namespace _02.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            BigInteger[] array = new BigInteger[a];
            array[0] = 0;
            array[1] = 1;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i-1] + array[i - 2];
                Console.WriteLine(array[i]);
            }
        }
    }
}
