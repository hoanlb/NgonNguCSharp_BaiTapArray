using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapArray_TimArrayMaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter the number of elements in the array:");
            n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int arrayMaxValue = numbers[0];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element number" + i + ":");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array is:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                if (numbers[i] > arrayMaxValue)
                {
                    arrayMaxValue = numbers[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Array max value is: " + arrayMaxValue);

            Console.ReadKey();
        }
    }
}
