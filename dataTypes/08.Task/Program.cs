using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която приема два стринга като вход. След това проверява дали 2рия стринг се съдържа в 1вия. Покажете резултата от проверката на конзолата. 

namespace _08.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter second string");
            string str2 = Console.ReadLine();
            bool a = str1.Contains(str2);
            Console.WriteLine(a);
            
        }
    }
}
