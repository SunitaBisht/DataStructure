using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeSorting
{
    class Program
    {
        static void alternateSort(int[] arr, int n)
        {
            Array.Sort(arr);
            int i = 0, j = n - 1;
            while (i < j)
            {
                Console.Write(arr[j--] + "  ");
                Console.Write(arr[i++] + "  ");
            }
            if (n % 2 != 0)
                Console.WriteLine(arr[i]);
            Console.ReadKey();

            }
        static void Main(string[] args)
        {
            int[] arr = { 1, 12, 4, 6, 7, 10 };
            int n = arr.Length;
            alternateSort(arr, n);
        }

    }
}
