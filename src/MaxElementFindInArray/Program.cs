using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementFindInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i, max = 0,n;
            Console.WriteLine("Enter the number of element in array:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the elements in array:");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("The max element is:" + max);
            Console.ReadKey();
        }
    }
}
