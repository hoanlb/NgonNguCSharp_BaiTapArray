using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapArray_GetArrayMaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;

            Console.WriteLine("Nhap so dong:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            m = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, m];

            int maxValue = numbers[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <  m; j++)
                {
                    Console.Write("Nhap phan tu dong " + i + " cot " + j + "\n");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                    if (numbers[i, j] > maxValue)
                    {
                        maxValue = numbers[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array max is: " + maxValue);
                
            Console.ReadKey();
        }
    }
}
