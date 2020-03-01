using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommonElement
{
    class Program
    {
        static void findcommon(int[] ar1, int[] ar2, int[] ar3)
        {
            int i = 0, j = 0, k = 0;
            while (i < ar1.Length && j < ar2.Length && k < ar3.Length)
            {
                if (ar1[i] == ar2[j] && ar2[j] == ar3[k])
                {
                    Console.Write(ar1[i] + " ");
                    i++;
                    j++;
                    k++;
                }
                else if (ar1[i] < ar2[j])
                    i++;
                else if (ar2[j] < ar3[k])
                    j++;
                else
                    k++;
            }
        }
        static void Main(string[] args)
        {
            int[] ar1 = { 1, 5, 10, 20, 40, 80 };
            int[] ar2 = { 6, 7, 20, 80, 100 };
            int[] ar3 = { 3, 4, 15, 20, 30, 70, 80, 120 };

            Console.WriteLine("Common elemnts are:");
            findcommon(ar1, ar2, ar3);
            Console.ReadKey();
        }
    }
}
