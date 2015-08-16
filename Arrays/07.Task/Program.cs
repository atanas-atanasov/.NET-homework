using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която попълва квадратна матрица спираловидно по посока на часовниковата страна. Потребителя въвежда размерност на матрицата.


namespace _07.Task
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
            for (j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[0, j] = j + 1;
            }

            for (int n = 1; n < size; n++)           
            {
                if (n%2==1)                                 //dolu+lqvo
                {
                    for (int n1 = 0; n1 < size - n; n1++)  //dolu
                    {
                        i = n1 + 1 + (n / 2);
                        j = size - (n / 2 + 1);
                        matrix[i, j] = n * size + i + size - j - 1 + ((size - 4) * 2 + 2 - 2 * (size - j - 1));
                        i = n1 + 1;
                        j = size - 1;
                        matrix[i, j] = 1 + size+n1;
                    }

                    for (int n1 = 0; n1 < size; n1++)
                    {
                        i = size-1-n/2;
                        j = n1 - (n / 2+1);
                        matrix[i, j] = n * size + i + size - j - 1;// +((size - 4) * 2 + 2 - 2 * (size - j - 1));
                    }
                    //for (int n1 = 0; n1 <= size; n1++)
                    //{
                    //    i = size -1- (n / 2);
                    //    j = size-n1;
                    //    matrix[i, j] = n * size + i + size - j - 1;

                    //}

                    ////lqvo
                    //for (int n1 = 0; n1 < size; n1++)
                    //{
                    //    i = size - (n / 2);
                    //    j = n1 + (n / 2);
                    //    matrix[i, j] = n * size + i + size - j - 1 + ((size - 4) * 2 + 2 - 2 * (size - j - 1));
                    //}
                }

                       // matrix[i, j] = size^ - size * j + i;  //(n * size) + i + size - j - 1;  
                    //    if (n==3)                                       //Този If - else го сложих, защото когато n=3 числата ми излизаха с 4 единици по-малки и не можах да разбера защо
                    //    {                                               //и само така успях да реша проблема.(важи за 4те if - else надолу)
                    //       matrix[i, j] = n * size + i + size - j +3;   
                    //    }
                    //    else
                    //    {
                     //      int a 
                       //    matrix[i, j] = n * size + i + size - j - 1;   
                    //    }         
                    //}

                    //for (int n1 = 0; n1 < size - n; n1++)             //lqvo
                    //{
                    //    i = size - (n / 2 + 1);
                    //    j = n1 + (n / 2);
                    //    if (n == 3)
                    //    {
                    //        matrix[i, j] = n * size + i + size - j + 3;
                    //    }
                    //    else
                    //    {
                    //        matrix[i, j] = n * size + i + size - j - 1;
                           
                
                
                //if (n%2==0)
                //{
                //    for (int n1 = 0; n1 < size; n1++)
                //    {
                        
                //    }
                //}
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
