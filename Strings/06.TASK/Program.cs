using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.TASK
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] chars = new string[] { "?", ".", "!" };
            using (StreamReader reader = new StreamReader("fileToRead.txt"))
            {
                using (StreamWriter writer = new StreamWriter("fileToWrite.txt"))
                {
                    string line = reader.ReadLine();
                    StringBuilder toWrite = new StringBuilder();
                    while (line != null)
                    {
                        foreach (var item in chars)
                        {
                            line = line.Replace(item, string.Empty);
                        }
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
