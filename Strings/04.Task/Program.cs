using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter word to search:");
            string word = Console.ReadLine();

            string[] arr = sentence.Split('.');


            foreach (var item in arr)
            {
                if (item.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(item.TrimStart() + ".");
                }
            }

        }
    }
}
