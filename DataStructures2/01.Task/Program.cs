using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Task
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            IDictionary<String, int> wordOccurrenceMap = GetWordOccurrenceMap(text);
            PrintWordOccurrenceCount(wordOccurrenceMap);
        }
        private static IDictionary<string, int> GetWordOccurrenceMap(string text)
        {
            string[] chars =
            text.Split(' ', '.', ',', '-', '?', '!');
            SortedDictionary<string, int> words = new SortedDictionary<string, int>();
            
            foreach (string word in chars)
            {
                if (string.IsNullOrEmpty(word.Trim()))
                {
                    continue;
                }
                int count;
                if (!words.TryGetValue(word, out count))
                {
                    count = 0;
                }
                words[word] = count + 1;
            }
            return words;
        }
        private static void PrintWordOccurrenceCount(
        IDictionary<string, int> wordOccuranceMap)
        {
            foreach (KeyValuePair<string, int> wordEntry
            in wordOccuranceMap)
            {
                Console.WriteLine(
                "Word '{0}' occurs {1} time(s) in the text",
                wordEntry.Key, wordEntry.Value);
            }
            Console.ReadKey();
        }
    }
}