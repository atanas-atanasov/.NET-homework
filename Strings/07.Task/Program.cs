using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _07.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("fileTOread.txt"))
            {
                using (StreamWriter writerOdd = new StreamWriter("oddLines.txt"))
                {
                    using (StreamWriter writerEven = new StreamWriter("evenLines.txt"))
                    {
                        int lineNum = 0;
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            lineNum++;
                            if (lineNum % 2 == 1)
                            {
                                writerOdd.WriteLine(line);
                            }
                            else
                            {
                                writerEven.WriteLine(line);
                            }
                            line = reader.ReadLine();
                        }
                    }
                }
            }


        }
    }
}
