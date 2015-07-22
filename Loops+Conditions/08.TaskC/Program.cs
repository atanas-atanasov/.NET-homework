using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Класическото тесте карти се състои от 13 различни вида карти съответно 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Направете програма, която приема от конзолата един символ и принтира "Валидна карта", ако символът представлява валидна карта,
//и съответно принтира "Невалидна карта", ако символът е на невалидна карта. 


namespace _08.TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            choice = choice.ToUpper();
            switch (choice)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "K":
                case "Q":
                case "J":
                    Console.WriteLine("Валидна карта");
                    break;
                default:
                    Console.WriteLine("Невалидна карта");
                    break;
            }


        }
    }
}
