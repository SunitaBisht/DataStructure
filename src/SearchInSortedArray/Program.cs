using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInSortedArray
{
    class Program
    {
        public static int binarySearch(int[]arr,int low,int high,int key)
        {
            if (high < low)
            {
                return -1;
            }

            int mid = (low + high) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            if (key > arr[mid])
            {
                return binarySearch(arr, (mid + 1), high, key);
            }
            return binarySearch(arr, low, (mid - 1), key);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 6, 7, 8, 9, 10 };
            int n, key;
            n = arr.Length;
            key = 10;
            Console.WriteLine("Index:" + binarySearch(arr, 0, n, key));
            Console.ReadKey();
        }
    }
}
