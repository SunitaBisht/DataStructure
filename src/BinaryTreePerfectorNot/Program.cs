using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePerfectorNot
{
    class Program
    {
        class Node
        {
            public int key;
            public Node left, right;
        }
        static int findADepth(Node node)
        {
            int d = 0;
            while (node != null)
            {
                d++;
                node = node.left;
            }
            return d;
        }
        static bool isPerfectRec(Node root, int d, int level)
        {
            if (root == null)
                return true;
            if (root.left == null || root.right == null)
                return false;

            return isPerfectRec(root.left, d, level + 1) &&
                   isPerfectRec(root.right, d, level + 1);
        }
        static bool isPerfect(Node root)
        { 
                int d = findADepth(root);
                return isPerfectRec(root, d, 0);
        }
        static Node newNode(int k)
        {
            Node node = new Node();
            node.key = k;
            node.right = null;
            node.right = null;
            return node;
        }
        static void Main(string[] args)
        {
           
            Node root = null;
            //List<int> list = new List<int>();
            root = newNode(10);
            root.left = newNode(20);
            root.right = newNode(30);
            root.left.left = newNode(40);
            root.left.right = newNode(50);
            root.right.left = newNode(60);
            root.right.right = newNode(70);

            if (isPerfect(root) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadLine();
            
        }
    }
}
