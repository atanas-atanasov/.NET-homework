using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която изчислява бонус точки на база резултат от игра. Потребителят трябва да въведе своите точки в интервалa[1;9].
//Ако точките са в интервала [1;3], добавете 5 към тях. Ако точките са в интервала [4;6], умножете ги по 12. Ако точките са в интервала [7;9],
//умножете ги по 50 и ги разделете целочислено на 3. Резултатът изведете на екрана.


namespace _07.TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your points from 1 to 9");
            byte points = Convert.ToByte(Console.ReadLine());
            if (points >= 1 && points <= 3)
            {
                points += 5;
                Console.WriteLine("Your result is:" + points);
            }
            else if (points>3 && points <7)
            {
                points *=12;
                Console.WriteLine("Your result is:" + points);
            }
            else if (points>6 && points<10)
            {
                points *= 50;
                Console.WriteLine("Your result is:" + points);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
            
        }
    }
}
