using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAnWaveForm
{
    class Program
    {
        void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        void sortInwave(int[] arr, int n)
        {
            Array.Sort(arr);
            for (int i = 0; i < n - 1; i += 2)
            swap(arr, i, i + 1);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int n = arr.Length;
            obj.sortInwave(arr, n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
                Console.ReadKey();
            }
        }
    }
}
