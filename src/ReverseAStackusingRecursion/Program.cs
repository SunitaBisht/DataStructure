using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReverseAStackusingRecursion
{
    class Program
    {
        static Stack st = new Stack();
        public void insert_at_bottom(char x)
        {
            if (st.Count == 0)
                st.Push(x);
            else
            {
                char a = (char)st.Peek();
                st.Pop();
                insert_at_bottom(x);
                st.Push(a);
            }
        }
        static void reverse()
        {
            if (st.Count > 0)
            {
                char x = (char)st.Peek();
                st.Pop();
                reverse();
                insert_at_bottom(x);
            }
        }

        static void Main(string[] args)
        {
            st.Push("1");
            st.Push("2");
            st.Push("3");
            st.Push("4");
            Console.WriteLine("Orignal stack");
            foreach (char i in st)
            {
                Console.WriteLine(i);
            }
            reverse();
            Console.WriteLine("Reversed stack");
            foreach(char i in st)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }

        }
    }
}
