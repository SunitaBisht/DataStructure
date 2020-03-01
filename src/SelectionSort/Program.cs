using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, j, temp = 0, n;
            Console.WriteLine("Enter the number of elements:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the elements:");
                a[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])            //for assending order when arrange in decending order so use less then(<)
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            Console.ReadLine();
        }
    }
}
