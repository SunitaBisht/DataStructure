using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            int i;

            for (i = 0; i < n; i++)
            {
                arr[i] = i + 1;
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                    Console.WriteLine();
                    int x = 50;
                    int pos = 5;

                    int[] newarr = new int[n + 1];
                    for (i = 0; i < n + 1; i++)
                    {
                        if (i < pos - 1)
                            newarr[i] = arr[i];
                        else if (i == pos - 1)
                            newarr[i] = x;
                        else
                            newarr[i] = arr[i - 1];

                    }
                    for (i = 0; i < n + 1; i++)
                    {
                        Console.WriteLine(newarr[i] + " ");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
