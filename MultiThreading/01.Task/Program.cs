using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Thread t1 = new Thread(new ThreadStart(Job));
            Thread t2 = new Thread(new ThreadStart(Job));
            Thread t3 = new Thread(new ThreadStart(Job));
            Thread t4 = new Thread(new ThreadStart(Job));
            Thread t5 = new Thread(new ThreadStart(Job));

            char[] test = new char[rand.Next(4, 10)];
            t1.Start();
            t2.Start();
            t1.Name = NameTHread(test);
            t2.Name = NameTHread(test);
           // t3.Name = NameTHread(test);
           // t4.Name = NameTHread(test);
          //  t5.Name = NameTHread(test);
            Console.WriteLine(t1.Name);            
            Console.WriteLine(t2.Name);
          //  Console.WriteLine(t3.Name);
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();

           
          
            
        }

        private static string NameTHread(char[] test)
        {
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            Random rand = new Random();
           // char[] test = new char[rand.Next(4, 10)]; //дължина на името
            for (int i = 0; i < test.Length; i++)
            {
                Thread.Sleep(5); ///!!!
                test[i] = chars[rand.Next(0, 25)];        //знак за всеки индекс от масива с името
            }
            string testString = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(new string(test));
            //testString = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(testString);
            return (testString);
        }



        private static void Job()
        {
            Console.WriteLine("The thread is started");
          //  Генериране на име
            //string chars = "qwertyuiopasdfghjklzxcvbnm";
            //Random rand = new Random();
            //char[] test = new char[rand.Next(4, 10)]; //дължина на името
            //for (int i = 0; i < test.Length; i++)
            //{
            //    test[i] = chars[rand.Next(0, 25)];        //знак за всеки индекс от масива с името
            //}
            //string testString = new string(test);
            //testString = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(testString); //първата буква да е главна.
            //Thread.CurrentThread.Name = testString;                                           //сменям името на нишката с генерираното име
   

            
        }
    }
}
