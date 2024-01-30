using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapArray_GetSumDuongCheoChinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Nhap so dong:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            m = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];

            int sumDuongCheoChinh = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap phan tu dong " + i + " cot " + j + "\n");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                    if (i == j)
                    {
                        sumDuongCheoChinh = sumDuongCheoChinh + numbers[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tong duong cheo chinh la: " + sumDuongCheoChinh);

            Console.ReadKey();
        }
    }
}
