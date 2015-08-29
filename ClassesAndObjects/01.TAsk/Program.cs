using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TAsk
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat[] arrayOfCats = new Cat[10];

            Cat cat1 = new Cat("Mimi", 1);
            Cat cat2 = new Cat("Didi", 2);
            Cat cat3 = new Cat("Lili", 3);
            Cat cat4 = new Cat("Regi", 4);
            Cat cat5 = new Cat("Iri", 5);
            Cat cat6 = new Cat("Kati", 6);
            Cat cat7 = new Cat("Sneji", 7);
            Cat cat8 = new Cat("Eli", 8);
            Cat cat9 = new Cat("Magi", 9);
            Cat cat10 = new Cat("KOLIO", 10);

            arrayOfCats[0] = cat1;
            arrayOfCats[1] = cat2;
            arrayOfCats[2] = cat3;
            arrayOfCats[3] = cat4;
            arrayOfCats[4] = cat5;
            arrayOfCats[5] = cat6;
            arrayOfCats[6] = cat7;
            arrayOfCats[7] = cat8;
            arrayOfCats[8] = cat9;
            arrayOfCats[9] = cat10;
            foreach (Cat item in arrayOfCats)
            {
                item.Say();
            }

        }
    }
}
