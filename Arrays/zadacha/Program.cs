using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Person valio = new Person();
            valio.Name = "Ben";
            valio.Years = 20;
            valio.EMail = "dsada@adsa.com";

            Person ivan = new Person( );
            ivan.Name = "ivan";
            ivan.Years=25;
            ivan.EMail = "sada@dsad.bg";

            Console.WriteLine();
        }
    }
}
