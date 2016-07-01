using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив
{
    class Program
    {
        static void Main(string[] args)
        {

            int minVal = 0;

            Console.WriteLine("Введите высоту матрицы");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину матрицы");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] mass = new int[m, n];
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(-10, 10);
                    if (mass[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            int[] B = new int[count];
            Console.WriteLine("Исходный массив\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}\t", mass[i, j]);
                }
                Console.WriteLine();
            }
            count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mass[i, j].Equals(minVal))
                    {
                        Console.Write(i + j);

                        //выход из цикла
                        i = mass.GetLength(0);
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
/* for (int i = 0; i < m; i++)
 {
     for (int j = 0; j < n; j++)
     {
         if (mass[i, j] < 0)
         {
             B[count] = mass[i, j];
             Console.WriteLine(B[count]);
             count++;
         }
     }
 }*/
