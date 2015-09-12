using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //Writing text file to console as string
            try
            {
                string text = null;
                using (StreamReader reader = new StreamReader("text.txt"))
                {                  
                    writeToConsole(reader, text);
                }

            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FileEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void writeToConsole(StreamReader reader, string text)
        {
            text = reader.ReadToEnd();
            if (String.IsNullOrEmpty(text))                //в условието пише да няма try - catch в метода.
            {
                throw new FileEmptyException("The file is empty!");
            }
            Console.WriteLine(text);
        }
    }
}
