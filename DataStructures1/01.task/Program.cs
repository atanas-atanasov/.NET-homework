using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter odd numbers:");
            string number = "0";

            for (; ;)
            {
                number = Console.ReadLine();
                if (number == string.Empty)
                {
                    break;
                }
                else if (int.Parse(number) > 0 && int.Parse(number) % 2 == 0)
                {
                    numbers.Add(int.Parse(number));
                }
                else
                {
                    Console.WriteLine("The entry does not meet the requirements");
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}

