using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете булев израз, който да проверява дали даден низ от символи (string) е равен на „Hello World”. Отпечатайте в конзолата резултата от проверката.


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello World";
            Console.WriteLine("Enter string");
            string b = Console.ReadLine();
            Console.Write("The string is the same as \"Hello World\":");
            Console.WriteLine(a==b);
        }
    }
}
