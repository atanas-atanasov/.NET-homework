using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която създава масив с 10 елемента от целочислен тип и инициализира елементите със стойност индекса  умножен по 10.

namespace _03.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]*10);
            }
        }
    }
}
