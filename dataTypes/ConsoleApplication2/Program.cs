using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Направете програма, която приема две цели числа - съответно страните на правоъгълник. Пресметнете лицето на дадения правоъгълник и я изведете на конзолата.


namespace ConsoleApplication2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first side of rectangle:");
            uint a = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side of rectangle:");
            uint b = uint.Parse(Console.ReadLine());
            Console.WriteLine("The surface of the rectangle is:" + a*b);
        }
    }
}
