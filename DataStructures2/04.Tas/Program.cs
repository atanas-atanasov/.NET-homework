using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {


            HashSet<int> sequence1 = new HashSet<int>();
            HashSet<int> sequence2 = new HashSet<int>();
            HashSet<int> sequence3 = new HashSet<int>();
            int arr0 = 1;
            int f2 = 2;
            int f3 = 2;
            sequence1.Add(arr0);
            sequence2.Add(f2);
            sequence3.Add(f3);
            int currentNum = 0;

            //creating sequence 1
            for (int i = 1; i <= 100000; i++)
            {

                currentNum = 2 * arr0 + 3;
                if (currentNum > 100000)
                {
                    break;
                }
                sequence1.Add(currentNum);
                arr0 = currentNum;

            }


            //creating sequence 2
            for (int i = 1; i <= 100000; i++)
            {

                currentNum = 3 * f2 + 1;
                if (currentNum > 100000)
                {
                    break;
                }
                sequence2.Add(currentNum);
                f2 = currentNum;

            }


            //creating sequence 3
            for (int i = 1; i <= 100000; i++)
            {

                currentNum = 2 * f3 - 1;
                if (currentNum > 100000)
                {
                    break;
                }
                sequence3.Add(currentNum);
                f3 = currentNum;

            }


            //  1/f1 * f2;   2/f1 * f3;  3/f2 * f3;  4/f1 * f2 * f3;  5/f1 + f2;  6/f1 + f3;  7/f2 + f3;  8/f1 + f2 + f3. 
            int[] task1 = sequence1.Intersect(sequence2).ToArray();
            int[] task2 = sequence1.Intersect(sequence3).ToArray();
            int[] task3 = sequence2.Intersect(sequence3).ToArray();
            int[] task4 = sequence1.Intersect(sequence2.Intersect(sequence3)).ToArray();
            int[] task5 = sequence1.Union(sequence2).ToArray();
            Array.Sort(task5);
            int[] task6 = sequence1.Union(sequence3).ToArray();
            Array.Sort(task6);
            int[] task7 = sequence2.Union(sequence3).ToArray();
            Array.Sort(task7);
            int[] task8 = sequence1.Union(sequence2.Union(sequence3)).ToArray();
            Array.Sort(task8);

            //Printvam samo 1. mnogo neshta stavat.
            foreach (var item in task5)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
