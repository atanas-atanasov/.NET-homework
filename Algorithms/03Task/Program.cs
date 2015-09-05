using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] split = sentence.Split(' ', ',','.');
            Array.Sort(split);
            foreach (var item in split)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}
