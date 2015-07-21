using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която приема 2 символни низа (string) като вход, и изведете като резултат конкатениран string със „|“ между двата входни низа.

namespace _06.Tastk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            Console.WriteLine(str1 + "|" + str2);
        }
    }
}
