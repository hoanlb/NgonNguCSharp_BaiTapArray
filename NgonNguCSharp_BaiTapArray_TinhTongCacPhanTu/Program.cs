using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapArray_TinhTongCacPhanTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int arrayNumbersSum = 0;

            Console.WriteLine("Enter the number of elements in the array:");
            n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element number" + i + ":");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array is:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");

                arrayNumbersSum = arrayNumbersSum + numbers[i];
            }

            Console.WriteLine();
            Console.WriteLine("Array numbers sum is: " + arrayNumbersSum);

            Console.ReadKey();
        }
    }
}
