using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node (int val, Node left = null, Node right = null)
        {
            Value = val;
            Left = left;
            Right = right;
        }
    }
}
