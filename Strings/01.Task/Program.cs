using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();


            //char[] arr = word.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine(arr);



            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //   Console.Write(word[i]);
            //}
            //   Console.WriteLine();


            StringBuilder reverse = new StringBuilder();
            for (int i = word.Length-1; i >=0; i--)
            {
                reverse.Append(word[i]);
            }
            Console.WriteLine(reverse);
        }
    }
}
