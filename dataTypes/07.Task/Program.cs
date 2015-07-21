using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Напишете програма, която приема реално число като вход, и изкарва на конзолата резултата от делението му с цяло число.

namespace _07.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter real number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Real number divided by the integer: {0}", num1/num2);
            Console.WriteLine("The remainder of the division: {0}", num1%num2);

        }
    }
}
