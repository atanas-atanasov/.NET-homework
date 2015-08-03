using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която попълва квадратна матрица: първо вертикално, след това хоризонтално. Потребителя въвежда размерност на матрицата.


namespace _06.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of matrix:");
            int size = int.Parse(Console.ReadLine());
            int i = size;
            int j = size;
            int[,] matrix = new int[i, j];

            Console.WriteLine();
            for (int k = 0; k < size*size; k++)
			{
                i = k % size;
                j = k / size;
                matrix[i, j] = k+1;
			}

            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("   " + matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
