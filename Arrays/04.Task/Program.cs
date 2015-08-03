using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която търси число в масив от числа и връща индекса на първото намерено число.


namespace _04.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will You enter:");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number for search:");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (array[i] == search)
                {
                    Console.WriteLine("The idex of the number is " + i);
                }
                if (i ==count-1 && array[i]!=search)
                {
                    Console.WriteLine("Number not found!");
                }
            }
        }
    }
}
