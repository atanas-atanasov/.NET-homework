using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        private static Thread t2 = new Thread(new ThreadStart(Running));
        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(Sleep));
            t1.Start();
            t2.Start();

        }

        private static void Running()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            }
        }

        private static void Sleep()
        {

            for (int i = 0; i <= 50000; i++)
            {
                Console.WriteLine(i);
                if (i == 25000)
                {
                    Thread.Sleep(500);
                    t2.Join();
                }
            }


        }
    }
}
