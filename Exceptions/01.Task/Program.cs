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

                using (StreamWriter writer = new StreamWriter("ToWrite.txt"))
                {
                  WriteToFile(writer,text);
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
            catch(NoTextException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void WriteToFile(StreamWriter writer, string text)
        {
            Console.WriteLine("Enter text to be written on file!");
            text = Console.ReadLine();
            if (String.IsNullOrEmpty(text))
            {
                throw new NoTextException("You wrote nothing!");
            }
            writer.WriteLine(text);

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
