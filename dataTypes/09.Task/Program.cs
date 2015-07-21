using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която приема стринг от конзолата, и извежда N-тия символ от стринга, като резултат. 

namespace _09.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter number of symbol to be displayed starting from 0:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(str1[a]);
        }
    }
}
