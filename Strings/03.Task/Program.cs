using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Enter sentance:");
            string sentenceInput = Console.ReadLine();
            Console.WriteLine("Enter word to search");
            string wordInput = Console.ReadLine();
            string word = wordInput.ToLower();
            string sentence = sentenceInput.ToLower();     
            int count = 0;
            int i = 0;
            while ((i = sentence.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            Console.WriteLine(count);
        }
    }


}




