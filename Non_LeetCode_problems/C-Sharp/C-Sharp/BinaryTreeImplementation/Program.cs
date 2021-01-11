using System;
using System.Collections.Generic;

namespace BinaryTreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1, 
                new Node(2, 
                    new Node(4), 
                    new Node(5)
                    ), 
                new Node(3, 
                    new Node(6), 
                    new Node(7))
                );

            Console.WriteLine(BTreeString(root));

            static string BTreeString(Node root)
            {
                string nodeStr = "";

                if (root.Left != null)
                {
                    nodeStr += BTreeString(root.Left);
                }
                if (root.Right != null)
                {
                    nodeStr += BTreeString(root.Right);
                }
                
                return nodeStr += root.Value;
            }
        }
    }
}
