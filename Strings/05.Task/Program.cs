using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentance:");
            string sentence = Console.ReadLine();
            int count = 0;
            int i = 0;
            int y = 0;
            string char1 = "(";
            string char2 = ")";
            while ((i = sentence.IndexOf(char1, i)) != -1)
            {
                i += char1.Length;
                count++;
            }
            
            while ((y = sentence.IndexOf(char2, y)) != -1)
            {
                y += char2.Length;
                count--;
            }
            if (!sentence.Contains("(") && !sentence.Contains(")"))
            {
                Console.WriteLine("Does not contain required elements!");
            }
            else  if (count ==0 && sentence.IndexOf(char1)<sentence.IndexOf(char2)&& sentence.LastIndexOf(char2)>sentence.LastIndexOf(char1))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
        }
    }
}

      
