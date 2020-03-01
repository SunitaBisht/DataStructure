using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumElementinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i, n, min = a[0];
            Console.WriteLine("Enter the number of element:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element:");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {

                if (min > a[i])
                {
                    min = a[i];
                }

                Console.WriteLine("The min element is :" + min);
                Console.ReadKey();
            }
        }
    }
}