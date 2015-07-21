using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете проргама която приема 2 целочислени числа за вход и извежда остатъка от делението на числата.

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The remainder after division a:b");
            Console.WriteLine(a%b);
            Console.WriteLine("The remainder after division b:a");
            Console.WriteLine(b%a);
        }
    }
}
