using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която принтира фигура във формата на борче със знака "o".


namespace _10.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writne positive number for tree size:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(new string(' ', n - j-1));
                    Console.WriteLine(new string('o',1+j*2));
                }
                
            }
            Console.Write(new string(' ', n-1));
            Console.WriteLine(new string('o', 1));
            Console.WriteLine();
        }
    }
}
