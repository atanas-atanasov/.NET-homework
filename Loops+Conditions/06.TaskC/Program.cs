using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която по избор на потребителя прочита от конзолата променлива от тип int, double или string.
//Ако променливата е int или double, трябва да се увеличи с 1. Ако променливата е string, трябва да се прибави накрая символа "*".
//Отпечатайте получения резултат на конзолата. 


namespace _06.TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\n 1.Enter integer\n 2.Enter real number\n 3.Enter string");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num+1);
                    break;
                case 2:
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(num2+1);
                    break;
                case 3:
                    string str = Console.ReadLine();
                    Console.WriteLine(str+"*");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
