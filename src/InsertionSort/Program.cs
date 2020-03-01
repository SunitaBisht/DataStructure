using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, j, n, temp=0;
            Console.WriteLine("Enter the number of elements:");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the elements:");
                a[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < n-1; i++)
            {
               j = i;
               while (j > 0 && a[j] < a[j - 1])
               {
                    temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                    j--;
                }
            }
            Console.WriteLine("The list in ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            Console.ReadKey();
        }
    }
}
