using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Да се напише програма, която чете два масива от конзолата и проверява дали са еднакви.


namespace _05.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of 1st array:");
            int a = int.Parse(Console.ReadLine());
            int[] array1 = new int[a];
            Console.WriteLine("Enter 1st array:");
            for (int i = 0; i < a; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter length of 2nd array:");
            int b = int.Parse(Console.ReadLine());
            int[] array2 = new int[b];
            Console.WriteLine("Enter 2st array:");
            for (int i = 0; i < b; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool check = array1.SequenceEqual(array2);
            Console.WriteLine("Are the arrays equivalent:");
            Console.WriteLine(check);
        }
    }
}
