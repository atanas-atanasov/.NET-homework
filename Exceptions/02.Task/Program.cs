using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Task
{
  
    class Program
    {       
        static void Main(string[] args)
        {
            int lineNum = 0;
            try
            {
                string line = null;
                
                using (StreamReader reader = new StreamReader("text.txt"))
                {
                    ReadFile(reader, line,lineNum);
                }
            }
            catch (SentenceNotCompleteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(lineNum);
            }
        }

        private static void ReadFile(StreamReader reader, string line, int lineNum)
        {

            line = reader.ReadLine();
            while (line != null)
            {
                lineNum++;
                if (line[line.Length-1] != '!' && line[line.Length-1] != '?' && line[line.Length-1] != '.')
                {
                    throw new SentenceNotCompleteException("Изречението на ред " + lineNum + " не е завършено");                   
                }
                line = reader.ReadLine();
            }
        }
    }
}
