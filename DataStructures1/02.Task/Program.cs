using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oldNumbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            int[] array = new int[oldNumbers.Count + 1];          
            oldNumbers.Sort();
            for (int i = 0; i < oldNumbers.Count; i++)
            {
                array[oldNumbers[i]]++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==1 && array[i]!=0)
                {

                    oldNumbers.RemoveAll(item => item == array[i]); // НЕ знам пробвах 20 различни неща ... не мога да оцеля индексите явно.
                }
            }
            foreach (var item in oldNumbers)
            {
                Console.WriteLine(item);
            }
                
            //for (int i = 0; i < newNumbers.Count; i++)
            //{
            //    if (newNumbers[i]%2==0)
            //    {
            //        Console.WriteLine(newNumbers[i]);
            //    }
            //}

        }
    }
}
