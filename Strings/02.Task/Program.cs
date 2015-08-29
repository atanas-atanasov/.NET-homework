using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the sentance:");
            string sentenceInput = Console.ReadLine();
            string sentence = sentenceInput.ToLower();
            Console.WriteLine(sentence);
            Console.WriteLine(sentence.Replace(word, word.ToUpper())); 
            
        }
    }
}
