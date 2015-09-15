
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
    

            Thread t1 = new Thread(new ThreadStart(Job));
            Thread t2 = new Thread(new ThreadStart(Job));
            Thread t3 = new Thread(new ThreadStart(Job));
            Thread t4 = new Thread(new ThreadStart(Job));
            Thread t5 = new Thread(new ThreadStart(Job));

            t1.Start();
            t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();
            t1.Name = Job1();
            t2.Name = Job1();

            Console.WriteLine("sdadsad " + t1.Name);
            Console.WriteLine("sdsadas " + t2.Name);
            
        }



        private static void Job()
        {
            Console.WriteLine("The thread is started");
          //  Генериране на име
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            Random rand = new Random();
            Thread.Sleep(5);
            char[] test = new char[rand.Next(4, 10)]; //дължина на името
            for (int i = 0; i < test.Length; i++)
            {
                Thread.Sleep(5);
                test[i] = chars[rand.Next(0, 25)];        //знак за всеки индекс от масива с името
            }
            string testString = new string(test);
            testString = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(testString); //първата буква да е главна.
          //  Thread.CurrentThread.Name = testString;                                           //сменям името на нишката с генерираното име
          
            Console.WriteLine("Hello! I am a thread. My name is {0}.", Thread.CurrentThread.Name);
            Console.WriteLine("I am going to sleep.");
            int sleep = Environment.TickCount;
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("I slept for {0} miliseconds!",(Environment.TickCount-sleep));
            Console.WriteLine("The thread is complete");
            
            
        }

        private static string Job1()
        {
            Console.WriteLine("The thread is started");
            //  Генериране на име
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            Random rand = new Random();
            Thread.Sleep(5);
            char[] test = new char[rand.Next(4, 10)]; //дължина на името
            for (int i = 0; i < test.Length; i++)
            {
                Thread.Sleep(5);
                test[i] = chars[rand.Next(0, 25)];        //знак за всеки индекс от масива с името
            }
            string testString = new string(test);
            testString = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(testString); //първата буква да е главна.
           // Thread.CurrentThread.Name = testString;                                           //сменям името на нишката с генерираното име

            Console.WriteLine("Hello! I am a thread. My name is {0}.", Thread.CurrentThread.Name);
            Console.WriteLine("I am going to sleep.");
            int sleep = Environment.TickCount;
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("I slept for {0} miliseconds!", (Environment.TickCount - sleep));
            Console.WriteLine("The thread is complete");
            return testString;

        }
    }
}